using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace BusinessLogic.Repository
{
    public class RoomAvailabilityRepository
    {
        private readonly string connectionString = DatabaseConfig.ConnectionString;

        public DataTable GetRoomTypes()
        {
            const string sql = @"
                SELECT DISTINCT RoomType
                FROM dbo.tblRooms
                WHERE RoomType IS NOT NULL AND LTRIM(RTRIM(RoomType)) <> ''
                ORDER BY RoomType;";

            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand(sql, conn);
            using var adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable SearchAvailableRooms(
            DateTime checkIn,
            DateTime checkOut,
            string roomType,
            decimal minPrice,
            decimal maxPrice)
        {
            const string sql = @"
                SELECT
                    rm.RoomID,
                    rm.RoomNumber AS [Room No.],
                    rm.RoomType AS [Type],
                    rm.NightlyRate AS [Rate],
                    rm.[Floor] AS [Floor],
                    rm.MaxCapacity AS [Max Capacity],
                    rm.BedType,
                    ISNULL(rm.[Description], '') AS [Description],
                    ISNULL(rm.Amenities, '') AS Amenities,
                    CASE
                        WHEN EXISTS (
                            SELECT 1
                            FROM dbo.tblReservations r
                            WHERE r.RoomID = rm.RoomID
                              AND (r.IsDeleted = 0 OR r.IsDeleted IS NULL)
                              AND r.Status NOT IN ('Cancelled', 'Checked-Out', 'No-Show')
                              AND (
                                    r.Status = 'Checked-In'
                                    OR (r.ActualCheckIn IS NOT NULL AND r.ActualCheckOut IS NULL)
                                    OR (
                                        CAST(@CheckIn AS DATE) < r.CheckOutDate
                                        AND CAST(@CheckOut AS DATE) > r.CheckInDate
                                    )
                                  )
                        ) THEN 'Booked'
                        ELSE rm.Status
                    END AS [Status]
                FROM dbo.tblRooms rm
                WHERE (@RoomType = 'All Types' OR @RoomType = '' OR rm.RoomType = @RoomType)
                  AND rm.NightlyRate >= @MinPrice
                  AND (@MaxPrice <= 0 OR rm.NightlyRate <= @MaxPrice)
                  AND NOT EXISTS (
                        SELECT 1
                        FROM dbo.tblReservations r
                        WHERE r.RoomID = rm.RoomID
                          AND (r.IsDeleted = 0 OR r.IsDeleted IS NULL)
                          AND r.Status NOT IN ('Cancelled', 'Checked-Out', 'No-Show')
                          AND (
                                r.Status = 'Checked-In'
                                OR (r.ActualCheckIn IS NOT NULL AND r.ActualCheckOut IS NULL)
                                OR (
                                    CAST(@CheckIn AS DATE) < r.CheckOutDate
                                    AND CAST(@CheckOut AS DATE) > r.CheckInDate
                                )
                              )
                  )
                ORDER BY rm.RoomNumber;";

            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@CheckIn", SqlDbType.DateTime2).Value = checkIn;
            cmd.Parameters.Add("@CheckOut", SqlDbType.DateTime2).Value = checkOut;
            cmd.Parameters.Add("@RoomType", SqlDbType.NVarChar, 30).Value =
                string.IsNullOrWhiteSpace(roomType) ? "All Types" : roomType.Trim();
            cmd.Parameters.Add("@MinPrice", SqlDbType.Decimal).Value = minPrice;
            cmd.Parameters.Add("@MaxPrice", SqlDbType.Decimal).Value = maxPrice;

            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}