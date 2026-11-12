using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomNumber { get; set; } = string.Empty;
        public int Floor { get; set; }
        public string RoomType { get; set; } = string.Empty;
        public decimal NightlyRate { get; set; }
        public int MaxCapacity { get; set; }
        public string BedType { get; set; } = string.Empty;       // Single, Twin, Queen, King
        public string Status { get; set; } = "Available";         // Available, Occupied, Needs Housekeeping, Under Maintenance
        public string Description { get; set; } = string.Empty;
        public string Amenities { get; set; } = string.Empty;     // comma-separated, e.g. "Wi-Fi, Safe"
    }
}