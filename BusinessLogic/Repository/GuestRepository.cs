using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class GuestRepository
    {
        private readonly string _connectionString = @"Server=LAPTOP-4TR6CTSS\SQLEXPRESS09;Database=DB;Trusted_Connection=True;TrustServerCertificate=True;";

        public bool AddGuest(GuestModel guest)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GuestOperations", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Action", "CREATE");
                    cmd.Parameters.AddWithValue("@FirstName", guest.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", guest.LastName);
                    cmd.Parameters.AddWithValue("@Email", guest.Email);
                    cmd.Parameters.AddWithValue("@Phone", guest.Phone);
                    cmd.Parameters.AddWithValue("@RoomType", guest.RoomType);
                    cmd.Parameters.AddWithValue("@Status", string.IsNullOrEmpty(guest.Status) ? "Active" : guest.Status);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public List<GuestModel> GetAllGuests()
        {
            List<GuestModel> guests = new List<GuestModel>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GuestOperations", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "READ");

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            guests.Add(new GuestModel
                            {
                                GuestID = Convert.ToInt32(reader["GuestID"]),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Email = reader["Email"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                RoomType = reader["RoomType"].ToString(),
                                Status = reader["Status"].ToString()
                            });
                        }
                    }
                }
            }
            return guests;
        }
        public bool UpdateGuest(GuestModel guest)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GuestOperations", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "UPDATE");
                    cmd.Parameters.AddWithValue("@GuestID", guest.GuestID);
                    cmd.Parameters.AddWithValue("@FirstName", guest.FirstName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@LastName", guest.LastName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", guest.Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Phone", guest.Phone ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@RoomType", guest.RoomType ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Status", guest.Status ?? (object)DBNull.Value);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool DeleteGuest(int guestId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GuestOperations", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Action", "DELETE");
                    cmd.Parameters.AddWithValue("@GuestID", guestId);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public List<GuestModel> SearchGuests(string searchTerm)
        {
            List<GuestModel> guests = new List<GuestModel>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GuestOperations", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "SEARCH");
                    cmd.Parameters.AddWithValue("@SearchTerm", string.IsNullOrWhiteSpace(searchTerm) ? (object)DBNull.Value : searchTerm.Trim());

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            guests.Add(new GuestModel
                            {
                                GuestID = Convert.ToInt32(reader["GuestID"]),
                                FirstName = reader["FirstName"]?.ToString(),
                                LastName = reader["LastName"]?.ToString(),
                                Email = reader["Email"]?.ToString(),
                                Phone = reader["Phone"]?.ToString(),
                                RoomType = reader["RoomType"]?.ToString(),
                                Status = reader["Status"]?.ToString()
                            });
                        }
                    }
                }
            }
            return guests;
        }
    }
}