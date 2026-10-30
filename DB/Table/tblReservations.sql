-- Create tblReservations Table
-- One row per booking. Rooms are mapped through tblReservationRooms (a booking can hold many rooms).
CREATE TABLE dbo.tblReservations (
    ReservationID INT IDENTITY(1,1) NOT NULL,
    GuestID       INT NOT NULL,
    ArrivalDate   DATETIME NOT NULL,
    DepartureDate DATETIME NOT NULL,
    AdultCount    INT NOT NULL,
    KidCount      INT NOT NULL CONSTRAINT DF_tblReservations_KidCount    DEFAULT (0),
    InfantCount   INT NOT NULL CONSTRAINT DF_tblReservations_InfantCount DEFAULT (0),
    TotalAmount   DECIMAL(12,2) NOT NULL CONSTRAINT DF_tblReservations_TotalAmount DEFAULT (0),
    Status        NVARCHAR(20) NOT NULL CONSTRAINT DF_tblReservations_Status DEFAULT ('Pending'),
    CreatedAt     DATETIME NOT NULL CONSTRAINT DF_tblReservations_CreatedAt DEFAULT (GETDATE()),

    CONSTRAINT PK_tblReservations PRIMARY KEY (ReservationID),
    CONSTRAINT FK_tblReservations_tblGuests FOREIGN KEY (GuestID) REFERENCES dbo.tblGuests (GuestID),
    CONSTRAINT CK_tblReservations_Dates  CHECK (DepartureDate > ArrivalDate),
    CONSTRAINT CK_tblReservations_Counts CHECK (AdultCount >= 0 AND KidCount >= 0 AND InfantCount >= 0),
    CONSTRAINT CK_tblReservations_Amount CHECK (TotalAmount >= 0),
    CONSTRAINT CK_tblReservations_Status CHECK (Status IN ('Pending', 'Confirmed', 'Cancelled', 'Checked-In', 'Completed'))
);

-- Supports the overlap test in sp_GetRoomAvailability / sp_CreateReservation
CREATE INDEX idx_Reservations_Status_Dates ON dbo.tblReservations (Status, ArrivalDate, DepartureDate);

CREATE INDEX idx_Reservations_GuestID ON dbo.tblReservations (GuestID);
