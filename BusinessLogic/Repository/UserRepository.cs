using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BusinessLogic.Repository
{
    internal class UserRepository
    {
        // Change this string to match your database server details
        private readonly string _connectionString = "Server=localhost;Database=HotelDB;Trusted_Connection=True;";

        // Method to validate login credentials via Stored Procedure
        public User AuthenticateUser(string username, string password)
        {
            User user = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_UserLogin", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Pass parameters to the Stored Procedure
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // If a row is returned, credentials are valid
                        if (reader.Read())
                        {
                            user = new User
                            {
                                UserID = Convert.ToInt32(reader["UserID"]),
                                Username = reader["Username"].ToString(),
                                FullName = reader["FullName"].ToString(),
                                Role = reader["Role"].ToString()
                            };
                        }
                    }
                }
            }

            return user; // Returns user if found, or null if login failed
        }
    }
}
