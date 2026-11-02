CREATE PROCEDURE dbo.sp_ProcessCheckIn
    @ReservationID INT,
    @RoomID INT,
    @KeyCardNumber NVARCHAR(50),
    @Remarks NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY

        UPDATE dbo.tblReservations 
        SET Status = 'Checked-In', 
            KeyCardNumber = @KeyCardNumber, 
            Remarks = @Remarks 
        WHERE ReservationID = @ReservationID;

        UPDATE dbo.tblRooms 
        SET Status = 'Occupied' 
        WHERE RoomID = @RoomID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO