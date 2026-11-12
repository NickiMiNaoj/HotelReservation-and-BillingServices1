CREATE PROCEDURE [dbo].[usp_Reservation_Restore]
    @ReservationID INT,
    @RestoredBy    INT          -- the EmployeeID of the logged-in user (must be an Admin)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM [dbo].[tblEmployees]
                   WHERE [EmployeeID] = @RestoredBy AND [Role] = 'Admin' AND [AccountStatus] = 'Active')
    BEGIN
        RAISERROR('Only an Admin can restore reservations.', 16, 1);
        RETURN;
    END

    DECLARE @RoomID INT, @CheckIn DATE, @CheckOut DATE, @Status NVARCHAR (20);

    SELECT @RoomID = [RoomID], @CheckIn = [CheckInDate], @CheckOut = [CheckOutDate], @Status = [Status]
    FROM   [dbo].[tblReservations]
    WHERE  [ReservationID] = @ReservationID AND [IsDeleted] = 1;

    IF @RoomID IS NULL
    BEGIN
        RAISERROR('Deleted reservation not found.', 16, 1);
        RETURN;
    END

    -- The room may have been booked by someone else while this reservation was deleted
    IF @Status IN ('Pending', 'Confirmed', 'CheckedIn')
       AND EXISTS (SELECT 1 FROM [dbo].[tblReservations]
                   WHERE [RoomID] = @RoomID
                     AND [ReservationID] <> @ReservationID
                     AND [IsDeleted] = 0
                     AND [Status] IN ('Pending', 'Confirmed', 'CheckedIn')
                     AND [CheckInDate] < @CheckOut
                     AND [CheckOutDate] > @CheckIn)
    BEGIN
        RAISERROR('Cannot restore: the room is already booked for those dates.', 16, 1);
        RETURN;
    END

    UPDATE [dbo].[tblReservations]
    SET    [IsDeleted] = 0,
           [DeletedAt] = NULL,
           [DeletedBy] = NULL
    WHERE  [ReservationID] = @ReservationID;
END