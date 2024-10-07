﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class RptDelayCatAirportMonthly
    {
        public int? Pyear { get; set; }
        public string PmonthName { get; set; }
        public int? Pmonth { get; set; }
        public string Icategory { get; set; }
        public int? IcategoryId { get; set; }
        public int? FromAirport { get; set; }
        public string FromAirportIata { get; set; }
        public int Delay { get; set; }
        public int? DelayAirport { get; set; }
        public decimal? DelayAirportRatio { get; set; }
        public int PreDelay { get; set; }
        public int Count { get; set; }
        public int PreCount { get; set; }
        public decimal? CountPerLeg { get; set; }
        public decimal PreCountPerLeg { get; set; }
        public decimal? DelayPerLeg { get; set; }
        public decimal PreDelayPerLeg { get; set; }
        public decimal? DelayPerBl { get; set; }
        public decimal PreDelayPerBl { get; set; }
        public int? OnTimeFlightCount { get; set; }
        public int PreOnTimeFlightCount { get; set; }
        public decimal? DelayedFlightsPerAll { get; set; }
        public decimal PreDelayedFlightsPerAll { get; set; }
        public decimal? DelayedFlightsPerOnTime { get; set; }
        public decimal PreDelayedFlightsPerOnTime { get; set; }
        public int DelayUnder30 { get; set; }
        public int PreDelayUnder30 { get; set; }
        public int DelayOver30 { get; set; }
        public int PreDelayOver30 { get; set; }
        public int Delay3060 { get; set; }
        public int PreDelay3060 { get; set; }
        public int Delay60120 { get; set; }
        public int PreDelay60120 { get; set; }
        public int Delay120180 { get; set; }
        public int PreDelay120180 { get; set; }
        public int DelayOver180 { get; set; }
        public int PreDelayOver180 { get; set; }
        public int DelayOver240 { get; set; }
        public int PreDelayOver240 { get; set; }
        public int DelayUnder30Time { get; set; }
        public int PreDelayUnder30Time { get; set; }
        public int DelayOver30Time { get; set; }
        public int PreDelayOver30Time { get; set; }
        public int Delay3060Time { get; set; }
        public int PreDelay3060Time { get; set; }
        public int Delay60120Time { get; set; }
        public int PreDelay60120Time { get; set; }
        public int Delay120180Time { get; set; }
        public int PreDelay120180Time { get; set; }
        public int DelayOver180Time { get; set; }
        public int PreDelayOver180Time { get; set; }
        public int DelayOver240Time { get; set; }
        public int PreDelayOver240Time { get; set; }
        public int FltDelayUnder30 { get; set; }
        public int PreFltDelayUnder30 { get; set; }
        public int FltDelayOver30 { get; set; }
        public int PreFltDelayOver30 { get; set; }
        public int FltDelay3060 { get; set; }
        public int PreFltDelay3060 { get; set; }
        public int FltDelay60120 { get; set; }
        public int PreFltDelay60120 { get; set; }
        public int FltDelay120180 { get; set; }
        public int PreFltDelay120180 { get; set; }
        public int FltDelayOver180 { get; set; }
        public int PreFltDelayOver180 { get; set; }
        public int FltDelayOver240 { get; set; }
        public int PreFltDelayOver240 { get; set; }
        public int FlightCount { get; set; }
        public int PreFlightCount { get; set; }
        public int AflightCount { get; set; }
        public int PreAflightCount { get; set; }
        public int BlockTime { get; set; }
        public int PreBlockTime { get; set; }
        public int? AblockTime { get; set; }
        public int PreAblockTime { get; set; }
        public int FlightTime { get; set; }
        public int PreFlightTime { get; set; }
        public int? AflightTime { get; set; }
        public int PreAflightTime { get; set; }
    }
}
