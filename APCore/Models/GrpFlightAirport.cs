﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class GrpFlightAirport
    {
        public int Pyear { get; set; }
        public string PmonthName { get; set; }
        public int Pmonth { get; set; }
        public int? FromAirport { get; set; }
        public string FromAirportIata { get; set; }
        public int? FlightCount { get; set; }
        public int? BlockTime { get; set; }
        public int? FlightTime { get; set; }
        public int? TotalPax { get; set; }
        public int? TotalPaxAll { get; set; }
    }
}
