﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class RptDelayCatRegisterMonthlyCal
    {
        public int Year { get; set; }
        public string MonthName { get; set; }
        public int Month { get; set; }
        public string Icategory { get; set; }
        public int TypeId { get; set; }
        public string AircraftType { get; set; }
        public string Register { get; set; }
        public int RegisterId { get; set; }
        public int Delay { get; set; }
        public int PreDelay { get; set; }
        public decimal? DelayDiff { get; set; }
        public int Count { get; set; }
        public int PreCount { get; set; }
        public decimal? CountDiff { get; set; }
        public decimal? CountPerLeg { get; set; }
        public decimal PreCountPerLeg { get; set; }
        public decimal? CountPerLegDiff { get; set; }
        public decimal? DelayPerLeg { get; set; }
        public decimal PreDelayPerLeg { get; set; }
        public decimal? DelayPerLegDiff { get; set; }
        public decimal? DelayPerBl { get; set; }
        public decimal PreDelayPerBl { get; set; }
        public decimal? DelayPerBldiff { get; set; }
        public int? OnTimeFlightCount { get; set; }
        public int PreOnTimeFlightCount { get; set; }
        public decimal? OnTimeFlightCountDiff { get; set; }
        public decimal? DelayedFlightsPerAll { get; set; }
        public decimal PreDelayedFlightsPerAll { get; set; }
        public decimal? DelayedFlightsPerAllDiff { get; set; }
        public decimal? DelayedFlightsPerOnTime { get; set; }
        public decimal PreDelayedFlightsPerOnTime { get; set; }
        public decimal? DelayedFlightsPerOnTimeDiff { get; set; }
        public int DelayUnder30 { get; set; }
        public int PreDelayUnder30 { get; set; }
        public decimal? DelayUnder30Diff { get; set; }
        public int DelayOver30 { get; set; }
        public int PreDelayOver30 { get; set; }
        public decimal? DelayOver30Diff { get; set; }
        public int Delay3060 { get; set; }
        public int PreDelay3060 { get; set; }
        public decimal? Delay3060Diff { get; set; }
        public int Delay60120 { get; set; }
        public int PreDelay60120 { get; set; }
        public decimal? Delay60120Diff { get; set; }
        public int Delay120180 { get; set; }
        public int PreDelay120180 { get; set; }
        public decimal? Delay120180Diff { get; set; }
        public int DelayOver180 { get; set; }
        public int PreDelayOver180 { get; set; }
        public decimal? DelayOver180Diff { get; set; }
        public int DelayOver240 { get; set; }
        public int PreDelayOver240 { get; set; }
        public decimal? DelayOver240Diff { get; set; }
        public int FltDelayUnder30 { get; set; }
        public int PreFltDelayUnder30 { get; set; }
        public decimal? FltDelayUnder30Diff { get; set; }
        public int FltDelayOver30 { get; set; }
        public int PreFltDelayOver30 { get; set; }
        public decimal? FltDelayOver30Diff { get; set; }
        public int FltDelay3060 { get; set; }
        public int PreFltDelay3060 { get; set; }
        public decimal? FltDelay3060Diff { get; set; }
        public int FltDelay60120 { get; set; }
        public int PreFltDelay60120 { get; set; }
        public decimal? FltDelay60120Diff { get; set; }
        public int FltDelay120180 { get; set; }
        public int PreFltDelay120180 { get; set; }
        public decimal? FltDelay120180Diff { get; set; }
        public int FltDelayOver180 { get; set; }
        public int PreFltDelayOver180 { get; set; }
        public decimal? FltDelayOver180Diff { get; set; }
        public int FltDelayOver240 { get; set; }
        public int PreFltDelayOver240 { get; set; }
        public decimal? FltDelayOver240Diff { get; set; }
        public int DelayUnder30Time { get; set; }
        public int PreDelayUnder30Time { get; set; }
        public decimal? DelayUnder30TimeDiff { get; set; }
        public int? DelayOver30Time { get; set; }
        public int? PreDelayOver30Time { get; set; }
        public decimal? DelayOver30TimeDiff { get; set; }
        public int? Delay3060Time { get; set; }
        public int? PreDelay3060Time { get; set; }
        public decimal? Delay3060TimeDiff { get; set; }
        public int? Delay60120Time { get; set; }
        public int? PreDelay60120Time { get; set; }
        public decimal? Delay60120TimeDiff { get; set; }
        public int? Delay120180Time { get; set; }
        public int? PreDelay120180Time { get; set; }
        public decimal? Delay120180TimeDiff { get; set; }
        public int DelayOver180Time { get; set; }
        public int PreDelayOver180Time { get; set; }
        public decimal? DelayOver180TimeDiff { get; set; }
        public int? DelayOver240Time { get; set; }
        public int? PreDelayOver240Time { get; set; }
        public decimal? DelayOver240TimeDiff { get; set; }
        public int FlightCount { get; set; }
        public int PreFlightCount { get; set; }
        public decimal? FlightCountDiff { get; set; }
        public int? AflightCount { get; set; }
        public int PreAflightCount { get; set; }
        public decimal? AflightCountDiff { get; set; }
        public int BlockTime { get; set; }
        public int PreBlockTime { get; set; }
        public decimal? BlockTimeDiff { get; set; }
        public int? AblockTime { get; set; }
        public int PreAblockTime { get; set; }
        public decimal? AblockTimeDiff { get; set; }
        public int FlightTime { get; set; }
        public int PreFlightTime { get; set; }
        public decimal? FlightTimeDiff { get; set; }
        public int? AflightTime { get; set; }
        public int PreAflightTime { get; set; }
        public decimal? AflightTimeDiff { get; set; }
    }
}
