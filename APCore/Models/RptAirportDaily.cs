using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class RptAirportDaily
    {
        public int Id { get; set; }
        public string Airline { get; set; }
        public string FlightNumber { get; set; }
        public string Register { get; set; }
        public string Pdate { get; set; }
        public DateTime? Stdday { get; set; }
        public DateTime? Stdlocal { get; set; }
        public DateTime? Stalocal { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
        public string FromAirportIata { get; set; }
        public string ToAirportIata { get; set; }
        public string PdateTakeOff { get; set; }
        public DateTime? TakeOff { get; set; }
        public DateTime? TakeOffLocal { get; set; }
        public DateTime? OffBlock { get; set; }
        public DateTime? OffBlockLocal { get; set; }
        public string PdateOffBlock { get; set; }
        public int? PaxChild { get; set; }
        public int? PaxInfant { get; set; }
        public int? PaxAdult { get; set; }
        public int? Freight { get; set; }
        public decimal? Uplift { get; set; }
        public decimal? UsedFuel { get; set; }
        public string Delays { get; set; }
    }
}
