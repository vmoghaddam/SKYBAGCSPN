using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewFdrreport
    {
        public int Id { get; set; }
        public DateTime? Stdday { get; set; }
        public string FlightNumber { get; set; }
        public string Register { get; set; }
        public int? RegisterId { get; set; }
        public string AircraftType { get; set; }
        public int? TypeId { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Stdlocal { get; set; }
        public DateTime? Sta { get; set; }
        public DateTime? Stalocal { get; set; }
        public DateTime? Takeoff { get; set; }
        public DateTime? Landing { get; set; }
        public DateTime? TakeoffLocal { get; set; }
        public DateTime? LandingLocal { get; set; }
        public string Ip { get; set; }
        public string Ipsch { get; set; }
        public string Ipcode { get; set; }
        public int? Ipid { get; set; }
        public string P1 { get; set; }
        public string P1sch { get; set; }
        public string P1code { get; set; }
        public int? P1id { get; set; }
        public string P2 { get; set; }
        public string P2sch { get; set; }
        public string P2code { get; set; }
        public int? P2id { get; set; }
        public string FlightStatus { get; set; }
        public int? FlightStatusId { get; set; }
        public string FromAirportIata { get; set; }
        public string ToAirportIata { get; set; }
        public int? FromAirport { get; set; }
        public int? ToAirport { get; set; }
        public decimal? FuelRemaining { get; set; }
        public decimal? FuelUplift { get; set; }
        public decimal? FuelUsed { get; set; }
        public int? FuelUnitId { get; set; }
        public string FuelUnit { get; set; }
        public int? Pflr { get; set; }
        public decimal? Fpfuel { get; set; }
        public string Pflrtitle { get; set; }
        public DateTime? DepartureLocal { get; set; }
        public DateTime? ArrivalLocal { get; set; }
        public DateTime? Departure { get; set; }
        public DateTime? Arrival { get; set; }
        public int? BlockTime { get; set; }
        public int? FlightTime { get; set; }
        public int? Freight { get; set; }
        public decimal? FptripFuel { get; set; }
        public int? MaxWeightTo { get; set; }
        public int? MaxWeightLnd { get; set; }
        public string MaxWeighUnit { get; set; }
    }
}
