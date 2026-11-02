CREATE TABLE dbo.tblReservationRooms (
    ReservationRoomID INT IDENTITY(1,1) PRIMARY KEY,
    ReservationID INT NOT NULL,
    RoomID INT NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_ReservationRooms_Reservations FOREIGN KEY (ReservationID) REFERENCES dbo.tblReservations(ReservationID),
    CONSTRAINT FK_ReservationRooms_Rooms FOREIGN KEY (RoomID) REFERENCES dbo.tblRooms(RoomID)
);
GO