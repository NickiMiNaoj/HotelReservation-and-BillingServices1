CREATE PROCEDURE [dbo].[usp_Employee_Login]
    @Username NVARCHAR (50),
    @Password NVARCHAR (50),
    @Role     NVARCHAR (20)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT [EmployeeID], [FullName], [Username], [Role]
    FROM   [dbo].[tblEmployees]
    WHERE  [Username]      = @Username
      AND  [Password]      = @Password
      AND  [Role]          = @Role
      AND  [AccountStatus] = 'Active';
END