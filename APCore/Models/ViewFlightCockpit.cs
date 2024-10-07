using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewFlightCockpit
    {
        public int Id { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
        public DateTime? Departure { get; set; }
        public DateTime? Arrival { get; set; }
        public DateTime? Stdlocal { get; set; }
        public DateTime? Stalocal { get; set; }
        public DateTime? DepartureLocal { get; set; }
        public DateTime? ArrivalLocal { get; set; }
        public int? RegisterId { get; set; }
        public int? FlightTypeId { get; set; }
        public string FlightType { get; set; }
        public int? TypeId { get; set; }
        public string FlightNumber { get; set; }
        public int? FromAirport { get; set; }
        public int? ToAirport { get; set; }
        public int? CustomerId { get; set; }
        public string Customer { get; set; }
        public string FromAirportIata { get; set; }
        public string ToAirportIata { get; set; }
        public string Register { get; set; }
        public string AircraftType { get; set; }
        public int PaxAdult { get; set; }
        public int PaxChild { get; set; }
        public int PaxInfant { get; set; }
        public int? TotalPax { get; set; }
        public decimal? FuelDeparture { get; set; }
        public int? CargoCount { get; set; }
        public int CargoWeight { get; set; }
        public int BaggageWeight { get; set; }
        public int? BaggageCount { get; set; }
        public DateTime? Stdday { get; set; }
        public string Pdate { get; set; }
        public int? FlightTime { get; set; }
        public int? FlightTimeActual { get; set; }
        public int? Sitatime { get; set; }
        public int? BlockTime { get; set; }
        public double? ActualFlightTimeToSita { get; set; }
        public string Ip { get; set; }
        public string Captain { get; set; }
        public string Ipname { get; set; }
        public string CaptainName { get; set; }
        public int Ipid { get; set; }
        public int CaptainId { get; set; }
        public int FlightStatusId { get; set; }
        public string FlightStatus { get; set; }
        public DateTime? JloffBlock { get; set; }
        public DateTime? JlonBlock { get; set; }
        public DateTime? JltakeOff { get; set; }
        public DateTime? Jllanding { get; set; }
        public int? Pflr { get; set; }
        public int? JlblockTime { get; set; }
        public int? JlflightTime { get; set; }
    }
}
