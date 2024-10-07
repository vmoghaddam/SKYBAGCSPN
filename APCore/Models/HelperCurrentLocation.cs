using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class HelperCurrentLocation
    {
        public int FdpitemId { get; set; }
        public int Fdpid { get; set; }
        public int FlightId { get; set; }
        public int? CrewId { get; set; }
        public int? FromAirport { get; set; }
        public int? ToAirport { get; set; }
        public string FromAirportIata { get; set; }
        public string ToAirportIata { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
        public int? FlightStatusId { get; set; }
        public long? Rank { get; set; }
    }
}
