using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class DelayAvgByAirport
    {
        public int FromAirport { get; set; }
        public string FromAirportIata { get; set; }
        public int? Avg { get; set; }
    }
}
