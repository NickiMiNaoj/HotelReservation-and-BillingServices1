using System;
using System.Data;
using BusinessLogic.Repository;

namespace BusinessLogic.Controller
{
    public class CheckOutController
    {
        private readonly CheckOutRepository repository;

        public CheckOutController()
        {
            repository = new CheckOutRepository();
        }

        // SEARCH ACTIVE STAYS
        public DataTable SearchActiveStays(string searchTerm)
        {
            return repository.GetActiveStays(searchTerm);
        }

        // CALCULATE CHANGE DUE
        public decimal CalculateChangeDue(decimal balanceDue, decimal amountTendered)
        {
            if (balanceDue <= 0m) return 0m;
            decimal change = amountTendered - balanceDue;
            return change > 0m ? change : 0m;
        }

        // PROCESS CHECK-OUT
        public bool ProcessCheckOut(
            int reservationId,
            int roomId,
            int employeeId,
            DateTime actualCheckOutTime,
            decimal balanceDue,
            decimal amountTendered,
            string remarks)
        {
            try
            {
                if (reservationId <= 0)
                    throw new Exception("Please select an active stay first.");

                if (balanceDue > 0m && amountTendered < balanceDue)
                    throw new Exception($"Insufficient payment. Balance due is {balanceDue:0.00}.");

                repository.ExecuteCheckOut(
                    reservationId,
                    roomId,
                    employeeId,
                    actualCheckOutTime,
                    balanceDue,
                    amountTendered,
                    remarks);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Check-out controller failed: " + ex.Message);
            }
        }
    }
}