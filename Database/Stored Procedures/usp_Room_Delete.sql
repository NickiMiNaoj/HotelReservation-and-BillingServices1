CREATE PROCEDURE [dbo].[usp_Room_Delete]
    @RoomID INT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM [dbo].[tblRooms] WHERE [RoomID] = @RoomID)
    BEGIN
        RAISERROR('Room not found.', 16, 1);
        RETURN;
    END

    -- Once tblReservations exists with a foreign key to this table,
    -- the database will refuse to delete a room that already has reservations.
    DELETE FROM [dbo].[tblRooms]
    WHERE  [RoomID] = @RoomID;
END