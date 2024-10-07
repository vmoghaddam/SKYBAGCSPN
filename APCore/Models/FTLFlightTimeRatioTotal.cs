using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FtlflightTimeRatioTotal
    {
        public int? CrewId { get; set; }
        public int? ScheduledFlightTime { get; set; }
        public int? Cnt { get; set; }
        public decimal? Ratio { get; set; }
    }
}
