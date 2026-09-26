using System;
using System.Data;
using System.Data.SqlClient;
using Model.UserModel;

namespace BusinessLogic.Repository
{
    internal class UserRepository
    {
        private readonly string _connectionString = "Server=localhost;Database=HotelDB;Trusted_Connection=True;";

        public User AuthenticateUser(string username, string password)
        {
            User user = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_UserLogin", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
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

            return user; 
        }
    }
}
