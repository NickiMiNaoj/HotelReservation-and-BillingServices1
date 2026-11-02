-- Moves a reservation through its lifecycle. Cancelled / Completed reservations stop blocking dates
-- in sp_GetRoomAvailability. They are final: re-activating one could double-book a room,
-- so a new reservation must be made instead.
--
-- Allowed: Pending -> Confirmed | Cancelled
--          Confirmed -> Checked-In | Cancelled
--          Checked-In -> Completed
CREATE PROCEDURE dbo.sp_UpdateReservationStatus
    @ReservationID INT,
    @Status        NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE @Current NVARCHAR(20);

    BEGIN TRY
        BEGIN TRANSACTION;

        SELECT @Current = Status
        FROM dbo.tblReservations WITH (UPDLOCK)
        WHERE ReservationID = @ReservationID;

        IF @Current IS NULL
            THROW 50020, 'Reservation not found.', 1;

        IF NOT (   (@Current = 'Pending'    AND @Status IN ('Confirmed', 'Cancelled'))
                OR (@Current = 'Confirmed'  AND @Status IN ('Checked-In', 'Cancelled'))
                OR (@Current = 'Checked-In' AND @Status = 'Completed'))
            THROW 50021, 'That status change is not allowed for this reservation.', 1;

        UPDATE dbo.tblReservations
        SET Status = @Status
        WHERE ReservationID = @ReservationID;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO
