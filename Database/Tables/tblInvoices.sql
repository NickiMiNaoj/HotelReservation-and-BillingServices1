CREATE TABLE [dbo].[tblInvoices]
(
    [InvoiceID]           INT             IDENTITY (1, 1) NOT NULL,
    -- "Invoice Number" on the Billing form, for example INV-000012
    [InvoiceNumber]       AS (N'INV-' + RIGHT(N'000000' + CAST([InvoiceID] AS NVARCHAR (10)), 6)) PERSISTED,
    [ReservationID]       INT             NOT NULL,
    [RoomCharges]         DECIMAL (10, 2) NOT NULL,   -- the reservation's total amount when billed
    [FoodBeverageCharges] DECIMAL (10, 2) NOT NULL CONSTRAINT [DF_tblInvoices_FoodBeverage] DEFAULT (0),
    [OtherServiceCharges] DECIMAL (10, 2) NOT NULL CONSTRAINT [DF_tblInvoices_OtherServices] DEFAULT (0),
    [Discount]            DECIMAL (10, 2) NOT NULL CONSTRAINT [DF_tblInvoices_Discount] DEFAULT (0),
    [TaxRate]             DECIMAL (5, 4)  NOT NULL CONSTRAINT [DF_tblInvoices_TaxRate] DEFAULT (0.12),
    [Subtotal]            AS ([RoomCharges] + [FoodBeverageCharges] + [OtherServiceCharges]) PERSISTED,
    [TaxAmount]           AS (ROUND(([RoomCharges] + [FoodBeverageCharges] + [OtherServiceCharges] - [Discount]) * [TaxRate], 2)) PERSISTED,
    [TotalAmountDue]      AS (ROUND(([RoomCharges] + [FoodBeverageCharges] + [OtherServiceCharges] - [Discount]) * (1 + [TaxRate]), 2)) PERSISTED,
    [CreatedAt]           DATETIME2 (0)   NOT NULL CONSTRAINT [DF_tblInvoices_CreatedAt] DEFAULT (SYSDATETIME()),

    CONSTRAINT [PK_tblInvoices] PRIMARY KEY CLUSTERED ([InvoiceID] ASC),
    CONSTRAINT [UQ_tblInvoices_ReservationID] UNIQUE ([ReservationID]),   -- one invoice per reservation
    CONSTRAINT [FK_tblInvoices_tblReservations] FOREIGN KEY ([ReservationID]) REFERENCES [dbo].[tblReservations] ([ReservationID]),
    CONSTRAINT [CK_tblInvoices_Charges] CHECK ([RoomCharges] >= 0 AND [FoodBeverageCharges] >= 0 AND [OtherServiceCharges] >= 0 AND [Discount] >= 0),
    CONSTRAINT [CK_tblInvoices_Discount] CHECK ([Discount] <= [RoomCharges] + [FoodBeverageCharges] + [OtherServiceCharges]),
    CONSTRAINT [CK_tblInvoices_TaxRate] CHECK ([TaxRate] BETWEEN 0 AND 1)
);