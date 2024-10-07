using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class Plupd
    {
        public DateTime? Stdday { get; set; }
        public string DayName { get; set; }
        public int Id { get; set; }
        public string FlightNumber { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
        public int? FromAirport { get; set; }
        public int? ToAirport { get; set; }
        public string FromAirportIata { get; set; }
        public string ToAirportIata { get; set; }
        public DateTime? NewStd { get; set; }
        public DateTime? NewSta { get; set; }
        public DateTime? Nstd { get; set; }
        public DateTime? Nsta { get; set; }
    }
}
