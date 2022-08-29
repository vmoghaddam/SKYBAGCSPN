﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewFlightsGantt
    {
        public int ID { get; set; }
        public int? FlightPlanId { get; set; }
        public int? BaggageCount { get; set; }
        public int? CargoUnitID { get; set; }
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
        public decimal? GWLand { get; set; }
        public decimal? GWTO { get; set; }
        public byte? BlockM { get; set; }
        public int? BlockH { get; set; }
        public int? FlightH { get; set; }
        public byte? FlightM { get; set; }
        public DateTime? ChocksIn { get; set; }
        public DateTime? Landing { get; set; }
        public DateTime? Takeoff { get; set; }
        public DateTime? ChocksOut { get; set; }
        public DateTime? STD { get; set; }
        public DateTime? STA { get; set; }
        public DateTime? STDLocal { get; set; }
        public DateTime? STALocal { get; set; }
        public DateTime? Date { get; set; }
        public int FlightStatusID { get; set; }
        public int? RegisterID { get; set; }
        public int FlightTypeID { get; set; }
        public string FlightType { get; set; }
        public string FlightTypeAbr { get; set; }
        public int TypeId { get; set; }
        public int? OTypeId { get; set; }
        public int? AirlineOperatorsID { get; set; }
        public string Airline { get; set; }
        public string FlightNumber { get; set; }
        public int? FromAirport { get; set; }
        public int? ToAirport { get; set; }
        public DateTime? STDPlanned { get; set; }
        public DateTime? STAPlanned { get; set; }
        public int? FlightHPlanned { get; set; }
        public int? FlightMPlanned { get; set; }
        public string FlightPlan { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? DateActive { get; set; }
        public string FromAirportName { get; set; }
        public string FromAirportIATA { get; set; }
        public int FromAirportCityId { get; set; }
        public string ToAirportName { get; set; }
        public string ToAirportIATA { get; set; }
        public string FromAirportCity { get; set; }
        public string AircraftType { get; set; }
        public string OAircraftType { get; set; }
        public string Register { get; set; }
        public int? MSN { get; set; }
        public string FlightStatus { get; set; }
        public string FlightStatusBgColor { get; set; }
        public string FlightStatusColor { get; set; }
        public string FlightStatusClass { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public int status { get; set; }
        public string notes { get; set; }
        public int progress { get; set; }
        public string taskName { get; set; }
        public DateTime? startDate { get; set; }
        public decimal? duration { get; set; }
        public int taskId { get; set; }
        public int? FlightGroupID { get; set; }
        public int? PlanId { get; set; }
        public int? ManufacturerId { get; set; }
        public string Manufacturer { get; set; }
        public string FromSortName { get; set; }
        public string FromContry { get; set; }
        public double? FromLatitude { get; set; }
        public double? FromLongitude { get; set; }
        public double? ToLatitude { get; set; }
        public double? ToLongitude { get; set; }
        public int? CargoCount { get; set; }
        public int? BaggageWeight { get; set; }
        public int? FuelUnitID { get; set; }
        public string FuelUnit { get; set; }
        public string ArrivalRemark { get; set; }
        public string DepartureRemark { get; set; }
        public int? TotalSeat { get; set; }
        public int EstimatedDelay { get; set; }
        public int? TotalPax { get; set; }
        public int PaxOver { get; set; }
        public DateTime? DateStatus { get; set; }
        public int? FlightStatusUserId { get; set; }
        public DateTime? STDDay { get; set; }
        public DateTime? STADay { get; set; }
        public int? DelayOffBlock { get; set; }
        public int? DelayTakeoff { get; set; }
        public int? DelayOnBlock { get; set; }
        public int? DelayLanding { get; set; }
        public int IsDelayOffBlock { get; set; }
        public int IsDelayTakeoff { get; set; }
        public int IsDelayOnBlock { get; set; }
        public int IsDelayLanding { get; set; }
        public int? ActualFlightHOffBlock { get; set; }
        public decimal? ActualFlightMOffBlock { get; set; }
        public int? ActualFlightHTakeoff { get; set; }
        public decimal? ActualFlightMTakeoff { get; set; }
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
        public DateTime? OSTA { get; set; }
        public int? OToAirportId { get; set; }
        public string OToAirportIATA { get; set; }
        public bool? IsActive { get; set; }
        public int? BoxId { get; set; }
        public int? CalendarId { get; set; }
        public int BaseId { get; set; }
        public string BaseIATA { get; set; }
        public string BaseName { get; set; }
        public int? FPFlightHH { get; set; }
        public int? FPFlightMM { get; set; }
        public decimal? FPFuel { get; set; }
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
        public int? SITATime { get; set; }
        public decimal? UsedFuel { get; set; }
        public int? JLBLHH { get; set; }
        public int? JLBLMM { get; set; }
        public int? PFLR { get; set; }
        public int? CPCrewId { get; set; }
        public string CPRegister { get; set; }
        public int? CPPositionId { get; set; }
        public int? CPFlightTypeId { get; set; }
        public int? CPFDPItemId { get; set; }
        public bool? CPDH { get; set; }
        public int? CPFDPId { get; set; }
        public string CPInstructor { get; set; }
        public string CPP1 { get; set; }
        public string CPP2 { get; set; }
        public string CPSCCM { get; set; }
        public string CPISCCM { get; set; }
        public int NightTime { get; set; }
        public int? DayTime { get; set; }
        public int? ChrAdult { get; set; }
        public int? ChrChild { get; set; }
        public int? ChrInfant { get; set; }
        public int? ChrCapacity { get; set; }
        public string ChrTitle { get; set; }
        public string ChrCode { get; set; }
        public int? DefaultChrId { get; set; }
        public long? CargoCost { get; set; }
    }
}
