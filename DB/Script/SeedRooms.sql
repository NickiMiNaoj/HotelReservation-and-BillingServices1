-- Seed Default Rooms
IF NOT EXISTS (SELECT 1 FROM tblRooms WHERE RoomNumber = '101')
BEGIN
    INSERT INTO tblRooms (RoomNumber, RoomType, NightlyRate, Capacity, RoomStatus, Description)
    VALUES ('101', 'Single', 50.00, 1, 'Available', 'Standard single bed room with street view.');
END

IF NOT EXISTS (SELECT 1 FROM tblRooms WHERE RoomNumber = '102')
BEGIN
    INSERT INTO tblRooms (RoomNumber, RoomType, NightlyRate, Capacity, RoomStatus, Description)
    VALUES ('102', 'Double', 85.00, 2, 'Available', 'Double bed room with balcony and aircon.');
END

IF NOT EXISTS (SELECT 1 FROM tblRooms WHERE RoomNumber = '201')
BEGIN
    INSERT INTO tblRooms (RoomNumber, RoomType, NightlyRate, Capacity, RoomStatus, Description)
    VALUES ('201', 'Suite', 150.00, 4, 'Available', 'Luxury family suite with mini-kitchen.');
END