using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class RoomRepository
    {
        private readonly string _connectionString = "Server=localhost;Database=HotelDB;Trusted_Connection=True;";

        // 1. CREATE: Add a new room
        public bool AddRoom(RoomModel room)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_AddRoom", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
                    cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
                    cmd.Parameters.AddWithValue("@NightlyRate", room.NightlyRate);
                    cmd.Parameters.AddWithValue("@Capacity", room.Capacity);
                    cmd.Parameters.AddWithValue("@RoomStatus", room.RoomStatus);
                    cmd.Parameters.AddWithValue("@Description", (object)room.Description ?? DBNull.Value);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        // 2. READ: Get all rooms
        public List<RoomModel> GetAllRooms()
        {
            List<RoomModel> roomList = new List<RoomModel>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetAllRooms", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RoomModel room = new RoomModel
                            {
                                RoomID = Convert.ToInt32(reader["RoomID"]),
                                RoomNumber = reader["RoomNumber"].ToString(),
                                RoomType = reader["RoomType"].ToString(),
                                NightlyRate = Convert.ToDecimal(reader["NightlyRate"]),
                                Capacity = Convert.ToInt32(reader["Capacity"]),
                                RoomStatus = reader["RoomStatus"].ToString(),
                                Description = reader["Description"] != DBNull.Value ? reader["Description"].ToString() : ""
                            };

                            roomList.Add(room);
                        }
                    }
                }
            }

            return roomList;
        }

        // 3. UPDATE: Update an existing room
        public bool UpdateRoom(RoomModel room)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdateRoom", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@RoomID", room.RoomID);
                    cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
                    cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
                    cmd.Parameters.AddWithValue("@NightlyRate", room.NightlyRate);
                    cmd.Parameters.AddWithValue("@Capacity", room.Capacity);
                    cmd.Parameters.AddWithValue("@RoomStatus", room.RoomStatus);
                    cmd.Parameters.AddWithValue("@Description", (object)room.Description ?? DBNull.Value);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        // 4. DELETE: Delete a room by ID
        public bool DeleteRoom(int roomId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_DeleteRoom", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoomID", roomId);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}