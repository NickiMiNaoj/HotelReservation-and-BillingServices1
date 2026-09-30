using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    internal class RoomModel
    {
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public decimal NightlyRate { get; set; }
        public int Capacity { get; set; }
        public string RoomStatus { get; set; }
        public string Description { get; set; }
    }
}
