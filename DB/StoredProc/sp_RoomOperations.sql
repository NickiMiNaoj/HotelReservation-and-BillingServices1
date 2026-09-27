-- 1. Create: Add a new room
CREATE PROCEDURE sp_AddRoom
    @RoomNumber NVARCHAR(20),
    @RoomType NVARCHAR(50),
    @NightlyRate DECIMAL(10,2),
    @Capacity INT,
    @RoomStatus NVARCHAR(30),
    @Description NVARCHAR(250)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO tblRooms (RoomNumber, RoomType, NightlyRate, Capacity, RoomStatus, Description)
    VALUES (@RoomNumber, @RoomType, @NightlyRate, @Capacity, @RoomStatus, @Description);
END
GO

-- 2. Read: Get all rooms
CREATE PROCEDURE sp_GetAllRooms
AS
BEGIN
    SET NOCOUNT ON;

    SELECT RoomID, RoomNumber, RoomType, NightlyRate, Capacity, RoomStatus, Description
    FROM tblRooms;
END
GO

-- 3. Update: Modify an existing room's details
CREATE PROCEDURE sp_UpdateRoom
    @RoomID INT,
    @RoomNumber NVARCHAR(20),
    @RoomType NVARCHAR(50),
    @NightlyRate DECIMAL(10,2),
    @Capacity INT,
    @RoomStatus NVARCHAR(30),
    @Description NVARCHAR(250)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE tblRooms
    SET RoomNumber = @RoomNumber,
        RoomType = @RoomType,
        NightlyRate = @NightlyRate,
        Capacity = @Capacity,
        RoomStatus = @RoomStatus,
        Description = @Description
    WHERE RoomID = @RoomID;
END
GO

-- 4. Delete: Remove a room by ID
CREATE PROCEDURE sp_DeleteRoom
    @RoomID INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM tblRooms
    WHERE RoomID = @RoomID;
END
GO