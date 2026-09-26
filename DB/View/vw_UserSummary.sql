-- View to safely list user details without returning passwords
CREATE VIEW vw_UserSummary AS
SELECT 
    UserID,
    Username,
    FullName,
    Role
FROM tblUsers;