IF NOT EXISTS (SELECT 1 FROM tblUsers WHERE Username = 'admin')
BEGIN
    INSERT INTO tblUsers (Username, Password, FullName, Role)
    VALUES ('admin', 'AdminPass123', 'System Administrator', 'Admin');
END

IF NOT EXISTS (SELECT 1 FROM tblUsers WHERE Username = 'frontdesk')
BEGIN
    INSERT INTO tblUsers (Username, Password, FullName, Role)
    VALUES ('frontdesk', 'DeskPass123', 'Front Desk Staff', 'Front Desk'); 
END