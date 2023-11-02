﻿namespace GoBye.DAL.Data.Models
{
    public class Report
    {
        public int Id { get; set; }
        public int ReservationNumber { get; set; }
        public string Message { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser User { get; set; } = null!;
    }
}
