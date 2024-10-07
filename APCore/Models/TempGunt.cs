﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class TempGunt
    {
        public int Id { get; set; }
        public int? FlightPlanId { get; set; }
        public int? BaggageCount { get; set; }
        public int? CargoUnitId { get; set; }
        public string CargoUnit { get; set; }
        public int? CargoWeight { get; set; }
        public int? PaxChild { get; set; }
        public int? PaxInfant { get; set; }
        public int? PaxAdult { get; set; }
        public decimal? FuelArrival { get; set; }
        public decimal? FuelDeparture { get; set; }
        public decimal? FuelActual { get; set; }
        public decimal? FuelPlanned { get; set; }
        public decimal? FuelVariance { get; set; }
        public decimal? Gwland { get; set; }
        public decimal? Gwto { get; set; }
        public byte? BlockM { get; set; }
        public int? BlockH { get; set; }
        public int? FlightH { get; set; }
        public byte? FlightM { get; set; }
        public DateTime? ChocksIn { get; set; }
        public DateTime? Landing { get; set; }
        public DateTime? Takeoff { get; set; }
        public DateTime? ChocksOut { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
        public DateTime? Stdlocal { get; set; }
        public DateTime? Stalocal { get; set; }
        public DateTime? Date { get; set; }
        public int FlightStatusId { get; set; }
        public int? RegisterId { get; set; }
        public int? FlightTypeId { get; set; }
        public int TypeId { get; set; }
        public int? OtypeId { get; set; }
        public int? AirlineOperatorsId { get; set; }
        public string Airline { get; set; }
        public string FlightNumber { get; set; }
        public int? FromAirport { get; set; }
        public int? ToAirport { get; set; }
        public DateTime? Staplanned { get; set; }
        public DateTime? Stdplanned { get; set; }
        public int? FlightHplanned { get; set; }
        public int? FlightMplanned { get; set; }
        public string FlightPlan { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? DateActive { get; set; }
        public string FromAirportName { get; set; }
        public string FromAirportIata { get; set; }
        public int FromAirportCityId { get; set; }
        public string ToAirportName { get; set; }
        public string ToAirportIata { get; set; }
        public string FromAirportCity { get; set; }
        public string AircraftType { get; set; }
        public string FlightStatus { get; set; }
        public string FlightStatusBgColor { get; set; }
        public string FlightStatusColor { get; set; }
        public string FlightStatusClass { get; set; }
        public int Status { get; set; }
        public string Notes { get; set; }
        public int Progress { get; set; }
        public string TaskName { get; set; }
        public DateTime? StartDate { get; set; }
        public decimal? Duration { get; set; }
        public int TaskId { get; set; }
        public int? FlightGroupId { get; set; }
        public int? CargoCount { get; set; }
        public int? BaggageWeight { get; set; }
        public int? FuelUnitId { get; set; }
        public string FuelUnit { get; set; }
        public string ArrivalRemark { get; set; }
        public string DepartureRemark { get; set; }
        public int? TotalSeat { get; set; }
        public int EstimatedDelay { get; set; }
        public int? TotalPax { get; set; }
        public int PaxOver { get; set; }
        public DateTime? DateStatus { get; set; }
        public int? FlightStatusUserId { get; set; }
        public DateTime? Stdday { get; set; }
        public DateTime? Staday { get; set; }
        public int? DelayOffBlock { get; set; }
        public int? DelayTakeoff { get; set; }
        public int? DelayOnBlock { get; set; }
        public int? DelayLanding { get; set; }
        public int IsDelayOffBlock { get; set; }
        public int IsDelayTakeoff { get; set; }
        public int IsDelayOnBlock { get; set; }
        public int IsDelayLanding { get; set; }
        public int? ActualFlightHoffBlock { get; set; }
        public decimal? ActualFlightMoffBlock { get; set; }
        public int? ActualFlightHtakeoff { get; set; }
        public decimal? ActualFlightMtakeoff { get; set; }
        public int? LinkedFlight { get; set; }
        public int? LinkedReason { get; set; }
        public string LinkedRemark { get; set; }
        public string LinkedReasonTitle { get; set; }
        public string LinkedFlightNumber { get; set; }
        public int? CancelReasonId { get; set; }
        public string CancelRemark { get; set; }
        public DateTime? CancelDate { get; set; }
        public string CancelReason { get; set; }
        public int? RedirectReasonId { get; set; }
        public string RedirectRemark { get; set; }
        public DateTime? RedirectDate { get; set; }
        public string RedirectReason { get; set; }
        public int? RampReasonId { get; set; }
        public string RampRemark { get; set; }
        public DateTime? RampDate { get; set; }
        public string RampReason { get; set; }
        public DateTime? Osta { get; set; }
        public int? OtoAirportId { get; set; }
        public string OtoAirportIata { get; set; }
        public int? BoxId { get; set; }
        public int? CalendarId { get; set; }
        public int? FpflightHh { get; set; }
        public int? FpflightMm { get; set; }
        public decimal? Fpfuel { get; set; }
        public decimal? Defuel { get; set; }
        public bool? SplitDuty { get; set; }
        public DateTime? Departure { get; set; }
        public DateTime? Arrival { get; set; }
        public DateTime? DepartureLocal { get; set; }
        public DateTime? ArrivalLocal { get; set; }
        public int? CrewMales { get; set; }
        public int? CrewFemales { get; set; }
        public int? MaleFemalError { get; set; }
        public int? MatchingListError { get; set; }
        public int? BlockTime { get; set; }
        public int? FlightTime { get; set; }
        public int? FlightTimeActual { get; set; }
        public int FixTime { get; set; }
        public int? Sitatime { get; set; }
        public decimal? UsedFuel { get; set; }
        public int? Jlblhh { get; set; }
        public int? Jlblmm { get; set; }
        public int? Pflr { get; set; }
        public int? CpcrewId { get; set; }
        public string Cpregister { get; set; }
        public int? CppositionId { get; set; }
        public int? CpflightTypeId { get; set; }
        public int? CpfdpitemId { get; set; }
        public bool? Cpdh { get; set; }
        public int? Cpfdpid { get; set; }
        public string Cpinstructor { get; set; }
        public string Cpp1 { get; set; }
        public string Cpp2 { get; set; }
        public string Cpsccm { get; set; }
        public string Cpisccm { get; set; }
        public int NightTime { get; set; }
        public int? DayTime { get; set; }
    }
}
