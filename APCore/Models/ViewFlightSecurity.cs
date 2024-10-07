using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewFlightSecurity
    {
        public int Id { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
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
        public DateTime? Arrival { get; set; }
        public DateTime? DepartureLocal { get; set; }
        public DateTime? ArrivalLocal { get; set; }
        public DateTime? Departure { get; set; }
        public DateTime? Stdday { get; set; }
        public string Cpt { get; set; }
        public string Cpt2 { get; set; }
        public string Obsp1 { get; set; }
        public string Ip { get; set; }
        public string Ip2 { get; set; }
        public string Safety { get; set; }
        public string Fo { get; set; }
        public string Fo2 { get; set; }
        public string Obsp2 { get; set; }
        public string Isccm { get; set; }
        public string Purser { get; set; }
        public string Purser2 { get; set; }
        public string Purser3 { get; set; }
        public string Fa1 { get; set; }
        public string Fa2 { get; set; }
        public string Fa3 { get; set; }
        public string Fa4 { get; set; }
        public string Caobs1 { get; set; }
        public string Caobs2 { get; set; }
        public string Caobs3 { get; set; }
        public string Caobs4 { get; set; }
        public string Cacheck1 { get; set; }
        public string Cacheck2 { get; set; }
        public string Cacheck3 { get; set; }
        public string Cacheck4 { get; set; }
    }
}
