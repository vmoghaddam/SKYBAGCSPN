using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class AppFuel
    {
        public int FlightId { get; set; }
        public decimal? UpLift { get; set; }
        public decimal? Remaining { get; set; }
        public decimal? UsedFuel { get; set; }
        public int Taxi { get; set; }
        public decimal? AvgfuelBurned { get; set; }
        public decimal? AvgfuelBurnedReg { get; set; }
        public decimal? AvgVar { get; set; }
        public decimal? AvgVarReg { get; set; }
        public decimal? Fpfuel { get; set; }
        public decimal? FptripFuel { get; set; }
        public decimal? FuelVariance { get; set; }
        public decimal? Fpvar { get; set; }
        public int? TotalPax { get; set; }
        public int FuelUnitId { get; set; }
        public string FuelUnit { get; set; }
        public int BaggageWeight { get; set; }
        public int CargoWeight { get; set; }
        public int? Freight { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
        public DateTime? BlockOn { get; set; }
        public DateTime? BlockOff { get; set; }
        public DateTime? TakeOff { get; set; }
        public DateTime? Landing { get; set; }
        public DateTime? FlightDate { get; set; }
        public string FlightNumber { get; set; }
        public int? RegisterId { get; set; }
        public string Register { get; set; }
        public int? TypeId { get; set; }
        public string AircraftType { get; set; }
        public int? FromAirportId { get; set; }
        public int? ToAirportId { get; set; }
        public string FromAirport { get; set; }
        public string ToAirport { get; set; }
        public string FromAirportIata { get; set; }
        public string ToAirportIata { get; set; }
        public string FlightStatus { get; set; }
        public int? FlightStatusId { get; set; }
        public DateTime? Stdday { get; set; }
        public DateTime? Staday { get; set; }
        public int? DelayBlockOff { get; set; }
        public int? BlockTime { get; set; }
        public int? FlightTime { get; set; }
        public decimal? FuelDensity { get; set; }
        public decimal? Cargo { get; set; }
        public string Pf { get; set; }
        public string Pic { get; set; }
        public int? Picid { get; set; }
        public string Sic { get; set; }
        public int? Sicid { get; set; }
        public string Alt1 { get; set; }
        public string Alt2 { get; set; }
        public string Alt3 { get; set; }
        public string Ipname { get; set; }
        public int? Ipid { get; set; }
        public string IpscheduleName { get; set; }
        public string P1name { get; set; }
        public int? P1id { get; set; }
        public string P1scheduleName { get; set; }
        public string P2name { get; set; }
        public int? P2id { get; set; }
        public string P2scheduleName { get; set; }
    }
}
