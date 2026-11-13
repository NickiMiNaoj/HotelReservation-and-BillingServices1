CREATE PROCEDURE [dbo].[usp_Billing_GetByReservation]
    @ReservationID INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @DefaultTaxRate DECIMAL (5, 4) = 0.12;   -- used for the preview when no invoice exists yet

    -- One row for the Billing form. If the reservation has no invoice yet,
    -- the row shows a preview (extra charges 0, tax at the default rate).
    -- A deleted reservation returns no row.
    SELECT r.[ReservationID],
           g.[FirstName] + N' ' + g.[LastName]                          AS [GuestName],
           rm.[RoomNumber],
           COALESCE(i.[RoomCharges], r.[TotalAmount])                   AS [RoomCharges],
           COALESCE(i.[FoodBeverageCharges], 0)                         AS [FoodBeverageCharges],
           COALESCE(i.[OtherServiceCharges], 0)                         AS [OtherServiceCharges],
           COALESCE(i.[Discount], 0)                                    AS [Discount],
           COALESCE(i.[TaxRate], @DefaultTaxRate)                       AS [TaxRate],
           COALESCE(i.[TaxAmount], ROUND(r.[TotalAmount] * @DefaultTaxRate, 2))        AS [TaxAmount],
           x.[Due]                                                      AS [TotalAmountDue],
           x.[PaidAmount]                                               AS [AmountPaid],
           x.[Due] - x.[PaidAmount]                                     AS [Balance],
           CASE WHEN x.[PaidAmount] >= x.[Due] AND x.[Due] > 0 THEN N'Paid'
                WHEN x.[PaidAmount] > 0                         THEN N'Partially Paid'
                ELSE N'Unpaid' END                                      AS [PaymentStatus],
           i.[InvoiceID],
           i.[InvoiceNumber]
    FROM   [dbo].[tblReservations] r
           INNER JOIN [dbo].[tblGuests] g  ON g.[GuestID] = r.[GuestID]
           INNER JOIN [dbo].[tblRooms]  rm ON rm.[RoomID] = r.[RoomID]
           LEFT  JOIN [dbo].[tblInvoices] i ON i.[ReservationID] = r.[ReservationID]
           OUTER APPLY (SELECT SUM(p.[AmountApplied]) AS [Paid]
                        FROM   [dbo].[tblPayments] p
                        WHERE  p.[InvoiceID] = i.[InvoiceID]) pay
           CROSS APPLY (SELECT COALESCE(i.[TotalAmountDue], ROUND(r.[TotalAmount] * (1 + @DefaultTaxRate), 2)) AS [Due],
                               COALESCE(pay.[Paid], 0) AS [PaidAmount]) x
    WHERE  r.[ReservationID] = @ReservationID
      AND  r.[IsDeleted] = 0;
END