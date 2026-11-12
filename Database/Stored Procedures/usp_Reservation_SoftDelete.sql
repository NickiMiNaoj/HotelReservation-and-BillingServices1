CREATE PROCEDURE [dbo].[usp_Reservation_SoftDelete]
    @ReservationID INT,
    @DeletedBy     INT          -- the EmployeeID of the logged-in user
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM [dbo].[tblEmployees]
                   WHERE [EmployeeID] = @DeletedBy AND [AccountStatus] = 'Active')
    BEGIN
        RAISERROR('Employee not found.', 16, 1);
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM [dbo].[tblReservations] WHERE [ReservationID] = @ReservationID)
    BEGIN
        RAISERROR('Reservation not found.', 16, 1);
        RETURN;
    END

    IF EXISTS (SELECT 1 FROM [dbo].[tblReservations]
               WHERE [ReservationID] = @ReservationID AND [IsDeleted] = 1)
    BEGIN
        RAISERROR('Reservation is already deleted.', 16, 1);
        RETURN;
    END

    IF EXISTS (SELECT 1 FROM [dbo].[tblReservations]
               WHERE [ReservationID] = @ReservationID AND [Status] = 'CheckedIn')
    BEGIN
        RAISERROR('Check the guest out before deleting this reservation.', 16, 1);
        RETURN;
    END

    -- Soft delete: the row stays in the table, it is only hidden from Front Desk
    UPDATE [dbo].[tblReservations]
    SET    [IsDeleted] = 1,
           [DeletedAt] = SYSDATETIME(),
           [DeletedBy] = @DeletedBy
    WHERE  [ReservationID] = @ReservationID;
END