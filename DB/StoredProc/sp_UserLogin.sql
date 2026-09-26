CREATE PROCEDURE sp_UserLogin
    @Username NVARCHAR(50),
    @Password NVARCHAR(250)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT UserID, Username, FullName, Role
    FROM tblUsers
    WHERE Username = @Username AND Password = @Password;
END