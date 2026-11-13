CREATE TABLE [dbo].[tblPayments]
(
    [PaymentID]      INT             IDENTITY (1, 1) NOT NULL,
    [InvoiceID]      INT             NOT NULL,
    [PaymentMethod]  NVARCHAR (20)   NOT NULL,
    [AmountTendered] DECIMAL (10, 2) NOT NULL,   -- what the guest handed over ("Amount Paid" on the form)
    [AmountApplied]  DECIMAL (10, 2) NOT NULL,   -- the part that counts toward the invoice
    [ChangeGiven]    AS ([AmountTendered] - [AmountApplied]) PERSISTED,   -- "Change" on the form
    [PaidAt]         DATETIME2 (0)   NOT NULL CONSTRAINT [DF_tblPayments_PaidAt] DEFAULT (SYSDATETIME()),
    [ProcessedBy]    INT             NOT NULL,

    CONSTRAINT [PK_tblPayments] PRIMARY KEY CLUSTERED ([PaymentID] ASC),
    CONSTRAINT [FK_tblPayments_tblInvoices] FOREIGN KEY ([InvoiceID]) REFERENCES [dbo].[tblInvoices] ([InvoiceID]),
    CONSTRAINT [FK_tblPayments_tblEmployees] FOREIGN KEY ([ProcessedBy]) REFERENCES [dbo].[tblEmployees] ([EmployeeID]),
    CONSTRAINT [CK_tblPayments_Method] CHECK ([PaymentMethod] IN ('Cash', 'Credit Card', 'Debit Card', 'GCash')),
    CONSTRAINT [CK_tblPayments_Amounts] CHECK ([AmountApplied] > 0 AND [AmountTendered] >= [AmountApplied])
);