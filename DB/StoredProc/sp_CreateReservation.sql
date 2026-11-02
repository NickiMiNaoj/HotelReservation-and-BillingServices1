-- Saves a booking atomically: one tblReservations row + one tblReservationRooms row per room.
-- Everything succeeds or nothing is saved. TotalAmount is calculated here from tblRooms.NightlyRate
-- (sum of the selected rooms x nights), so the client never supplies a price.
--
-- Active statuses that block dates: Pending, Confirmed, Checked-In.
-- Date rule: a stay occupies [ArrivalDate, DepartureDate), so one guest can leave and the next arrive the same day.
--
-- Error numbers: 50001 dates | 50002 counts | 50003 status | 50004 no rooms | 50005 unknown room
--                50006 room in maintenance | 50007 over capacity | 50008 unknown guest | 50009 dates already booked
CREATE PROCEDURE dbo.sp_CreateReservation
    @GuestID       INT,
    @ArrivalDate   DATETIME,
    @DepartureDate DATETIME,
    @AdultCount    INT,
    @Rooms         dbo.udtRoomIdList READONLY,
    @KidCount      INT = 0,
    @InfantCount   INT = 0,
    @Status        NVARCHAR(20) = 'Pending',
    @ReservationID INT = NULL OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;   -- any runtime error dooms the transaction instead of leaving it half-open

    DECLARE @RoomsRequested INT,
            @RoomsFound     INT,
            @InMaintenance  INT,
            @TotalCapacity  INT,
            @NightlyTotal   DECIMAL(12,2),
            @Nights         INT,
            @TotalAmount    DECIMAL(12,2);

    SET @KidCount    = ISNULL(@KidCount, 0);
    SET @InfantCount = ISNULL(@InfantCount, 0);
    SET @Status      = ISNULL(@Status, 'Pending');

    BEGIN TRY
        -- Input checks (no locks needed yet)
        IF @ArrivalDate IS NULL OR @DepartureDate IS NULL OR @DepartureDate <= @ArrivalDate
            THROW 50001, 'Departure date must be later than arrival date.', 1;

        IF ISNULL(@AdultCount, 0) < 1 OR @KidCount < 0 OR @InfantCount < 0
            THROW 50002, 'At least one adult is required, and guest counts cannot be negative.', 1;

        IF @Status NOT IN ('Pending', 'Confirmed')
            THROW 50003, 'A new reservation must start as Pending or Confirmed.', 1;

        SELECT @RoomsRequested = COUNT(*) FROM @Rooms;
        IF @RoomsRequested = 0
            THROW 50004, 'Select at least one room.', 1;

        BEGIN TRANSACTION;

        -- Lock the selected room rows. Every booking attempt must pass through this statement first,
        -- so two people booking the same room for overlapping dates run one after the other
        -- and the second one sees the first one's reservation in the overlap check below.
        SELECT @RoomsFound    = COUNT(*),
               @InMaintenance = ISNULL(SUM(CASE WHEN r.RoomStatus = 'Maintenance' THEN 1 ELSE 0 END), 0),
               @TotalCapacity = ISNULL(SUM(r.Capacity), 0),
               @NightlyTotal  = ISNULL(SUM(r.NightlyRate), 0)
        FROM dbo.tblRooms AS r WITH (UPDLOCK)
        INNER JOIN @Rooms AS x ON x.RoomID = r.RoomID;

        IF @RoomsFound <> @RoomsRequested
            THROW 50005, 'One or more selected rooms do not exist.', 1;

        IF @InMaintenance > 0
            THROW 50006, 'One or more selected rooms are under maintenance.', 1;

        IF @AdultCount + @KidCount > @TotalCapacity   -- infants are not counted against capacity
            THROW 50007, 'The selected rooms cannot hold this many guests.', 1;

        IF NOT EXISTS (SELECT 1 FROM dbo.tblGuests WHERE GuestID = @GuestID)
            THROW 50008, 'Guest does not exist.', 1;

        -- Overlap test: existing.Arrival < new.Departure AND existing.Departure > new.Arrival
        IF EXISTS (
            SELECT 1
            FROM dbo.tblReservationRooms AS rr
            INNER JOIN dbo.tblReservations AS res ON res.ReservationID = rr.ReservationID
            INNER JOIN @Rooms AS x ON x.RoomID = rr.RoomID
            WHERE res.Status IN ('Pending', 'Confirmed', 'Checked-In')
              AND res.ArrivalDate   < @DepartureDate
              AND res.DepartureDate > @ArrivalDate
        )
            THROW 50009, 'One or more selected rooms are already booked for these dates.', 1;

        -- Price: nights are counted by calendar day, minimum 1 (same-day stays are charged one night)
        SET @Nights = DATEDIFF(DAY, @ArrivalDate, @DepartureDate);
        IF @Nights < 1 SET @Nights = 1;
        SET @TotalAmount = @NightlyTotal * @Nights;

        INSERT INTO dbo.tblReservations
            (GuestID, ArrivalDate, DepartureDate, AdultCount, KidCount, InfantCount, TotalAmount, Status, CreatedAt)
        VALUES
            (@GuestID, @ArrivalDate, @DepartureDate, @AdultCount, @KidCount, @InfantCount, @TotalAmount, @Status, GETDATE());

        SET @ReservationID = SCOPE_IDENTITY();

        INSERT INTO dbo.tblReservationRooms (ReservationID, RoomID, RateAtBooking)
        SELECT @ReservationID, r.RoomID, r.NightlyRate
        FROM dbo.tblRooms AS r
        INNER JOIN @Rooms AS x ON x.RoomID = r.RoomID;

        COMMIT TRANSACTION;

        SELECT @ReservationID AS ReservationID,
               @TotalAmount   AS TotalAmount,
               @Nights        AS Nights;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        SET @ReservationID = NULL;
        THROW;   -- re-raise the original error to the caller
    END CATCH
END;
GO
