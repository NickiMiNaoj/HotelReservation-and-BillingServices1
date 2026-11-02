CREATE PROCEDURE dbo.sp_ProcessCheckOut
    @ReservationID INT,
    @RoomID INT,
    @ActualCheckOutTime DATETIME,
    @CheckOutRemarks NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY
        UPDATE dbo.tblReservations 
        SET Status = 'Completed',
            DepartureDate = @ActualCheckOutTime,
            Remarks = @CheckOutRemarks
        WHERE ReservationID = @ReservationID;

        UPDATE dbo.tblRooms 
        SET Status = 'Needs Housekeeping' 
        WHERE RoomID = @RoomID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO