using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Model;
using BusinessLogic.Repository;

namespace BusinessLogic.Controller
{
    public class BillingController
    {
        private readonly BillingRepository _repository = new BillingRepository();

        private static readonly string[] ValidMethods = { "Cash", "Credit Card", "Debit Card", "GCash" };

        // Loads the Billing form for a reservation. Returns null with a message when it is not found.
        public BillingSummary GetBillingSummary(int reservationId, out string message)
        {
            message = string.Empty;

            if (reservationId <= 0)
            {
                message = "Please select a reservation.";
                return null;
            }

            try
            {
                BillingSummary summary = _repository.GetBillingSummary(reservationId);
                if (summary == null)
                    message = "Reservation not found.";
                return summary;
            }
            catch (SqlException ex)
            {
                message = "Database error: " + ex.Message;
                return null;
            }
        }

        // "Process Payment" button. On success, summary holds the refreshed invoice (with ChangeGiven).
        public bool ProcessPayment(int reservationId, decimal foodBeverageCharges, decimal otherServiceCharges,
                                   decimal discount, string paymentMethod, decimal amountTendered, int employeeId,
                                   out BillingSummary summary, out string message)
        {
            summary = null;

            if (reservationId <= 0)
            {
                message = "Please select a reservation.";
                return false;
            }
            if (Array.IndexOf(ValidMethods, paymentMethod) < 0)
            {
                message = "Please select a payment method.";
                return false;
            }
            if (amountTendered <= 0)
            {
                message = "Amount paid must be greater than zero.";
                return false;
            }
            if (foodBeverageCharges < 0 || otherServiceCharges < 0 || discount < 0)
            {
                message = "Charges and discount cannot be negative.";
                return false;
            }

            try
            {
                summary = _repository.ProcessPayment(reservationId, foodBeverageCharges, otherServiceCharges,
                                                     discount, paymentMethod, amountTendered, employeeId);
                message = "Payment processed.";
                return true;
            }
            catch (SqlException ex)
            {
                message = ex.Message;   // e.g. "This invoice is already fully paid."
                return false;
            }
        }

        // Payment History grid. reservationId = null shows every payment.
        public List<Payment> GetPaymentHistory(int employeeId, int? reservationId = null)
        {
            return _repository.GetPaymentHistory(employeeId, reservationId);
        }


        public static decimal ComputeTax(decimal roomCharges, decimal foodBeverage, decimal otherServices,
                                         decimal discount, decimal taxRate)
        {
            decimal taxable = roomCharges + foodBeverage + otherServices - discount;
            return Math.Round(taxable * taxRate, 2, MidpointRounding.AwayFromZero);
        }

        public static decimal ComputeTotalDue(decimal roomCharges, decimal foodBeverage, decimal otherServices,
                                              decimal discount, decimal taxRate)
        {
            decimal taxable = roomCharges + foodBeverage + otherServices - discount;
            return taxable + ComputeTax(roomCharges, foodBeverage, otherServices, discount, taxRate);
        }

        // Only cash can be more than the balance; the extra is the change.
        public static decimal ComputeChange(string paymentMethod, decimal amountTendered, decimal balance)
        {
            if (paymentMethod == "Cash" && amountTendered > balance)
                return amountTendered - balance;
            return 0m;
        }
    }
}