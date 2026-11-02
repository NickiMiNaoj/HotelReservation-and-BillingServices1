using System;
using System.Data;

namespace HotelReservation.BusinessLogic
{
    public class CheckOutController
    {
        private readonly CheckOutRepository repository;

        public CheckOutController()
        {
            repository = new CheckOutRepository();
        }

        public DataTable SearchActiveStays(string searchTerm)
        {
            return repository.GetActiveStays(searchTerm);
        }

        public bool ProcessCheckOut(int reservationId, int roomId, decimal totalDue, decimal amountPaid, DateTime actualCheckOutTime, string remarks)
        {

            decimal remainingBalance = totalDue - amountPaid;
            if (remainingBalance > 0)
            {
                throw new InvalidOperationException("Cannot process Check-Out: Outstanding billing balance exists.");
            }

            try
            {
                repository.ExecuteCheckOut(reservationId, roomId, actualCheckOutTime, remarks);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Check-out controller failed: " + ex.Message);
            }
        }
    }
}