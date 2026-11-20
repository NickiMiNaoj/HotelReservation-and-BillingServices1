using Model;
using System.Data;


public List<Room> GetAvailableRooms(DateTime checkIn, DateTime checkOut, string roomType = null)
{
    using (SqlConnection conn = new SqlConnection(DatabaseConfig.ConnectionString))
    using (SqlCommand cmd = new SqlCommand("usp_Room_GetAvailable", conn))
    {
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@CheckInDate", checkIn.Date);
        cmd.Parameters.AddWithValue("@CheckOutDate", checkOut.Date);

        if (string.IsNullOrWhiteSpace(roomType))
            cmd.Parameters.AddWithValue("@RoomType", DBNull.Value);
        else
            cmd.Parameters.AddWithValue("@RoomType", roomType);

        conn.Open();
        return ReadRooms(cmd);   // re-uses the existing private helper
    }
}
