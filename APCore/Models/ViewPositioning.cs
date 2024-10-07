using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewPositioning
    {
        public int Id { get; set; }
        public int Fdpid { get; set; }
        public int? CrewId { get; set; }
        public int? FlightId { get; set; }
        public string FlightNumber { get; set; }
        public DateTime? Stdday { get; set; }
        public string FromAirportIata { get; set; }
        public string ToAirportIata { get; set; }
        public DateTime? DepartureLocal { get; set; }
        public DateTime? ArrivalLocal { get; set; }
    }
}
