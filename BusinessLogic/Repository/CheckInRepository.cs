using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace HotelReservation.BusinessLogic
{
    public class CheckInRepository
    {
        private readonly string connectionString = @"Server=LAPTOP-4TR6CTSS\SQLEXPRESS09;Database=DB;Trusted_Connection=True;TrustServerCertificate=True;";

        public DataTable GetPendingReservations(string searchTerm)
        {
            DataTable dt = new DataTable();
            string query = "SELECT r.ReservationID, rr.RoomID, g.FirstName + ' ' + g.LastName AS GuestName, rm.RoomNumber, r.ArrivalDate, r.DepartureDate, r.Status " +
                           "FROM tblReservations r " +
                           "JOIN tblGuests g ON r.GuestID = g.GuestID " +
                           "JOIN tblReservationRooms rr ON r.ReservationID = rr.ReservationID " +
                           "JOIN tblRooms rm ON rr.RoomID = rm.RoomID " +
                           "WHERE (g.FirstName LIKE @Search OR g.LastName LIKE @Search OR r.ReservationID LIKE @Search) " +
                           "AND r.Status IN ('Pending', 'Confirmed')";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Search", "%" + searchTerm + "%");
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public void ExecuteCheckIn(int reservationId, int roomId, string keyCardNumber, string remarks)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ProcessCheckIn", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                    cmd.Parameters.AddWithValue("@RoomID", roomId);
                    cmd.Parameters.AddWithValue("@KeyCardNumber", keyCardNumber);
                    cmd.Parameters.AddWithValue("@Remarks", remarks ?? string.Empty);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}