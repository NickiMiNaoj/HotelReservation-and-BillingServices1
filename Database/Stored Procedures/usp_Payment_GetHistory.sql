CREATE PROCEDURE [dbo].[usp_Payment_GetHistory]
    @EmployeeID    INT,
    @ReservationID INT = NULL      -- NULL = every payment, otherwise only that reservation
AS
BEGIN
    SET NOCOUNT ON;

    -- Same rule as the reservation list: payments of a soft-deleted reservation are only visible to an Admin
    DECLARE @IsAdmin BIT = CASE WHEN EXISTS (SELECT 1 FROM [dbo].[tblEmployees]
                                             WHERE [EmployeeID] = @EmployeeID
                                               AND [Role] = 'Admin'
                                               AND [AccountStatus] = 'Active')
                                THEN 1 ELSE 0 END;

    SELECT p.[PaymentID], i.[InvoiceNumber], i.[ReservationID],
           g.[FirstName] + N' ' + g.[LastName] AS [GuestName],
           rm.[RoomNumber], p.[PaymentMethod],
           p.[AmountTendered], p.[AmountApplied], p.[ChangeGiven], p.[PaidAt],
           e.[FullName] AS [ProcessedByName]
    FROM   [dbo].[tblPayments] p
           INNER JOIN [dbo].[tblInvoices]     i  ON i.[InvoiceID]     = p.[InvoiceID]
           INNER JOIN [dbo].[tblReservations] r  ON r.[ReservationID] = i.[ReservationID]
           INNER JOIN [dbo].[tblGuests]       g  ON g.[GuestID]       = r.[GuestID]
           INNER JOIN [dbo].[tblRooms]        rm ON rm.[RoomID]       = r.[RoomID]
           LEFT  JOIN [dbo].[tblEmployees]    e  ON e.[EmployeeID]    = p.[ProcessedBy]
    WHERE  (@ReservationID IS NULL OR i.[ReservationID] = @ReservationID)
      AND  (@IsAdmin = 1 OR r.[IsDeleted] = 0)
    ORDER BY p.[PaidAt] DESC, p.[PaymentID] DESC;
END