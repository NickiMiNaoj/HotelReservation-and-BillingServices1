CREATE PROCEDURE [dbo].[usp_Employee_Update]
    @EmployeeID    INT,
    @FullName      NVARCHAR (100),
    @Username      NVARCHAR (50),
    @Role          NVARCHAR (20),
    @AccountStatus NVARCHAR (10),
    @Password      NVARCHAR (50) = NULL   -- leave NULL to keep the current password
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM [dbo].[tblEmployees] WHERE [EmployeeID] = @EmployeeID)
    BEGIN
        RAISERROR('Employee not found.', 16, 1);
        RETURN;
    END

    IF EXISTS (SELECT 1 FROM [dbo].[tblEmployees]
               WHERE [Username] = @Username AND [EmployeeID] <> @EmployeeID)
    BEGIN
        RAISERROR('Username already exists.', 16, 1);
        RETURN;
    END

    UPDATE [dbo].[tblEmployees]
    SET    [FullName]      = @FullName,
           [Username]      = @Username,
           [Role]          = @Role,
           [AccountStatus] = @AccountStatus,
           [Password]      = COALESCE(@Password, [Password])
    WHERE  [EmployeeID] = @EmployeeID;
END