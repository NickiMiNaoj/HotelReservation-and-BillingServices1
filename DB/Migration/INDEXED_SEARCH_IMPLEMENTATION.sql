
SELECT * FROM tblRooms WHERE RoomNumber LIKE 'A%' ORDER BY RoomNumber;

SELECT * FROM tblRooms WHERE RoomStatus LIKE 'Avail%' ORDER BY RoomNumber;

SELECT * FROM tblRooms 
WHERE RoomStatus = 'Available' AND RoomNumber LIKE 'D%'
ORDER BY RoomNumber;

SELECT * FROM tblUsers WHERE FullName LIKE 'John%' ORDER BY FullName;

SELECT * FROM tblUsers 
WHERE Role = 'Admin' AND FullName LIKE 'J%'
ORDER BY FullName;

