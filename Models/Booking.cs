﻿namespace MyWebApi.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int RoomID { get; set; }
        public int UserID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Status { get; set; }
    }
}
