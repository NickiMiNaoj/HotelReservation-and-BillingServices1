CREATE PROCEDURE [dbo].[usp_Room_Update]
    @RoomID      INT,
    @RoomNumber  NVARCHAR (10),
    @Floor       INT,
    @RoomType    NVARCHAR (30),
    @NightlyRate DECIMAL (10, 2),
    @MaxCapacity INT,
    @BedType     NVARCHAR (20),
    @Status      NVARCHAR (30),
    @Description NVARCHAR (500) = NULL,
    @Amenities   NVARCHAR (500) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM [dbo].[tblRooms] WHERE [RoomID] = @RoomID)
    BEGIN
        RAISERROR('Room not found.', 16, 1);
        RETURN;
    END

    IF EXISTS (SELECT 1 FROM [dbo].[tblRooms]
               WHERE [RoomNumber] = @RoomNumber AND [RoomID] <> @RoomID)
    BEGIN
        RAISERROR('Room number already exists.', 16, 1);
        RETURN;
    END

    UPDATE [dbo].[tblRooms]
    SET    [RoomNumber]  = @RoomNumber,
           [Floor]       = @Floor,
           [RoomType]    = @RoomType,
           [NightlyRate] = @NightlyRate,
           [MaxCapacity] = @MaxCapacity,
           [BedType]     = @BedType,
           [Status]      = @Status,
           [Description] = @Description,
           [Amenities]   = @Amenities
    WHERE  [RoomID] = @RoomID;
END