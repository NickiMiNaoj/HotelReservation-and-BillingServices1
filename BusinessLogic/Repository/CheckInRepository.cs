
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace HotelReservation.BusinessLogic
{
    public class CheckInRepository
    {
        private readonly string connectionString = @"Server=LAPTOP-4TR6CTSS\SQLEXPRESS09;Database=HotelReservationDB;Trusted_Connection=True;TrustServerCertificate=True;";

        // SEARCH RESERVATIONS
        public DataTable GetPendingReservations(string searchTerm)
        {
            DataTable dt = new DataTable();

            string query = @"
                            
                SELECT
                    r.ReservationID,
                    r.GuestID,
                    r.RoomID,
                    g.FirstName + ' ' + g.LastName AS GuestName,
                    rm.RoomNumber,
                    r.CheckInDate,
                    r.CheckOutDate,
                    r.Status,
                    i.TotalAmountDue,
                    ISNULL(p.TotalPaid, 0) AS TotalPaid,

                    CASE
                        WHEN ISNULL(p.TotalPaid, 0) >= i.TotalAmountDue
                        THEN 'CLEARED'
                        ELSE 'PENDING'
                    END AS PaymentStatus

                FROM tblReservations r

                INNER JOIN tblGuests g
                    ON r.GuestID = g.GuestID

                INNER JOIN tblRooms rm
                    ON r.RoomID = rm.RoomID

                LEFT JOIN tblInvoices i
                    ON r.ReservationID = i.ReservationID

                OUTER APPLY
                (
                    SELECT SUM(AmountApplied) AS TotalPaid
                    FROM tblPayments
                    WHERE InvoiceID = i.InvoiceID
                ) p

                WHERE
                    (g.FirstName LIKE @Search
                    OR g.LastName LIKE @Search
                    OR CAST(r.ReservationID AS NVARCHAR(20)) LIKE @Search)

                    AND r.Status IN ('Pending', 'Confirmed')

                ORDER BY r.ReservationID DESC;";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "@Search", "%" + (searchTerm ?? "") + "%");

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

        // PROCESS CHECK-IN
        public void ExecuteCheckIn(
            int reservationId,
            int roomId,
            string keyCardNumber,
            string remarks)
        {
            string query = @"
        UPDATE tblReservations
        SET
            Status = 'Checked-In',
            ActualCheckIn = GETDATE(),
            KeyCardNumber = @KeyCardNumber,
            Remarks = @Remarks
        WHERE
            ReservationID = @ReservationID
            AND RoomID = @RoomID
            AND Status IN ('Pending', 'Confirmed')
            AND ActualCheckIn IS NULL";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                    cmd.Parameters.AddWithValue("@RoomID", roomId);
                    cmd.Parameters.AddWithValue("@KeyCardNumber", keyCardNumber);
                    cmd.Parameters.AddWithValue("@Remarks", remarks ?? "");

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception(
                            "Reservation could not be checked in. Please verify its status.");
                    }
                }
            }
        }

    }
}
