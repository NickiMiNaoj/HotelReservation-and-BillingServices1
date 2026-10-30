-- Create tblReservationRooms Junction Table
-- Maps one ReservationID to many RoomIDs. RateAtBooking snapshots tblRooms.NightlyRate
-- so a saved TotalAmount can always be explained, even if the room rate changes later.
CREATE TABLE dbo.tblReservationRooms (
    ReservationID INT NOT NULL,
    RoomID        INT NOT NULL,
    RateAtBooking DECIMAL(10,2) NOT NULL,

    CONSTRAINT PK_tblReservationRooms PRIMARY KEY (ReservationID, RoomID),  -- a room can appear once per reservation
    CONSTRAINT FK_tblReservationRooms_tblReservations FOREIGN KEY (ReservationID)
        REFERENCES dbo.tblReservations (ReservationID) ON DELETE CASCADE,
    CONSTRAINT FK_tblReservationRooms_tblRooms FOREIGN KEY (RoomID)
        REFERENCES dbo.tblRooms (RoomID),
    CONSTRAINT CK_tblReservationRooms_Rate CHECK (RateAtBooking >= 0)
);

-- "Which reservations hold this room?" (the availability lookup)
CREATE INDEX idx_ReservationRooms_RoomID ON dbo.tblReservationRooms (RoomID);
