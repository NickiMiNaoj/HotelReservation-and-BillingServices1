using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    // Everything the Billing and Payment form shows for one reservation
    public class BillingSummary
    {
        public int ReservationID { get; set; }
        public string GuestName { get; set; } = string.Empty;
        public string RoomNumber { get; set; } = string.Empty;

        public decimal RoomCharges { get; set; }
        public decimal FoodBeverageCharges { get; set; }
        public decimal OtherServiceCharges { get; set; }
        public decimal Discount { get; set; }
        public decimal TaxRate { get; set; }                  // 0.12 = 12%
        public decimal TaxAmount { get; set; }
        public decimal TotalAmountDue { get; set; }

        public decimal AmountPaid { get; set; }               // total already paid on this invoice
        public decimal Balance { get; set; }                  // TotalAmountDue - AmountPaid
        public string PaymentStatus { get; set; } = "Unpaid"; // Paid, Partially Paid, Unpaid

        public int? InvoiceID { get; set; }                   // null until the first payment creates the invoice
        public string InvoiceNumber { get; set; } = string.Empty;   // empty until the invoice exists

        public decimal ChangeGiven { get; set; }              // only filled after a payment was processed
    }
}