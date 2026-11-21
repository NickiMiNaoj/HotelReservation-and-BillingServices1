using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace BusinessLogic.Repository
{
    public class DashboardRepository
    {
        private readonly string connectionString = DatabaseConfig.ConnectionString;

        public DataTable GetDashboardSummary()
        {
            const string sql = @"
                SELECT
                    (SELECT COUNT(*) FROM dbo.tblRooms) AS TotalRooms,
                    (SELECT COUNT(*) FROM dbo.tblRooms WHERE Status = 'Available') AS AvailableRooms,
                    (SELECT COUNT(*) FROM dbo.tblRooms WHERE Status = 'Occupied') AS OccupiedRooms,
                    (
                        SELECT COUNT(DISTINCT r.RoomID)
                        FROM dbo.tblReservations r
                        WHERE (r.IsDeleted = 0 OR r.IsDeleted IS NULL)
                          AND r.Status IN ('Pending', 'Confirmed', 'Reserved')
                          AND CAST(GETDATE() AS DATE) <= r.CheckOutDate
                    ) AS ReservedRooms,
                    (
                        SELECT COUNT(*)
                        FROM dbo.tblReservations r
                        WHERE (r.IsDeleted = 0 OR r.IsDeleted IS NULL)
                          AND (
                                CAST(r.ActualCheckIn AS DATE) = CAST(GETDATE() AS DATE)
                                OR (r.ActualCheckIn IS NULL AND r.CheckInDate = CAST(GETDATE() AS DATE) AND r.Status = 'Checked-In')
                              )
                    ) AS TodayCheckIns,
                    (
                        SELECT COUNT(*)
                        FROM dbo.tblReservations r
                        WHERE (r.IsDeleted = 0 OR r.IsDeleted IS NULL)
                          AND (
                                CAST(r.ActualCheckOut AS DATE) = CAST(GETDATE() AS DATE)
                                OR (r.ActualCheckOut IS NULL AND r.CheckOutDate = CAST(GETDATE() AS DATE) AND r.Status = 'Checked-Out')
                              )
                    ) AS TodayCheckOuts,
                    (SELECT COUNT(*) FROM dbo.tblGuests) AS TotalGuests,
                    ISNULL((
                        SELECT SUM(p.AmountApplied)
                        FROM dbo.tblPayments p
                        WHERE CAST(p.PaidAt AS DATE) = CAST(GETDATE() AS DATE)
                    ), 0) AS RevenueToday;";

            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand(sql, conn);
            using var adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetRecentReservations(int topCount = 20)
        {
            const string sql = @"
                SELECT TOP (@TopCount)
                    r.ReservationID AS [Reservation ID],
                    ISNULL(g.FirstName + ' ' + g.LastName, '') AS [Guest Name],
                    ISNULL(rm.RoomNumber, '') AS [Room],
                    r.CheckInDate AS [Check-In],
                    r.CheckOutDate AS [Check-Out],
                    r.Status AS [Status]
                FROM dbo.tblReservations r
                LEFT JOIN dbo.tblGuests g ON r.GuestID = g.GuestID
                LEFT JOIN dbo.tblRooms rm ON r.RoomID = rm.RoomID
                WHERE (r.IsDeleted = 0 OR r.IsDeleted IS NULL)
                ORDER BY r.ReservationID DESC;";

            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@TopCount", SqlDbType.Int).Value = topCount > 0 ? topCount : 20;

            using var adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}