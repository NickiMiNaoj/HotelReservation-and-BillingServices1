-- Availability for a date range. A room is 'Booked' when an active reservation
-- (Pending, Confirmed or Checked-In) overlaps the requested dates; Cancelled and Completed
-- reservations do not block. Rooms in Maintenance are reported as 'Maintenance'.
--
-- @AvailableOnly = 0 returns every room with its AvailabilityStatus (matches the Availability grid);
-- @AvailableOnly = 1 returns only the rooms that can be booked (use this for the booking screen).
-- @ExcludeReservationID lets an existing booking be re-checked without blocking itself (e.g. when editing dates).
CREATE PROCEDURE dbo.sp_GetRoomAvailability
    @ArrivalDate          DATETIME,
    @DepartureDate        DATETIME,
    @RoomType             NVARCHAR(50) = NULL,
    @MinCapacity          INT = NULL,
    @AvailableOnly        BIT = 0,
    @ExcludeReservationID INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @ArrivalDate IS NULL OR @DepartureDate IS NULL OR @DepartureDate <= @ArrivalDate
        THROW 50001, 'Departure date must be later than arrival date.', 1;

    SELECT r.RoomID,
           r.RoomNumber,
           r.RoomType,
           r.NightlyRate,
           r.Capacity,
           r.Description,
           CASE WHEN r.RoomStatus = 'Maintenance' THEN 'Maintenance'
                WHEN b.RoomID IS NOT NULL         THEN 'Booked'
                ELSE 'Available'
           END AS AvailabilityStatus
    FROM dbo.tblRooms AS r
    OUTER APPLY (
        SELECT TOP (1) rr.RoomID
        FROM dbo.tblReservationRooms AS rr
        INNER JOIN dbo.tblReservations AS res ON res.ReservationID = rr.ReservationID
        WHERE rr.RoomID = r.RoomID
          AND res.Status IN ('Pending', 'Confirmed', 'Checked-In')
          AND res.ArrivalDate   < @DepartureDate     -- overlap test: [Arrival, Departure) ranges intersect
          AND res.DepartureDate > @ArrivalDate
          AND (@ExcludeReservationID IS NULL OR res.ReservationID <> @ExcludeReservationID)
    ) AS b
    WHERE (@RoomType    IS NULL OR r.RoomType = @RoomType)
      AND (@MinCapacity IS NULL OR r.Capacity >= @MinCapacity)
      AND (@AvailableOnly = 0 OR (r.RoomStatus <> 'Maintenance' AND b.RoomID IS NULL))
    ORDER BY r.RoomNumber;
END;
GO
