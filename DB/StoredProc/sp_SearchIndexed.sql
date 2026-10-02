
CREATE PROCEDURE sp_SearchRoomsByNumber
	@RoomNumber NVARCHAR(20)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT RoomID, RoomNumber, RoomType, NightlyRate, Capacity, RoomStatus, Description
	FROM tblRooms
	WHERE RoomNumber LIKE @RoomNumber + '%'
	ORDER BY RoomNumber;
END
GO


CREATE PROCEDURE sp_SearchRoomsByType
	@RoomType NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT RoomID, RoomNumber, RoomType, NightlyRate, Capacity, RoomStatus, Description
	FROM tblRooms
	WHERE RoomType LIKE @RoomType + '%'
	ORDER BY RoomType, RoomNumber;
END
GO


CREATE PROCEDURE sp_SearchRoomsByStatus
	@RoomStatus NVARCHAR(30)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT RoomID, RoomNumber, RoomType, NightlyRate, Capacity, RoomStatus, Description
	FROM tblRooms
	WHERE RoomStatus LIKE @RoomStatus + '%'
	ORDER BY RoomStatus, RoomNumber;
END
GO


CREATE PROCEDURE sp_SearchUsersByUsername
	@Username NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT UserID, Username, FullName, Role
	FROM tblUsers
	WHERE Username LIKE @Username + '%'
	ORDER BY Username;
END
GO


CREATE PROCEDURE sp_SearchUsersByFullName
	@FullName NVARCHAR(100)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT UserID, Username, FullName, Role
	FROM tblUsers
	WHERE FullName LIKE @FullName + '%'
	ORDER BY FullName;
END
GO


CREATE PROCEDURE sp_SearchUsersByRole
	@Role NVARCHAR(20)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT UserID, Username, FullName, Role
	FROM tblUsers
	WHERE Role LIKE @Role + '%'
	ORDER BY Role, FullName;
END
GO
