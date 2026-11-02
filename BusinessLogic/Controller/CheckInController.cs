using System;
using System.Data;

namespace HotelReservation.BusinessLogic
{
    public class CheckInController
    {
        private readonly CheckInRepository repository;

        public CheckInController()
        {
            repository = new CheckInRepository();
        }

        public DataTable SearchReservations(string searchTerm)
        {
            return repository.GetPendingReservations(searchTerm);
        }

        public bool ProcessCheckIn(int reservationId, int roomId, string keyCardNumber, string remarks)
        {
            try
            {
                repository.ExecuteCheckIn(reservationId, roomId, keyCardNumber, remarks);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Check-in controller failed: " + ex.Message);
            }
        }
    }
}