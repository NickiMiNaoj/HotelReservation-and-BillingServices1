using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    // One row of the Payment History grid
    public class Payment
    {
        public int PaymentID { get; set; }
        public string InvoiceNumber { get; set; } = string.Empty;
        public int ReservationID { get; set; }
        public string GuestName { get; set; } = string.Empty;
        public string RoomNumber { get; set; } = string.Empty;
        public string PaymentMethod { get; set; } = string.Empty;   // Cash, Credit Card, Debit Card, GCash
        public decimal AmountTendered { get; set; }                 // what the guest handed over
        public decimal AmountApplied { get; set; }                  // what counted toward the invoice
        public decimal ChangeGiven { get; set; }
        public DateTime PaidAt { get; set; }
        public string ProcessedByName { get; set; } = string.Empty;
    }
}