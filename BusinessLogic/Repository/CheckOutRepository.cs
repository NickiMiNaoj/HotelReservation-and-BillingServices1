using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace HotelReservation.BusinessLogic
{
    public class CheckOutRepository
    {
        private readonly string connectionString = @"Server=LAPTOP-4TR6CTSS\SQLEXPRESS09;Database=DB;Trusted_Connection=True;TrustServerCertificate=True;";
        public DataTable GetActiveStays(string searchTerm)
        {
            DataTable dt = new DataTable();
            string query = "SELECT r.ReservationID, rm.RoomID, rm.RoomNumber, g.FirstName + ' ' + g.LastName AS GuestName, " +
                           "r.ArrivalDate, r.DepartureDate, r.Status " +
                           "FROM tblReservations r " +
                           "JOIN tblGuests g ON r.GuestID = g.GuestID " +
                           "JOIN tblReservationRooms rr ON r.ReservationID = rr.ReservationID " +
                           "JOIN tblRooms rm ON rr.RoomID = rm.RoomID " +
                           "WHERE (@Search = '' OR g.FirstName LIKE @Search OR g.LastName LIKE @Search OR CAST(r.ReservationID AS NVARCHAR) LIKE @Search) " +
                           "AND r.Status = 'Checked In'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Search", string.IsNullOrEmpty(searchTerm) ? (object)DBNull.Value : "%" + searchTerm + "%");
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public void ExecuteCheckOut(int reservationId, int roomId, DateTime actualCheckOutTime, string remarks)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ProcessCheckOut", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                    cmd.Parameters.AddWithValue("@RoomID", roomId);
                    cmd.Parameters.AddWithValue("@ActualCheckOutTime", actualCheckOutTime);
                    cmd.Parameters.AddWithValue("@CheckOutRemarks", remarks ?? string.Empty);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}