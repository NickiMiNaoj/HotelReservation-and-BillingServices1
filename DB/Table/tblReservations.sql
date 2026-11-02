CREATE TABLE dbo.tblReservations (
    ReservationID INT IDENTITY(1,1) PRIMARY KEY,
    GuestID INT NOT NULL,
    ArrivalDate DATETIME NOT NULL,
    DepartureDate DATETIME NOT NULL,
    Status NVARCHAR(50) NOT NULL DEFAULT 'Pending',
    KeyCardNumber NVARCHAR(50) NULL,
    Remarks NVARCHAR(MAX) NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME NULL,
    CONSTRAINT FK_Reservations_Guests FOREIGN KEY (GuestID) REFERENCES dbo.tblGuests(GuestID)
);
GO