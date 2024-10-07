using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewFlightFuel
    {
        public int FlightId { get; set; }
        public decimal? UpLift { get; set; }
        public decimal? Remaining { get; set; }
        public decimal? UsedFuel { get; set; }
        public decimal? Taxi { get; set; }
        public decimal? AvgfuelBurned { get; set; }
        public decimal? AvgfuelBurnedReg { get; set; }
        public decimal? AvgVar { get; set; }
        public decimal? AvgVarReg { get; set; }
        public decimal? Fpfuel { get; set; }
        public decimal? Fpvar { get; set; }
        public int? TotalPax { get; set; }
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
        public DateTime? Departure { get; set; }
        public DateTime? Arrival { get; set; }
        public DateTime? DepartureLocal { get; set; }
        public DateTime? ArrivalLocal { get; set; }
        public DateTime? Date { get; set; }
        public int? FlightStatusId { get; set; }
        public int? RegisterId { get; set; }
        public string FlightNumber { get; set; }
        public int? FromAirport { get; set; }
        public int? ToAirport { get; set; }
        public string FromAirportIata { get; set; }
        public string ToAirportIata { get; set; }
        public string RouteIata { get; set; }
        public int? TypeId { get; set; }
        public string AircraftType { get; set; }
        public string Register { get; set; }
        public string FuelUnit { get; set; }
        public int? FuelUnitId { get; set; }
        public int? TotalSeat { get; set; }
        public DateTime? Stdday { get; set; }
        public DateTime? Staday { get; set; }
        public int CargoWeight { get; set; }
        public string CargoUnit { get; set; }
        public int? BaggageCount { get; set; }
        public int? CargoUnitId { get; set; }
        public int BaggageWeight { get; set; }
        public int? CargoCount { get; set; }
        public int? TotalCargoWeight { get; set; }
        public string Captain { get; set; }
        public string CaptainName { get; set; }
        public int CaptainId { get; set; }
        public int? DurationScheduled { get; set; }
        public int? DurationActual { get; set; }
        public int? FlightTimeFp { get; set; }
        public int? FlightActual { get; set; }
        public string DurationScheduledStr { get; set; }
        public string DurationActualStr { get; set; }
        public string FlightTimeFpstr { get; set; }
        public string FlightActualStr { get; set; }
    }
}
