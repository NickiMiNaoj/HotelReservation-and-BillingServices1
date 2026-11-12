using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public int GuestID { get; set; }
        public string GuestName { get; set; } = string.Empty;       // read only (from the guest)
        public int RoomID { get; set; }
        public string RoomNumber { get; set; } = string.Empty;      // read only (from the room)
        public string RoomType { get; set; } = string.Empty;        // read only (from the room)
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumAdults { get; set; } = 1;
        public int NumChildren { get; set; }
        public string SpecialRequests { get; set; } = string.Empty;
        public decimal RoomRate { get; set; }                       // rate per night saved at booking
        public decimal AdditionalCharges { get; set; }
        public decimal Discount { get; set; }
        public int TotalNights { get; set; }                        // computed by the database
        public decimal TotalAmount { get; set; }                    // computed by the database
        public string Status { get; set; } = "Pending";             // Pending, Confirmed, Cancelled, CheckedIn, CheckedOut
        public string Remarks { get; set; } = string.Empty;
        public DateTime? ActualCheckIn { get; set; }
        public DateTime? ActualCheckOut { get; set; }

        // Soft delete (Admin only sees these)
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedByName { get; set; } = string.Empty;
    }
}