CREATE PROCEDURE [dbo].[usp_Reservation_GetAll]
    @EmployeeID  INT,                     -- the logged-in user decides what they are allowed to see
    @Keyword     NVARCHAR (50) = NULL,    -- optional: guest name, room number, reservation ID or status
    @DeletedOnly BIT = 0                  -- Admin only: 1 = show only the deleted reservations
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @IsAdmin BIT = CASE WHEN EXISTS (SELECT 1 FROM [dbo].[tblEmployees]
                                             WHERE [EmployeeID] = @EmployeeID
                                               AND [Role] = 'Admin'
                                               AND [AccountStatus] = 'Active')
                                THEN 1 ELSE 0 END;

    SELECT r.[ReservationID], r.[GuestID],
           g.[FirstName] + N' ' + g.[LastName] AS [GuestName],
           r.[RoomID], rm.[RoomNumber], rm.[RoomType],
           r.[CheckInDate], r.[CheckOutDate], r.[NumAdults], r.[NumChildren],
           r.[SpecialRequests], r.[RoomRate], r.[AdditionalCharges], r.[Discount],
           r.[TotalNights], r.[TotalAmount], r.[Status], r.[Remarks],
           r.[ActualCheckIn], r.[ActualCheckOut],
           r.[IsDeleted], r.[DeletedAt], e.[FullName] AS [DeletedByName]
    FROM   [dbo].[tblReservations] r
           INNER JOIN [dbo].[tblGuests] g   ON g.[GuestID]  = r.[GuestID]
           INNER JOIN [dbo].[tblRooms]  rm  ON rm.[RoomID]  = r.[RoomID]
           LEFT  JOIN [dbo].[tblEmployees] e ON e.[EmployeeID] = r.[DeletedBy]
    WHERE  (@IsAdmin = 1 OR r.[IsDeleted] = 0)          -- Front Desk never sees deleted rows
      AND  (@DeletedOnly = 0 OR r.[IsDeleted] = 1)
      AND  (@Keyword IS NULL
            OR g.[FirstName] + N' ' + g.[LastName] LIKE '%' + @Keyword + '%'
            OR rm.[RoomNumber] LIKE '%' + @Keyword + '%'
            OR CAST(r.[ReservationID] AS NVARCHAR (10)) LIKE '%' + @Keyword + '%'
            OR r.[Status] LIKE '%' + @Keyword + '%')
    ORDER BY r.[CheckInDate] DESC, r.[ReservationID] DESC;
END