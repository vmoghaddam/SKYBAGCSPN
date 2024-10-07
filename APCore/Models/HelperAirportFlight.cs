using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class HelperAirportFlight
    {
        public DateTime? Stdday { get; set; }
        public string FromAirportIata { get; set; }
        public int? FromAirport { get; set; }
        public int? Count { get; set; }
        public int BlockTime { get; set; }
        public int FlightTime { get; set; }
    }
}
