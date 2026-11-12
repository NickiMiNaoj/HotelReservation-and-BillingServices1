CREATE PROCEDURE [dbo].[usp_Reservation_Insert]
    @GuestID           INT,
    @RoomID            INT,
    @CheckInDate       DATE,
    @CheckOutDate      DATE,
    @NumAdults         INT,
    @NumChildren       INT = 0,
    @SpecialRequests   NVARCHAR (500) = NULL,
    @AdditionalCharges DECIMAL (10, 2) = 0,
    @Discount          DECIMAL (10, 2) = 0,
    @Status            NVARCHAR (20) = 'Pending'
AS
BEGIN
    SET NOCOUNT ON;

    IF @CheckOutDate <= @CheckInDate
    BEGIN
        RAISERROR('Check-out date must be after the check-in date.', 16, 1);
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM [dbo].[tblGuests] WHERE [GuestID] = @GuestID)
    BEGIN
        RAISERROR('Guest not found.', 16, 1);
        RETURN;
    END

    DECLARE @Rate DECIMAL (10, 2), @MaxCapacity INT, @RoomStatus NVARCHAR (30);

    SELECT @Rate = [NightlyRate], @MaxCapacity = [MaxCapacity], @RoomStatus = [Status]
    FROM   [dbo].[tblRooms]
    WHERE  [RoomID] = @RoomID;

    IF @Rate IS NULL
    BEGIN
        RAISERROR('Room not found.', 16, 1);
        RETURN;
    END

    IF @RoomStatus = 'Under Maintenance'
    BEGIN
        RAISERROR('This room is under maintenance and cannot be booked.', 16, 1);
        RETURN;
    END

    IF @NumAdults + @NumChildren > @MaxCapacity
    BEGIN
        RAISERROR('The number of guests is more than the room capacity.', 16, 1);
        RETURN;
    END

    BEGIN TRANSACTION;

    -- Deleted and cancelled reservations do not block a room
    IF EXISTS (SELECT 1 FROM [dbo].[tblReservations] WITH (UPDLOCK, HOLDLOCK)
               WHERE [RoomID] = @RoomID
                 AND [IsDeleted] = 0
                 AND [Status] IN ('Pending', 'Confirmed', 'CheckedIn')
                 AND [CheckInDate] < @CheckOutDate
                 AND [CheckOutDate] > @CheckInDate)
    BEGIN
        ROLLBACK TRANSACTION;
        RAISERROR('The room is already booked for the selected dates.', 16, 1);
        RETURN;
    END

    INSERT INTO [dbo].[tblReservations]
        ([GuestID], [RoomID], [CheckInDate], [CheckOutDate], [NumAdults], [NumChildren],
         [SpecialRequests], [RoomRate], [AdditionalCharges], [Discount], [Status])
    VALUES
        (@GuestID, @RoomID, @CheckInDate, @CheckOutDate, @NumAdults, @NumChildren,
         @SpecialRequests, @Rate, @AdditionalCharges, @Discount, @Status);

    DECLARE @NewID INT = SCOPE_IDENTITY();

    COMMIT TRANSACTION;

    -- Returns the new auto-generated Reservation ID
    SELECT @NewID AS [ReservationID];
END