-- Create tblRooms Table
CREATE TABLE tblRooms (
    RoomID INT IDENTITY(1,1) PRIMARY KEY,
    RoomNumber NVARCHAR(20) NOT NULL UNIQUE, -- Prevents duplicate room numbers
    RoomType NVARCHAR(50) NOT NULL,          -- e.g., 'Single', 'Double', 'Suite'
    NightlyRate DECIMAL(10,2) NOT NULL CHECK (NightlyRate >= 0),
    Capacity INT NOT NULL CHECK (Capacity > 0),
    RoomStatus NVARCHAR(30) NOT NULL DEFAULT 'Available', -- e.g., 'Available', 'Occupied', 'Maintenance'
    Description NVARCHAR(250) NULL
);