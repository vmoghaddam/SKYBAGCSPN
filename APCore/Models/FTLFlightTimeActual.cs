using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FtlflightTimeActual
    {
        public int FlightId { get; set; }
        public DateTime? Stdday { get; set; }
        public int? CrewId { get; set; }
        public int FdpitemId { get; set; }
        public int Fdpid { get; set; }
        public int? ScheduledFlightTime { get; set; }
        public int? FlightTime { get; set; }
    }
}
