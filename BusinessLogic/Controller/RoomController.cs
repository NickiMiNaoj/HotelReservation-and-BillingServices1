using BusinessLogic.Repository;
using System.Collections.Generic;

namespace BusinessLogic.Controller
{
    public class RoomController
    {
        private readonly RoomRepository _roomRepository;

        public RoomController()
        {
            _roomRepository = new RoomRepository();
        }

        // Retrieve all rooms
        public List<Room> GetAllRooms()
        {
            return _roomRepository.GetAllRooms();
        }

        // Add a new room with input checks
        public string AddRoom(string roomNumber, string roomType, decimal nightlyRate, int capacity, string status, string description)
        {
            if (string.IsNullOrWhiteSpace(roomNumber))
                return "Room number is required.";

            if (nightlyRate < 0)
                return "Nightly rate cannot be negative.";

            if (capacity <= 0)
                return "Capacity must be at least 1 person.";

            Room newRoom = new Room
            {
                RoomNumber = roomNumber,
                RoomType = roomType,
                NightlyRate = nightlyRate,
                Capacity = capacity,
                RoomStatus = string.IsNullOrWhiteSpace(status) ? "Available" : status,
                Description = description
            };

            bool success = _roomRepository.AddRoom(newRoom);
            return success ? "Success" : "Failed to save room. Check if the room number already exists.";
        }

        // Update room details
        public string UpdateRoom(int roomId, string roomNumber, string roomType, decimal nightlyRate, int capacity, string status, string description)
        {
            if (roomId <= 0)
                return "Invalid Room ID selected.";

            if (string.IsNullOrWhiteSpace(roomNumber))
                return "Room number is required.";

            Room roomToUpdate = new Room
            {
                RoomID = roomId,
                RoomNumber = roomNumber,
                RoomType = roomType,
                NightlyRate = nightlyRate,
                Capacity = capacity,
                RoomStatus = status,
                Description = description
            };

            bool success = _roomRepository.UpdateRoom(roomToUpdate);
            return success ? "Success" : "Failed to update room details.";
        }

        // Delete room
        public string DeleteRoom(int roomId)
        {
            if (roomId <= 0)
                return "Please select a valid room to delete.";

            bool success = _roomRepository.DeleteRoom(roomId);
            return success ? "Success" : "Failed to delete room.";
        }
    }
}