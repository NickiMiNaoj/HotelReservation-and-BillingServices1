CREATE PROCEDURE [dbo].[usp_Room_GetGrid]
    @Date     DATE,
    @RoomType NVARCHAR (30) = NULL   -- NULL = all types
AS
BEGIN
    SET NOCOUNT ON;

    -- For the floor grid (Available / Needs Housekeeping / Under Maintenance / Occupied).
    -- @Date is not used yet: once tblReservations exists, add the check that marks a room
    -- as 'Booked' when a reservation covers @Date.
    SELECT [RoomID], [RoomNumber], [Floor], [RoomType], [NightlyRate],
           [MaxCapacity], [BedType], [Status], [Description], [Amenities]
    FROM   [dbo].[tblRooms]
    WHERE  @RoomType IS NULL OR [RoomType] = @RoomType
    ORDER BY [Floor], [RoomNumber];
END