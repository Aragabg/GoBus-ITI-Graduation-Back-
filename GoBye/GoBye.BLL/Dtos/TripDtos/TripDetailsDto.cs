﻿using GoBye.BLL.Dtos.ReservationDtos;

namespace GoBye.BLL.Dtos.TripDtos
{
    public class TripDetailsDto
    {
        public int Id { get; set; }
        public int AvailableSeats { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string BusClassName { get; set; } = string.Empty;
        public string StartBranchName { get; set; } = string.Empty;
        public string EndBranchName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public IEnumerable<ReservationReadDto> ReservationReadDtos { get; set; } = new List<ReservationReadDto>();
    }
}
