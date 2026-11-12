CREATE PROCEDURE [dbo].[usp_Reservation_Update]
    @ReservationID     INT,
    @GuestID           INT,
    @RoomID            INT,
    @CheckInDate       DATE,
    @CheckOutDate      DATE,
    @NumAdults         INT,
    @NumChildren       INT = 0,
    @SpecialRequests   NVARCHAR (500) = NULL,
    @AdditionalCharges DECIMAL (10, 2) = 0,
    @Discount          DECIMAL (10, 2) = 0,
    @Status            NVARCHAR (20)
AS
BEGIN
    SET NOCOUNT ON;

    -- A deleted reservation cannot be edited (an Admin must restore it first)
    IF NOT EXISTS (SELECT 1 FROM [dbo].[tblReservations]
                   WHERE [ReservationID] = @ReservationID AND [IsDeleted] = 0)
    BEGIN
        RAISERROR('Reservation not found.', 16, 1);
        RETURN;
    END

    IF @CheckOutDate <= @CheckInDate
    BEGIN
        RAISERROR('Check-out date must be after the check-in date.', 16, 1);
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM [dbo].[tblGuests] WHERE [GuestID] = @GuestID)
    BEGIN
        RAISERROR('Guest not found.', 16, 1);
        RETURN;
    END

    DECLARE @Rate DECIMAL (10, 2), @MaxCapacity INT, @RoomStatus NVARCHAR (30);

    SELECT @Rate = [NightlyRate], @MaxCapacity = [MaxCapacity], @RoomStatus = [Status]
    FROM   [dbo].[tblRooms]
    WHERE  [RoomID] = @RoomID;

    IF @Rate IS NULL
    BEGIN
        RAISERROR('Room not found.', 16, 1);
        RETURN;
    END

    IF @NumAdults + @NumChildren > @MaxCapacity
    BEGIN
        RAISERROR('The number of guests is more than the room capacity.', 16, 1);
        RETURN;
    END

    BEGIN TRANSACTION;

    -- Only reservations that still hold the room are checked for overlaps
    IF @Status IN ('Pending', 'Confirmed', 'CheckedIn')
       AND EXISTS (SELECT 1 FROM [dbo].[tblReservations] WITH (UPDLOCK, HOLDLOCK)
                   WHERE [RoomID] = @RoomID
                     AND [ReservationID] <> @ReservationID
                     AND [IsDeleted] = 0
                     AND [Status] IN ('Pending', 'Confirmed', 'CheckedIn')
                     AND [CheckInDate] < @CheckOutDate
                     AND [CheckOutDate] > @CheckInDate)
    BEGIN
        ROLLBACK TRANSACTION;
        RAISERROR('The room is already booked for the selected dates.', 16, 1);
        RETURN;
    END

    UPDATE [dbo].[tblReservations]
    SET    [GuestID]           = @GuestID,
           -- the saved rate is only refreshed when the guest is moved to another room
           [RoomRate]          = CASE WHEN [RoomID] <> @RoomID THEN @Rate ELSE [RoomRate] END,
           [RoomID]            = @RoomID,
           [CheckInDate]       = @CheckInDate,
           [CheckOutDate]      = @CheckOutDate,
           [NumAdults]         = @NumAdults,
           [NumChildren]       = @NumChildren,
           [SpecialRequests]   = @SpecialRequests,
           [AdditionalCharges] = @AdditionalCharges,
           [Discount]          = @Discount,
           [Status]            = @Status
    WHERE  [ReservationID] = @ReservationID;

    COMMIT TRANSACTION;
END