using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FdmphaseRouteDaily
    {
        public DateTime FlightDate { get; set; }
        public string Phase { get; set; }
        public int FromAirportId { get; set; }
        public int ToAirportId { get; set; }
        public string FromAirport { get; set; }
        public string ToAirport { get; set; }
        public string Rout { get; set; }
        public int? EventCount { get; set; }
        public int? FlightCount { get; set; }
        public int? HighCount { get; set; }
        public int? MediumCount { get; set; }
        public int? LowCount { get; set; }
        public int? Score { get; set; }
        public int? ScorePerFlight { get; set; }
        public int? EventPerFlight { get; set; }
    }
}
