using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FdmcptAirportMonthly
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public int? FlightCount { get; set; }
        public int? EventsCount { get; set; }
        public int? HighCount { get; set; }
        public int? MediumCount { get; set; }
        public int? LowCount { get; set; }
        public string FromAirportIata { get; set; }
        public string ToAirportIata { get; set; }
        public string Name { get; set; }
        public int CrewId { get; set; }
        public string JobGroup { get; set; }
        public string Phase { get; set; }
        public bool? Approved { get; set; }
    }
}
