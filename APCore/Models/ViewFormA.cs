using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewFormA
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
        public decimal? FlightHour { get; set; }
        public int? FlightMinutes { get; set; }
        public string FlightStatus { get; set; }
        public int? FlightStatusId { get; set; }
        public string FromAirportIata { get; set; }
        public string ToAirportIata { get; set; }
        public string Route { get; set; }
        public int? FromAirport { get; set; }
        public int? ToAirport { get; set; }
        public int PaxChild { get; set; }
        public int PaxInfant { get; set; }
        public int PaxAdult { get; set; }
        public int? PaxTotal { get; set; }
        public double? PaxTotalDistRound { get; set; }
        public double? PaxTotalDist { get; set; }
        public int? PaxAll { get; set; }
        public int TotalSeat { get; set; }
        public double? TotalSeatDist { get; set; }
        public int? PaxLoad { get; set; }
        public double? TotalSeatDistRound { get; set; }
        public int? PaxAllWeight { get; set; }
        public double? PaxAllWeightDistance { get; set; }
        public string DayName { get; set; }
        public string YearName { get; set; }
        public int? Year { get; set; }
        public string MonthName { get; set; }
        public int? Month { get; set; }
        public string YearMonthName { get; set; }
        public string Pdate { get; set; }
        public string PyearName { get; set; }
        public int? Pyear { get; set; }
        public string PmonthName { get; set; }
        public int? Pmonth { get; set; }
        public string PdayName { get; set; }
        public string PyearMonthName { get; set; }
        public int? Quarter { get; set; }
        public int BaggageWeight { get; set; }
        public int CargoWeight { get; set; }
        public int? Freight { get; set; }
        public decimal? FreightTone { get; set; }
        public double? FreightToneDistance { get; set; }
        public double? Mail { get; set; }
        public double? TotalToneDistance { get; set; }
        public double? TotalToneDistanceAvailable { get; set; }
        public double? WeightLoadFactor { get; set; }
        public double? Distance { get; set; }
        public int IsDom { get; set; }
    }
}
