using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FtlflightTime
    {
        public int FlightId { get; set; }
        public DateTime? Stdday { get; set; }
        public int FdpitemId { get; set; }
        public int Fdpid { get; set; }
        public int? ScheduledFlightTime { get; set; }
    }
}
