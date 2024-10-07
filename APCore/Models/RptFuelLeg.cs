using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class RptFuelLeg
    {
        public int Id { get; set; }
        public DateTime? LocalDate { get; set; }
        public string Pdate { get; set; }
        public string PyearName { get; set; }
        public int? Pyear { get; set; }
        public string PmonthName { get; set; }
        public int? Pmonth { get; set; }
        public string PdayName { get; set; }
        public string PyearMonthName { get; set; }
        public int FlightId { get; set; }
        public DateTime? Date { get; set; }
        public int? FlightStatusId { get; set; }
        public int? RegisterId { get; set; }
        public string AircraftType { get; set; }
        public int? TypeId { get; set; }
        public string FlightNumber { get; set; }
        public int? FromAirport { get; set; }
        public int? ToAirport { get; set; }
        public DateTime? ChocksIn { get; set; }
        public DateTime? Landing { get; set; }
        public DateTime? Takeoff { get; set; }
        public DateTime? ChocksOut { get; set; }
        public int? CustomerId { get; set; }
        public string FromAirportIata { get; set; }
        public string ToAirportIata { get; set; }
        public string Register { get; set; }
        public decimal? Defuel { get; set; }
        public decimal? Fpfuel { get; set; }
        public int? TotalPax { get; set; }
        public int? FuelUnitId { get; set; }
        public string FuelUnit { get; set; }
        public int? CargoUnitId { get; set; }
        public string CargoUnit { get; set; }
        public int? CargoCount { get; set; }
        public int? BaggageCount { get; set; }
        public DateTime? Stdlocal { get; set; }
        public DateTime? Stalocal { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
        public string FlightStatus { get; set; }
        public DateTime? Stdday { get; set; }
        public DateTime? Staday { get; set; }
        public DateTime? Departure { get; set; }
        public DateTime? Arrival { get; set; }
        public DateTime? DepartureLocal { get; set; }
        public DateTime? ArrivalLocal { get; set; }
        public DateTime? TakeoffLocal { get; set; }
        public DateTime? LandingLocal { get; set; }
        public int? BlockTime { get; set; }
        public int? FlightTime { get; set; }
        public int? Sitatime { get; set; }
        public int? PaxChild { get; set; }
        public int? PaxInfant { get; set; }
        public int? PaxAdult { get; set; }
        public decimal? Remaining { get; set; }
        public decimal? UpLift { get; set; }
        public decimal? Used { get; set; }
        public int? TotalSeat { get; set; }
        public int BaggageWeight { get; set; }
        public int CargoWeight { get; set; }
        public int? Freight { get; set; }
        public decimal? FreightTone { get; set; }
        public int? TotalPaxAll { get; set; }
        public int? Weight { get; set; }
        public decimal? WeightTone { get; set; }
        public int? PaxWeight { get; set; }
        public decimal? PaxWeightTone { get; set; }
        public string Route { get; set; }
        public double? DistanceKm { get; set; }
        public double? Distance { get; set; }
        public double? WeightDistance { get; set; }
        public double? WeightDistanceToneKm { get; set; }
    }
}
