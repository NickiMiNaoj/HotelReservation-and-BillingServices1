-- View to quickly query available rooms
CREATE VIEW vw_AvailableRooms AS
SELECT 
    RoomID,
    RoomNumber,
    RoomType,
    NightlyRate,
    Capacity,
    Description
FROM tblRooms
WHERE RoomStatus = 'Available';