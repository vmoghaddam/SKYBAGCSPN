using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class HelperDelayAirportDaily
    {
        public int? Pyear { get; set; }
        public string PmonthName { get; set; }
        public int? Pmonth { get; set; }
        public int? Pday { get; set; }
        public string PdayName { get; set; }
        public string Pdate { get; set; }
        public int? FromAirport { get; set; }
        public string FromAirportIata { get; set; }
        public int? Delay { get; set; }
        public decimal? DelayPerLeg { get; set; }
        public decimal? DelayPerBl { get; set; }
        public int? OnTimeFlightCount { get; set; }
        public decimal? DelayedFlightsPerAll { get; set; }
        public decimal? DelayedFlightsPerOnTime { get; set; }
        public int? DelayUnder30 { get; set; }
        public int? DelayOver30 { get; set; }
        public int? Delay3060 { get; set; }
        public int? Delay60120 { get; set; }
        public int? Delay120180 { get; set; }
        public int? DelayOver180 { get; set; }
        public int? DelayOver240 { get; set; }
        public int? FltDelayUnder30 { get; set; }
        public int? FltDelayOver30 { get; set; }
        public int? FltDelay3060 { get; set; }
        public int? FltDelay60120 { get; set; }
        public int? FltDelay120180 { get; set; }
        public int? FltDelayOver180 { get; set; }
        public int? FltDelayOver240 { get; set; }
        public int? FlightCount { get; set; }
        public int? AflightCount { get; set; }
        public int? BlockTime { get; set; }
        public int? AblockTime { get; set; }
        public int? FlightTime { get; set; }
        public int? AflightTime { get; set; }
    }
}
