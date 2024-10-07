using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class RptFlight
    {
        public string Pdate { get; set; }
        public int? Pyear { get; set; }
        public string PmonthName { get; set; }
        public int? Pmonth { get; set; }
        public string PdayName { get; set; }
        public int? Pday { get; set; }
        public int Id { get; set; }
        public int FlightId { get; set; }
        public int? RegisterId { get; set; }
        public int? FlightStatusId { get; set; }
        public string AircraftType { get; set; }
        public int? TypeId { get; set; }
        public string FlightNumber { get; set; }
        public int? FromAirport { get; set; }
        public int? ToAirport { get; set; }
        public int? CustomerId { get; set; }
        public string FromAirportIata { get; set; }
        public string ToAirportIata { get; set; }
        public string Register { get; set; }
        public string FlightStatus { get; set; }
        public DateTime? Stdday { get; set; }
        public DateTime? Staday { get; set; }
        public int? BlockTime { get; set; }
        public int? PaxAdult { get; set; }
        public int? PaxInfant { get; set; }
        public int? PaxChild { get; set; }
        public int? FlightTime { get; set; }
        public int? TotalPax { get; set; }
        public int? TotalPaxAll { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
        public DateTime? Stdlocal { get; set; }
        public DateTime? Stalocal { get; set; }
    }
}
