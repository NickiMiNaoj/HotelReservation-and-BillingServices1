CREATE PROCEDURE [dbo].[usp_Room_GetAll]
    @Keyword NVARCHAR (50) = NULL   -- optional: filters by room number, type, bed type or status
AS
BEGIN
    SET NOCOUNT ON;

    SELECT [RoomID], [RoomNumber], [Floor], [RoomType], [NightlyRate],
           [MaxCapacity], [BedType], [Status], [Description], [Amenities]
    FROM   [dbo].[tblRooms]
    WHERE  @Keyword IS NULL
        OR [RoomNumber] LIKE '%' + @Keyword + '%'
        OR [RoomType]   LIKE '%' + @Keyword + '%'
        OR [BedType]    LIKE '%' + @Keyword + '%'
        OR [Status]     LIKE '%' + @Keyword + '%'
    ORDER BY [Floor], [RoomNumber];
END