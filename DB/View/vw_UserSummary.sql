CREATE VIEW vw_UserSummary AS
SELECT 
    UserID,
    Username,
    FullName,
    Role
FROM tblUsers;