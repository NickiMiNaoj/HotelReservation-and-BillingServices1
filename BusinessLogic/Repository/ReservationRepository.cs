using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;   // NuGet: Microsoft.Data.SqlClient
using Model;

namespace BusinessLogic.Repository
{
    public class ReservationRepository
    {
        // Inserts a new reservation and returns the new auto-generated ReservationID
        public int Insert(Reservation reservation)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_Reservation_Insert", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                AddReservationParameters(cmd, reservation);

                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void Update(Reservation reservation)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_Reservation_Update", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReservationID", reservation.ReservationID);
                AddReservationParameters(cmd, reservation);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Soft delete: the row stays in the database and is hidden from Front Desk
        public void SoftDelete(int reservationId, int deletedByEmployeeId)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_Reservation_SoftDelete", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                cmd.Parameters.AddWithValue("@DeletedBy", deletedByEmployeeId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Admin only (the stored procedure checks the role)
        public void Restore(int reservationId, int restoredByEmployeeId)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_Reservation_Restore", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                cmd.Parameters.AddWithValue("@RestoredBy", restoredByEmployeeId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // The stored procedure looks at the employee's role:
        // Admin sees everything, everyone else never gets deleted reservations.
        public List<Reservation> GetAll(int employeeId, string keyword = null, bool deletedOnly = false)
        {
            List<Reservation> reservations = new List<Reservation>();

            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_Reservation_GetAll", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                if (string.IsNullOrWhiteSpace(keyword))
                    cmd.Parameters.AddWithValue("@Keyword", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@Keyword", keyword.Trim());
                cmd.Parameters.AddWithValue("@DeletedOnly", deletedOnly);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        reservations.Add(new Reservation
                        {
                            ReservationID = Convert.ToInt32(reader["ReservationID"]),
                            GuestID = Convert.ToInt32(reader["GuestID"]),
                            GuestName = reader["GuestName"].ToString(),
                            RoomID = Convert.ToInt32(reader["RoomID"]),
                            RoomNumber = reader["RoomNumber"].ToString(),
                            RoomType = reader["RoomType"].ToString(),
                            CheckInDate = Convert.ToDateTime(reader["CheckInDate"]),
                            CheckOutDate = Convert.ToDateTime(reader["CheckOutDate"]),
                            NumAdults = Convert.ToInt32(reader["NumAdults"]),
                            NumChildren = Convert.ToInt32(reader["NumChildren"]),
                            SpecialRequests = reader["SpecialRequests"] == DBNull.Value ? string.Empty : reader["SpecialRequests"].ToString(),
                            RoomRate = Convert.ToDecimal(reader["RoomRate"]),
                            AdditionalCharges = Convert.ToDecimal(reader["AdditionalCharges"]),
                            Discount = Convert.ToDecimal(reader["Discount"]),
                            TotalNights = Convert.ToInt32(reader["TotalNights"]),
                            TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),
                            Status = reader["Status"].ToString(),
                            Remarks = reader["Remarks"] == DBNull.Value ? string.Empty : reader["Remarks"].ToString(),
                            ActualCheckIn = reader["ActualCheckIn"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["ActualCheckIn"]),
                            ActualCheckOut = reader["ActualCheckOut"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["ActualCheckOut"]),
                            IsDeleted = Convert.ToBoolean(reader["IsDeleted"]),
                            DeletedAt = reader["DeletedAt"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["DeletedAt"]),
                            DeletedByName = reader["DeletedByName"] == DBNull.Value ? string.Empty : reader["DeletedByName"].ToString()
                        });
                    }
                }
            }
            return reservations;
        }

        // ---------- helper ----------
        private static void AddReservationParameters(SqlCommand cmd, Reservation r)
        {
            cmd.Parameters.AddWithValue("@GuestID", r.GuestID);
            cmd.Parameters.AddWithValue("@RoomID", r.RoomID);
            cmd.Parameters.AddWithValue("@CheckInDate", r.CheckInDate.Date);
            cmd.Parameters.AddWithValue("@CheckOutDate", r.CheckOutDate.Date);
            cmd.Parameters.AddWithValue("@NumAdults", r.NumAdults);
            cmd.Parameters.AddWithValue("@NumChildren", r.NumChildren);
            cmd.Parameters.AddWithValue("@SpecialRequests",
                string.IsNullOrWhiteSpace(r.SpecialRequests) ? (object)DBNull.Value : r.SpecialRequests);
            cmd.Parameters.AddWithValue("@AdditionalCharges", r.AdditionalCharges);
            cmd.Parameters.AddWithValue("@Discount", r.Discount);
            cmd.Parameters.AddWithValue("@Status", r.Status);
        }
    }
}