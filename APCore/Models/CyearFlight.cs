using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class CyearFlight
    {
        public int Id { get; set; }
        public int? CrewId { get; set; }
        public string Name { get; set; }
        public int? FlightId { get; set; }
        public int? BlockTime { get; set; }
        public int? FlightTime { get; set; }
        public DateTime? Cdate { get; set; }
        public int? Cyear { get; set; }
        public int? Cmonth { get; set; }
        public int? Cday { get; set; }
    }
}
