CREATE PROCEDURE [dbo].[usp_Employee_Deactivate]
    @EmployeeID INT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM [dbo].[tblEmployees] WHERE [EmployeeID] = @EmployeeID)
    BEGIN
        RAISERROR('Employee not found.', 16, 1);
        RETURN;
    END

    -- Safety: never deactivate the last active Admin
    IF EXISTS (SELECT 1 FROM [dbo].[tblEmployees]
               WHERE [EmployeeID] = @EmployeeID AND [Role] = 'Admin' AND [AccountStatus] = 'Active')
       AND (SELECT COUNT(*) FROM [dbo].[tblEmployees]
            WHERE [Role] = 'Admin' AND [AccountStatus] = 'Active') = 1
    BEGIN
        RAISERROR('Cannot deactivate the last active Admin account.', 16, 1);
        RETURN;
    END

    UPDATE [dbo].[tblEmployees]
    SET    [AccountStatus] = 'Inactive'
    WHERE  [EmployeeID] = @EmployeeID;
END