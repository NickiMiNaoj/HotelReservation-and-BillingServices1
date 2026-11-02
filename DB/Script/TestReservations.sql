-- Manual test for tblReservations / tblReservationRooms / sp_CreateReservation / sp_GetRoomAvailability.
-- Run against HotelDB after the new objects are deployed. It creates its own guest and two rooms (T-901, T-902),
-- prints PASS/FAIL per check, then deletes everything it created.
SET NOCOUNT ON;

DECLARE @Results TABLE (Seq INT IDENTITY(1,1), TestName NVARCHAR(100), Passed BIT);
DECLARE @GuestID INT, @RoomA INT, @RoomB INT, @Res1 INT, @Res2 INT, @Err INT, @Count INT, @Total DECIMAL(12,2), @Status NVARCHAR(20);
DECLARE @Rooms dbo.udtRoomIdList;

-- Setup
INSERT INTO dbo.tblGuests (FirstName, LastName, Email, Phone, RoomType) VALUES ('Test', 'Reservation', 'zz.reservation.test@example.com', '0000000000', 'Double');
SET @GuestID = SCOPE_IDENTITY();
INSERT INTO dbo.tblRooms (RoomNumber, RoomType, NightlyRate, Capacity, RoomStatus) VALUES ('T-901', 'Double', 100.00, 2, 'Available');
SET @RoomA = SCOPE_IDENTITY();
INSERT INTO dbo.tblRooms (RoomNumber, RoomType, NightlyRate, Capacity, RoomStatus) VALUES ('T-902', 'Double', 80.00, 2, 'Available');
SET @RoomB = SCOPE_IDENTITY();

-- 1. Book T-901 and T-902 together, 10-13 Jan 2027 (3 nights) -> total (100 + 80) x 3 = 540
INSERT INTO @Rooms VALUES (@RoomA), (@RoomB);
EXEC dbo.sp_CreateReservation @GuestID = @GuestID, @ArrivalDate = '2027-01-10', @DepartureDate = '2027-01-13',
     @AdultCount = 3, @KidCount = 1, @Rooms = @Rooms, @Status = 'Confirmed', @ReservationID = @Res1 OUTPUT;
SELECT @Total = TotalAmount FROM dbo.tblReservations WHERE ReservationID = @Res1;
SELECT @Count = COUNT(*) FROM dbo.tblReservationRooms WHERE ReservationID = @Res1;
INSERT INTO @Results (TestName, Passed) VALUES ('Multi-room booking saved: 2 room rows, total = 540', CASE WHEN @Count = 2 AND @Total = 540.00 THEN 1 ELSE 0 END);

-- 2. Overlapping dates on one of the rooms must be rejected (50009) and save nothing
DELETE FROM @Rooms; INSERT INTO @Rooms VALUES (@RoomA);
SET @Err = 0;
BEGIN TRY
    EXEC dbo.sp_CreateReservation @GuestID = @GuestID, @ArrivalDate = '2027-01-12', @DepartureDate = '2027-01-15',
         @AdultCount = 1, @Rooms = @Rooms;
END TRY
BEGIN CATCH
    SET @Err = ERROR_NUMBER();
END CATCH
SELECT @Count = COUNT(*) FROM dbo.tblReservations WHERE GuestID = @GuestID;
INSERT INTO @Results (TestName, Passed) VALUES ('Overlap rejected with error 50009, nothing saved', CASE WHEN @Err = 50009 AND @Count = 1 THEN 1 ELSE 0 END);

-- 3. Atomic: one free room + one booked room in the same request -> whole booking rejected
--    (T-902 is booked 10-13 too, so use a third room that is free: create it on the fly)
DECLARE @RoomC INT;
INSERT INTO dbo.tblRooms (RoomNumber, RoomType, NightlyRate, Capacity, RoomStatus) VALUES ('T-903', 'Double', 60.00, 2, 'Available');
SET @RoomC = SCOPE_IDENTITY();
DELETE FROM @Rooms; INSERT INTO @Rooms VALUES (@RoomA), (@RoomC);
SET @Err = 0;
BEGIN TRY
    EXEC dbo.sp_CreateReservation @GuestID = @GuestID, @ArrivalDate = '2027-01-11', @DepartureDate = '2027-01-12',
         @AdultCount = 1, @Rooms = @Rooms;
