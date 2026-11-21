using System;
using System.Data;
using BusinessLogic.Repository;

namespace BusinessLogic.Controller
{
    public class RoomAvailabilityController
    {
        private readonly RoomAvailabilityRepository repository;

        public RoomAvailabilityController()
        {
            repository = new RoomAvailabilityRepository();
        }

        public DataTable GetRoomTypes()
        {
            return repository.GetRoomTypes();
        }

        public DataTable SearchRooms(
            DateTime checkIn,
            DateTime checkOut,
            string roomType,
            decimal minPrice,
            decimal maxPrice)
        {
            try
            {
                if (maxPrice > 0m && minPrice > maxPrice)
                    throw new Exception("Min Price cannot be greater than Max Price.");

                if (checkOut < checkIn)
                    throw new Exception("Check-Out date/time cannot be earlier than Check-In.");

                return repository.SearchAvailableRooms(checkIn, checkOut, roomType, minPrice, maxPrice);
            }
            catch (Exception ex)
            {
                throw new Exception("Room availability controller failed: " + ex.Message);
            }
        }
    }
}