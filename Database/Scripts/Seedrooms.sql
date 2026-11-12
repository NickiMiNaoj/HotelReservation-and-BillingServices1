/*
  Seed data for dbo.tblRooms: 15 sample rooms on 3 floors (matches the room grid).
  Safe to run on every publish: only inserts a room number that does not exist yet.
  Room 104 (Needs Housekeeping) and 202 (Under Maintenance) are there so the grid shows those colors.
*/
MERGE [dbo].[tblRooms] AS target
USING (VALUES
    (N'101', 1, N'Standard',        1500.00, 2, N'Queen',  N'Available',          N'Standard room, city view.',      N'Wi-Fi, Air Conditioning, Television'),
    (N'102', 1, N'Standard',        1500.00, 2, N'Twin',   N'Available',          N'Standard twin room.',            N'Wi-Fi, Air Conditioning, Television'),
    (N'103', 1, N'Deluxe',          2500.00, 3, N'Queen',  N'Available',          N'Deluxe room with sitting area.', N'Wi-Fi, Air Conditioning, Television, Mini Bar'),
    (N'104', 1, N'Deluxe',          2500.00, 3, N'King',   N'Needs Housekeeping', N'Deluxe king room.',              N'Wi-Fi, Air Conditioning, Television, Mini Bar'),
    (N'105', 1, N'Junior Suite',    3500.00, 3, N'King',   N'Available',          N'Junior suite with balcony.',     N'Wi-Fi, Air Conditioning, Television, Mini Bar, Balcony'),
    (N'201', 2, N'Standard',        1500.00, 2, N'Queen',  N'Available',          N'Standard room, garden view.',    N'Wi-Fi, Air Conditioning, Television'),
    (N'202', 2, N'Standard',        1500.00, 2, N'Single', N'Under Maintenance',  N'Standard single room.',          N'Wi-Fi, Air Conditioning, Television'),
    (N'203', 2, N'Deluxe',          2500.00, 3, N'Queen',  N'Available',          N'Deluxe room.',                   N'Wi-Fi, Air Conditioning, Television, Mini Bar'),
    (N'204', 2, N'Junior Suite',    3500.00, 3, N'King',   N'Available',          N'Junior suite.',                  N'Wi-Fi, Air Conditioning, Television, Mini Bar, Balcony'),
    (N'205', 2, N'Executive Suite', 5000.00, 4, N'King',   N'Available',          N'Executive suite with lounge.',   N'Wi-Fi, Air Conditioning, Television, Mini Bar, Safe, Balcony, Coffee Maker'),
    (N'301', 3, N'Deluxe',          2500.00, 3, N'Queen',  N'Available',          N'Deluxe room, high floor.',       N'Wi-Fi, Air Conditioning, Television, Mini Bar'),
    (N'302', 3, N'Junior Suite',    3500.00, 3, N'King',   N'Available',          N'Junior suite, high floor.',      N'Wi-Fi, Air Conditioning, Television, Mini Bar, Balcony'),
    (N'303', 3, N'Executive Suite', 5000.00, 4, N'King',   N'Available',          N'Executive suite.',               N'Wi-Fi, Air Conditioning, Television, Mini Bar, Safe, Bathtub, Coffee Maker'),
    (N'304', 3, N'Executive Suite', 5000.00, 4, N'Queen',  N'Available',          N'Executive suite, two beds.',     N'Wi-Fi, Air Conditioning, Television, Mini Bar, Safe, Bathtub, Coffee Maker'),
    (N'305', 3, N'Presidential Suite', 8000.00, 5, N'King', N'Available',         N'Top-floor presidential suite.',  N'Wi-Fi, Air Conditioning, Television, Mini Bar, Safe, Balcony, Bathtub, Coffee Maker')
) AS source ([RoomNumber], [Floor], [RoomType], [NightlyRate], [MaxCapacity], [BedType], [Status], [Description], [Amenities])
ON target.[RoomNumber] = source.[RoomNumber]
WHEN NOT MATCHED BY TARGET THEN
    INSERT ([RoomNumber], [Floor], [RoomType], [NightlyRate], [MaxCapacity], [BedType], [Status], [Description], [Amenities])
    VALUES (source.[RoomNumber], source.[Floor], source.[RoomType], source.[NightlyRate], source.[MaxCapacity], source.[BedType], source.[Status], source.[Description], source.[Amenities]);