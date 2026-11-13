CREATE PROCEDURE [dbo].[usp_Billing_ProcessPayment]
    @ReservationID       INT,
    @FoodBeverageCharges DECIMAL (10, 2) = 0,
    @OtherServiceCharges DECIMAL (10, 2) = 0,
    @Discount            DECIMAL (10, 2) = 0,
    @PaymentMethod       NVARCHAR (20),
    @AmountTendered      DECIMAL (10, 2),
    @ProcessedBy         INT,                       -- EmployeeID of the logged-in user
    @TaxRate             DECIMAL (5, 4) = 0.12      -- 12% VAT, only used when the invoice is first created
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    IF NOT EXISTS (SELECT 1 FROM [dbo].[tblEmployees]
                   WHERE [EmployeeID] = @ProcessedBy AND [AccountStatus] = 'Active')
    BEGIN
        RAISERROR('Employee not found.', 16, 1);
        RETURN;
    END

    DECLARE @RoomCharges DECIMAL (10, 2), @ResStatus NVARCHAR (20);

    SELECT @RoomCharges = [TotalAmount], @ResStatus = [Status]
    FROM   [dbo].[tblReservations]
    WHERE  [ReservationID] = @ReservationID AND [IsDeleted] = 0;

    IF @RoomCharges IS NULL
    BEGIN
        RAISERROR('Reservation not found.', 16, 1);
        RETURN;
    END

    IF @ResStatus = 'Cancelled'
    BEGIN
        RAISERROR('A cancelled reservation cannot be billed.', 16, 1);
        RETURN;
    END

    IF @AmountTendered <= 0
    BEGIN
        RAISERROR('Amount paid must be greater than zero.', 16, 1);
        RETURN;
    END

    IF @FoodBeverageCharges < 0 OR @OtherServiceCharges < 0 OR @Discount < 0
    BEGIN
        RAISERROR('Charges and discount cannot be negative.', 16, 1);
        RETURN;
    END

    IF @Discount > @RoomCharges + @FoodBeverageCharges + @OtherServiceCharges
    BEGIN
        RAISERROR('Discount cannot be more than the total charges.', 16, 1);
        RETURN;
    END

    BEGIN TRANSACTION;

    -- Create the invoice on the first payment, update its charges on later ones
    DECLARE @InvoiceID INT;

    SELECT @InvoiceID = [InvoiceID]
    FROM   [dbo].[tblInvoices] WITH (UPDLOCK, HOLDLOCK)
    WHERE  [ReservationID] = @ReservationID;

    IF @InvoiceID IS NULL
    BEGIN
        INSERT INTO [dbo].[tblInvoices]
            ([ReservationID], [RoomCharges], [FoodBeverageCharges], [OtherServiceCharges], [Discount], [TaxRate])
        VALUES
            (@ReservationID, @RoomCharges, @FoodBeverageCharges, @OtherServiceCharges, @Discount, @TaxRate);

        SET @InvoiceID = SCOPE_IDENTITY();
    END
    ELSE
    BEGIN
        UPDATE [dbo].[tblInvoices]
        SET    [RoomCharges]         = @RoomCharges,
               [FoodBeverageCharges] = @FoodBeverageCharges,
               [OtherServiceCharges] = @OtherServiceCharges,
               [Discount]            = @Discount
        WHERE  [InvoiceID] = @InvoiceID;
    END

    DECLARE @TotalDue DECIMAL (10, 2), @Paid DECIMAL (10, 2), @Balance DECIMAL (10, 2), @Applied DECIMAL (10, 2);

    SELECT @TotalDue = [TotalAmountDue] FROM [dbo].[tblInvoices] WHERE [InvoiceID] = @InvoiceID;
    SELECT @Paid = COALESCE(SUM([AmountApplied]), 0) FROM [dbo].[tblPayments] WHERE [InvoiceID] = @InvoiceID;
    SET @Balance = @TotalDue - @Paid;

    IF @Balance <= 0
    BEGIN
        ROLLBACK TRANSACTION;
        RAISERROR('This invoice is already fully paid.', 16, 1);
        RETURN;
    END

    -- Only cash can be handed over in excess (the extra is given back as change)
    IF @PaymentMethod <> 'Cash' AND @AmountTendered > @Balance
    BEGIN
        ROLLBACK TRANSACTION;
        RAISERROR('Only cash payments can be more than the balance due.', 16, 1);
        RETURN;
    END

    SET @Applied = CASE WHEN @AmountTendered > @Balance THEN @Balance ELSE @AmountTendered END;

    INSERT INTO [dbo].[tblPayments] ([InvoiceID], [PaymentMethod], [AmountTendered], [AmountApplied], [ProcessedBy])
    VALUES (@InvoiceID, @PaymentMethod, @AmountTendered, @Applied, @ProcessedBy);

    COMMIT TRANSACTION;

    -- The change to give back to the guest
    SELECT @AmountTendered - @Applied AS [ChangeGiven];
END