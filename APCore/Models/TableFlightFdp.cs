using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class TableFlightFdp
    {
        public DateTime Cdate { get; set; }
        public int? CrewId { get; set; }
        public double? Duration { get; set; }
        public double? DurationLocal { get; set; }
        public int FdpitemId { get; set; }
        public DateTime? DutyStart { get; set; }
        public DateTime? DutyEnd { get; set; }
        public DateTime? DutyStartLocal { get; set; }
        public DateTime? DutyEndLocal { get; set; }
        public Guid? Guid { get; set; }
        public int? FlightId { get; set; }
    }
}
