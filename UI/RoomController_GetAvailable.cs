// ============================================================
// ISSUE #33 – Add this method to RoomController.cs
// ============================================================

// Place inside the RoomController class:

using Model;

/// <summary>
/// Backend availability query used by the Availability View and
/// by the room-selection dropdown when creating a new reservation.
/// </summary>
public List<Room> GetAvailableRooms(DateTime checkIn, DateTime checkOut, string roomType = null)
{
    if (checkOut.Date <= checkIn.Date)
        return new List<Room>();   // invalid range → empty list

    return _repository.GetAvailableRooms(checkIn, checkOut, roomType);
}
