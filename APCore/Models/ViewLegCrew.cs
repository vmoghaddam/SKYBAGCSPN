﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewLegCrew
    {
        public int? CrewId { get; set; }
        public int? FlightId { get; set; }
        public int Fdpid { get; set; }
        public int FdpitemId { get; set; }
        public bool? IsPositioning { get; set; }
        public int? PositionId { get; set; }
        public string Position { get; set; }
        public string Name { get; set; }
        public string ScheduleName { get; set; }
        public int? GroupId { get; set; }
        public string JobGroup { get; set; }
        public string JobGroupCode { get; set; }
        public int? GroupOrder { get; set; }
        public int IsCockpit { get; set; }
        public int? FlightPlanId { get; set; }
        public byte? BlockM { get; set; }
        public int? BlockH { get; set; }
        public int? FlightH { get; set; }
        public byte? FlightM { get; set; }
        public DateTime? ChocksIn { get; set; }
        public DateTime? Landing { get; set; }
        public int? Duty { get; set; }
        public int? ScheduledFlightTime { get; set; }
        public int? Sitatime { get; set; }
        public int FixTime { get; set; }
        public int? FlightTimeActual { get; set; }
        public int? FlightTime { get; set; }
        public int? BlockTime { get; set; }
        public DateTime? ArrivalLocal { get; set; }
        public DateTime? DepartureLocal { get; set; }
        public DateTime? Arrival { get; set; }
        public DateTime? Departure { get; set; }
        public int? FpflightMm { get; set; }
        public int? FpflightHh { get; set; }
        public string OtoAirportIata { get; set; }
        public int? OtoAirportId { get; set; }
        public DateTime? Osta { get; set; }
        public decimal? ActualFlightMtakeoff { get; set; }
        public int? ActualFlightHtakeoff { get; set; }
        public decimal? ActualFlightMoffBlock { get; set; }
        public int? ActualFlightHoffBlock { get; set; }
        public int? IsDelayLanding { get; set; }
        public int? IsDelayOnBlock { get; set; }
        public int? IsDelayTakeoff { get; set; }
        public int? IsDelayOffBlock { get; set; }
        public int? DelayLanding { get; set; }
        public int? DelayOnBlock { get; set; }
        public int? DelayTakeoff { get; set; }
        public int? DelayOffBlock { get; set; }
        public DateTime? Staday { get; set; }
        public DateTime? Stdday { get; set; }
        public string ArrivalRemark { get; set; }
        public string FlightStatus { get; set; }
        public string Register { get; set; }
        public string ToAirportIata { get; set; }
        public int? Msn { get; set; }
        public string DepartureRemark { get; set; }
        public string FromAirportIata { get; set; }
        public int? CustomerId { get; set; }
        public string FlightPlan { get; set; }
        public byte? FlightMplanned { get; set; }
        public int? FlightHplanned { get; set; }
        public DateTime? Stdplanned { get; set; }
        public DateTime? Staplanned { get; set; }
        public int? ToAirport { get; set; }
        public int? FromAirport { get; set; }
        public string FlightNumber { get; set; }
        public int? FlightTypeId { get; set; }
        public int? RegisterId { get; set; }
        public int? FlightStatusId { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Stalocal { get; set; }
        public DateTime? Stdlocal { get; set; }
        public DateTime? Sta { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? ChocksOut { get; set; }
        public DateTime? Takeoff { get; set; }
    }
}
