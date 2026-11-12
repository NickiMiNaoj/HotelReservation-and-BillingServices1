CREATE TABLE [dbo].[tblReservations]
(
    [ReservationID]     INT             IDENTITY (1, 1) NOT NULL,
    [GuestID]           INT             NOT NULL,
    [RoomID]            INT             NOT NULL,
    [CheckInDate]       DATE            NOT NULL,
    [CheckOutDate]      DATE            NOT NULL,
    [NumAdults]         INT             NOT NULL CONSTRAINT [DF_tblReservations_NumAdults] DEFAULT (1),
    [NumChildren]       INT             NOT NULL CONSTRAINT [DF_tblReservations_NumChildren] DEFAULT (0),
    [SpecialRequests]   NVARCHAR (500)  NULL,
    [RoomRate]          DECIMAL (10, 2) NOT NULL,   -- room rate per night at the time of booking
    [AdditionalCharges] DECIMAL (10, 2) NOT NULL CONSTRAINT [DF_tblReservations_AdditionalCharges] DEFAULT (0),
    [Discount]          DECIMAL (10, 2) NOT NULL CONSTRAINT [DF_tblReservations_Discount] DEFAULT (0),
    [TotalNights]       AS (DATEDIFF(DAY, [CheckInDate], [CheckOutDate])) PERSISTED,
    [TotalAmount]       AS (DATEDIFF(DAY, [CheckInDate], [CheckOutDate]) * [RoomRate] + [AdditionalCharges] - [Discount]) PERSISTED,
    [Status]            NVARCHAR (20)   NOT NULL CONSTRAINT [DF_tblReservations_Status] DEFAULT ('Pending'),
    [Remarks]           NVARCHAR (500)  NULL,
    [ActualCheckIn]     DATETIME2 (0)   NULL,
    [ActualCheckOut]    DATETIME2 (0)   NULL,
    [CreatedAt]         DATETIME2 (0)   NOT NULL CONSTRAINT [DF_tblReservations_CreatedAt] DEFAULT (SYSDATETIME()),

    -- Soft delete: the row is never removed, only flagged
    [IsDeleted]         BIT             NOT NULL CONSTRAINT [DF_tblReservations_IsDeleted] DEFAULT (0),
    [DeletedAt]         DATETIME2 (0)   NULL,
    [DeletedBy]         INT             NULL,

    CONSTRAINT [PK_tblReservations] PRIMARY KEY CLUSTERED ([ReservationID] ASC),
    CONSTRAINT [FK_tblReservations_tblGuests] FOREIGN KEY ([GuestID]) REFERENCES [dbo].[tblGuests] ([GuestID]),
    CONSTRAINT [FK_tblReservations_tblRooms] FOREIGN KEY ([RoomID]) REFERENCES [dbo].[tblRooms] ([RoomID]),
    CONSTRAINT [FK_tblReservations_DeletedBy] FOREIGN KEY ([DeletedBy]) REFERENCES [dbo].[tblEmployees] ([EmployeeID]),
    CONSTRAINT [CK_tblReservations_Dates] CHECK ([CheckOutDate] > [CheckInDate]),
    CONSTRAINT [CK_tblReservations_NumAdults] CHECK ([NumAdults] >= 1),
    CONSTRAINT [CK_tblReservations_NumChildren] CHECK ([NumChildren] >= 0),
    CONSTRAINT [CK_tblReservations_Charges] CHECK ([AdditionalCharges] >= 0 AND [Discount] >= 0),
    CONSTRAINT [CK_tblReservations_Status] CHECK ([Status] IN ('Pending', 'Confirmed', 'Cancelled', 'CheckedIn', 'CheckedOut'))
);