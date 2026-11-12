using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Model;
using BusinessLogic.Repository;

namespace BusinessLogic.Controller
{
    public class RoomController
    {
        private readonly RoomRepository _repository = new RoomRepository();

        private static readonly string[] ValidBedTypes = { "Single", "Twin", "Queen", "King" };
        private static readonly string[] ValidStatuses = { "Available", "Occupied", "Needs Housekeeping", "Under Maintenance" };

        public bool AddRoom(Room room, out string message)
        {
            string error = Validate(room);
            if (error != null)
            {
                message = error;
                return false;
            }

            try
            {
                room.RoomID = _repository.Insert(room);
                message = "Room saved.";
                return true;
            }
            catch (SqlException ex)
            {
                message = ex.Message;   // e.g. "Room number already exists."
                return false;
            }
        }

        public bool UpdateRoom(Room room, out string message)
        {
            if (room.RoomID <= 0)
            {
                message = "Select a room to update.";
                return false;
            }

            string error = Validate(room);
            if (error != null)
            {
                message = error;
                return false;
            }

            try
            {
                _repository.Update(room);
                message = "Room updated.";
                return true;
            }
            catch (SqlException ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public bool DeleteRoom(int roomId, out string message)
        {
            if (roomId <= 0)
            {
                message = "Select a room to delete.";
                return false;
            }

            try
            {
                _repository.Delete(roomId);
                message = "Room deleted.";
                return true;
            }
            catch (SqlException ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public List<Room> GetAllRooms(string keyword = null)
        {
            return _repository.GetAll(keyword);
        }

        public List<Room> GetRoomGrid(DateTime date, string roomType = null)
        {
            return _repository.GetRoomGrid(date, roomType);
        }

        // Returns an error message, or null when everything is valid
        private string Validate(Room room)
        {
            if (string.IsNullOrWhiteSpace(room.RoomNumber))
                return "Room number is required.";
            if (string.IsNullOrWhiteSpace(room.RoomType))
                return "Please select a room type.";
            if (room.NightlyRate <= 0)
                return "Nightly rate must be greater than zero.";
            if (room.MaxCapacity < 1 || room.MaxCapacity > 10)
                return "Maximum capacity must be between 1 and 10.";
            if (Array.IndexOf(ValidBedTypes, room.BedType) < 0)
                return "Please select a valid bed type.";
            if (Array.IndexOf(ValidStatuses, room.Status) < 0)
                return "Please select a valid room status.";

            // The Rooms Maintenance form has no Floor field, so use the first digit
            // of the room number (101 = 1st floor, 205 = 2nd floor, 312 = 3rd floor).
            if (room.Floor <= 0)
            {
                char first = room.RoomNumber.Trim()[0];
                if (char.IsDigit(first) && first != '0')
                    room.Floor = first - '0';
                else
                    return "Use a room number that starts with the floor digit (for example 101).";
            }

            room.RoomNumber = room.RoomNumber.Trim();
            return null;
        }
    }
}