END TRY
BEGIN CATCH
    SET @Err = ERROR_NUMBER();
END CATCH
SELECT @Count = COUNT(*) FROM dbo.tblReservationRooms WHERE RoomID = @RoomC;
INSERT INTO @Results (TestName, Passed) VALUES ('Mixed free/booked request fails as a whole (no rows for the free room)', CASE WHEN @Err = 50009 AND @Count = 0 THEN 1 ELSE 0 END);

-- 4. Availability for 11-12 Jan: T-901 and T-902 Booked, T-903 Available
SELECT @Count = COUNT(*) FROM dbo.tblRooms WHERE RoomID IN (@RoomA, @RoomB, @RoomC);  -- sanity
DECLARE @Avail TABLE (RoomID INT, RoomNumber NVARCHAR(20), RoomType NVARCHAR(50), NightlyRate DECIMAL(10,2), Capacity INT, Description NVARCHAR(250), AvailabilityStatus NVARCHAR(20));
INSERT INTO @Avail EXEC dbo.sp_GetRoomAvailability @ArrivalDate = '2027-01-11', @DepartureDate = '2027-01-12';
INSERT INTO @Results (TestName, Passed)
SELECT 'Availability view blocks overlapping dates (T-901/T-902 Booked, T-903 Available)',
       CASE WHEN (SELECT AvailabilityStatus FROM @Avail WHERE RoomID = @RoomA) = 'Booked'
             AND (SELECT AvailabilityStatus FROM @Avail WHERE RoomID = @RoomB) = 'Booked'
             AND (SELECT AvailabilityStatus FROM @Avail WHERE RoomID = @RoomC) = 'Available' THEN 1 ELSE 0 END;

-- 5. Same-day turnover: arrive on the departure day (13-15 Jan) is allowed
DELETE FROM @Rooms; INSERT INTO @Rooms VALUES (@RoomA);
EXEC dbo.sp_CreateReservation @GuestID = @GuestID, @ArrivalDate = '2027-01-13', @DepartureDate = '2027-01-15',
     @AdultCount = 1, @Rooms = @Rooms, @ReservationID = @Res2 OUTPUT;
INSERT INTO @Results (TestName, Passed) VALUES ('Back-to-back stay (arrive on previous departure day) allowed', CASE WHEN @Res2 IS NOT NULL THEN 1 ELSE 0 END);

-- 6. Cancelling the first reservation frees T-902 for 10-13 Jan
EXEC dbo.sp_UpdateReservationStatus @ReservationID = @Res1, @Status = 'Cancelled';
DELETE FROM @Avail;
INSERT INTO @Avail EXEC dbo.sp_GetRoomAvailability @ArrivalDate = '2027-01-10', @DepartureDate = '2027-01-13', @AvailableOnly = 1;
INSERT INTO @Results (TestName, Passed)
SELECT 'Cancelled reservation no longer blocks (T-902 available again)',
       CASE WHEN EXISTS (SELECT 1 FROM @Avail WHERE RoomID = @RoomB) THEN 1 ELSE 0 END;

-- 7. A cancelled reservation cannot be re-activated
SET @Err = 0;
BEGIN TRY
    EXEC dbo.sp_UpdateReservationStatus @ReservationID = @Res1, @Status = 'Confirmed';
END TRY
BEGIN CATCH
    SET @Err = ERROR_NUMBER();
END CATCH
INSERT INTO @Results (TestName, Passed) VALUES ('Cancelled reservation cannot be re-activated (50021)', CASE WHEN @Err = 50021 THEN 1 ELSE 0 END);

-- Report
SELECT Seq, CASE Passed WHEN 1 THEN 'PASS' ELSE 'FAIL' END AS Result, TestName FROM @Results ORDER BY Seq;

-- Cleanup (reservation rows cascade to tblReservationRooms)
DELETE FROM dbo.tblReservations WHERE GuestID = @GuestID;
DELETE FROM dbo.tblRooms WHERE RoomID IN (@RoomA, @RoomB, @RoomC);
DELETE FROM dbo.tblGuests WHERE GuestID = @GuestID;
