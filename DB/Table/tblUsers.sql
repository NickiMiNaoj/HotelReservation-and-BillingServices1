-- Create tblUsers Table
CREATE TABLE tblUsers (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(250) NOT NULL, -- Stored as text/hash
    FullName NVARCHAR(100) NOT NULL,
    Role NVARCHAR(20) NOT NULL -- e.g., 'Admin', 'Front Desk'
);