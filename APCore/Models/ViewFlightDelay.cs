using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewFlightDelay
    {
        public int Id { get; set; }
        public DateTime? Stdday { get; set; }
        public string MonthName { get; set; }
        public string DayName { get; set; }
        public string YearName { get; set; }
        public string PyearMonth { get; set; }
        public string Pdate { get; set; }
        public string PyearName { get; set; }
        public string PdayName { get; set; }
        public string PmonthName { get; set; }
        public int? Pyear { get; set; }
        public int? Pmonth { get; set; }
        public int? Pday { get; set; }
        public int FlightId { get; set; }
        public int DelayCodeId { get; set; }
        public int? DelayHh { get; set; }
        public int? DelayMm { get; set; }
        public int? Delay { get; set; }
        public string Remark { get; set; }
        public string Icategory { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public int DelayCategoryId { get; set; }
        public string DelayRemark { get; set; }
        public int? FlightH { get; set; }
        public byte? FlightM { get; set; }
        public DateTime? ChocksIn { get; set; }
        public DateTime? Landing { get; set; }
        public DateTime? Takeoff { get; set; }
        public DateTime? ChocksOut { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
        public DateTime? Date { get; set; }
        public int? FlightStatusId { get; set; }
        public int? RegisterId { get; set; }
        public int? FlightTypeId { get; set; }
        public string FlightType { get; set; }
        public string FlightTypeAbr { get; set; }
        public int? TypeId { get; set; }
        public string FlightNumber { get; set; }
        public int? FromAirport { get; set; }
        public int? ToAirport { get; set; }
        public int? CustomerId { get; set; }
        public string FromAirportName { get; set; }
        public string FromAirportIata { get; set; }
        public int FromAirportCityId { get; set; }
        public string ToAirportName { get; set; }
        public string ToAirportIata { get; set; }
        public int? ToAirportCityId { get; set; }
        public string FromAirportCity { get; set; }
        public string ToAirportCity { get; set; }
        public string AircraftType { get; set; }
        public string Register { get; set; }
        public string FlightStatus { get; set; }
        public decimal? Duration { get; set; }
        public int? DelayOffBlock { get; set; }
        public int? DelayTakeoff { get; set; }
        public int? DelayOnBlock { get; set; }
        public int? DelayLanding { get; set; }
        public int ActualFlightHoffBlock { get; set; }
        public decimal ActualFlightMoffBlock { get; set; }
        public int ActualFlightHtakeoff { get; set; }
        public decimal ActualFlightMtakeoff { get; set; }
        public int BaseId { get; set; }
        public string BaseIata { get; set; }
        public string BaseName { get; set; }
        public string Route { get; set; }
        public int PassedDay { get; set; }
        public int PassedWeek { get; set; }
        public int PassedMonth { get; set; }
        public int PassedYear { get; set; }
        public int DayOfWeek { get; set; }
        public int WeekOfMonth { get; set; }
        public int MonthOfYear { get; set; }
        public DateTime? Stdlocal { get; set; }
        public DateTime? Stalocal { get; set; }
        public DateTime? DepartureLocal { get; set; }
        public DateTime? ArrivalLocal { get; set; }
        public int? BlockTime { get; set; }
        public int? FlightTime { get; set; }
        public DateTime? TakeOffLocal { get; set; }
        public DateTime? LandingLocal { get; set; }
        public string MapTitle { get; set; }
        public string MapTitle2 { get; set; }
    }
}
