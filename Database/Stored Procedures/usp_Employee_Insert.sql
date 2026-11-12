CREATE PROCEDURE [dbo].[usp_Employee_Insert]
    @FullName      NVARCHAR (100),
    @Username      NVARCHAR (50),
    @Password      NVARCHAR (50),
    @Role          NVARCHAR (20),
    @AccountStatus NVARCHAR (10) = 'Active'
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM [dbo].[tblEmployees] WHERE [Username] = @Username)
    BEGIN
        RAISERROR('Username already exists.', 16, 1);
        RETURN;
    END

    INSERT INTO [dbo].[tblEmployees] ([FullName], [Username], [Password], [Role], [AccountStatus])
    VALUES (@FullName, @Username, @Password, @Role, @AccountStatus);

    -- Returns the new auto-generated Employee ID
    SELECT SCOPE_IDENTITY() AS [EmployeeID];
END