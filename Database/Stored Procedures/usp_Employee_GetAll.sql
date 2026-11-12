CREATE PROCEDURE [dbo].[usp_Employee_GetAll]
AS
BEGIN
    SET NOCOUNT ON;

    -- Password is intentionally not returned to the Employee List grid
    SELECT [EmployeeID], [FullName], [Username], [Role], [AccountStatus]
    FROM   [dbo].[tblEmployees]
    ORDER BY [FullName];
END