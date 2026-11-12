CREATE PROCEDURE [dbo].[usp_Room_Insert]
    @RoomNumber  NVARCHAR (10),
    @Floor       INT,
    @RoomType    NVARCHAR (30),
    @NightlyRate DECIMAL (10, 2),
    @MaxCapacity INT,
    @BedType     NVARCHAR (20),
    @Status      NVARCHAR (30) = 'Available',
    @Description NVARCHAR (500) = NULL,
    @Amenities   NVARCHAR (500) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM [dbo].[tblRooms] WHERE [RoomNumber] = @RoomNumber)
    BEGIN
        RAISERROR('Room number already exists.', 16, 1);
        RETURN;
    END

    INSERT INTO [dbo].[tblRooms]
        ([RoomNumber], [Floor], [RoomType], [NightlyRate], [MaxCapacity], [BedType], [Status], [Description], [Amenities])
    VALUES
        (@RoomNumber, @Floor, @RoomType, @NightlyRate, @MaxCapacity, @BedType, @Status, @Description, @Amenities);

    -- Returns the new auto-generated Room ID
    SELECT SCOPE_IDENTITY() AS [RoomID];
END