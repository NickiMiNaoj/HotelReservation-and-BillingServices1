using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;   // NuGet: Microsoft.Data.SqlClient
using Model;

namespace BusinessLogic.Repository
{
    public class RoomRepository
    {
        // Inserts a new room and returns the new auto-generated RoomID
        public int Insert(Room room)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_Room_Insert", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                AddRoomParameters(cmd, room);

                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void Update(Room room)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_Room_Update", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoomID", room.RoomID);
                AddRoomParameters(cmd, room);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int roomId)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_Room_Delete", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoomID", roomId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Room list for the grid. A keyword (optional) filters the list.
        public List<Room> GetAll(string keyword = null)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_Room_GetAll", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (string.IsNullOrWhiteSpace(keyword))
                    cmd.Parameters.AddWithValue("@Keyword", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@Keyword", keyword.Trim());

                conn.Open();
                return ReadRooms(cmd);
            }
        }

        // Rooms for the floor grid. A null/empty roomType means all types.
        public List<Room> GetRoomGrid(DateTime date, string roomType = null)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_Room_GetGrid", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Date", date.Date);
                if (string.IsNullOrWhiteSpace(roomType))
                    cmd.Parameters.AddWithValue("@RoomType", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@RoomType", roomType);

                conn.Open();
                return ReadRooms(cmd);
            }
        }

        // ---------- helpers ----------
        private static void AddRoomParameters(SqlCommand cmd, Room room)
        {
            cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
            cmd.Parameters.AddWithValue("@Floor", room.Floor);
            cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
            cmd.Parameters.AddWithValue("@NightlyRate", room.NightlyRate);
            cmd.Parameters.AddWithValue("@MaxCapacity", room.MaxCapacity);
            cmd.Parameters.AddWithValue("@BedType", room.BedType);
            cmd.Parameters.AddWithValue("@Status", room.Status);
            cmd.Parameters.AddWithValue("@Description",
                string.IsNullOrWhiteSpace(room.Description) ? (object)DBNull.Value : room.Description);
            cmd.Parameters.AddWithValue("@Amenities",
                string.IsNullOrWhiteSpace(room.Amenities) ? (object)DBNull.Value : room.Amenities);
        }

        private static List<Room> ReadRooms(SqlCommand cmd)
        {
            List<Room> rooms = new List<Room>();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    rooms.Add(new Room
                    {
                        RoomID = Convert.ToInt32(reader["RoomID"]),
                        RoomNumber = reader["RoomNumber"].ToString(),
                        Floor = Convert.ToInt32(reader["Floor"]),
                        RoomType = reader["RoomType"].ToString(),
                        NightlyRate = Convert.ToDecimal(reader["NightlyRate"]),
                        MaxCapacity = Convert.ToInt32(reader["MaxCapacity"]),
                        BedType = reader["BedType"].ToString(),
                        Status = reader["Status"].ToString(),
                        Description = reader["Description"] == DBNull.Value ? string.Empty : reader["Description"].ToString(),
                        Amenities = reader["Amenities"] == DBNull.Value ? string.Empty : reader["Amenities"].ToString()
                    });
                }
            }
            return rooms;
        }
    }
}