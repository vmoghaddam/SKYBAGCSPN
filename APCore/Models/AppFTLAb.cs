using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class AppFtlab
    {
        public DateTime Cdate { get; set; }
        public int CrewId { get; set; }
        public double? Duty7 { get; set; }
        public double? Duty7Remain { get; set; }
        public double? Duty14 { get; set; }
        public double? Duty14Remain { get; set; }
        public double? Duty28 { get; set; }
        public double? Duty28Remain { get; set; }
        public double? Flight28 { get; set; }
        public double? Flight28Remain { get; set; }
        public double? FlightYear { get; set; }
        public double? FlightYearRemain { get; set; }
        public double? FlightCyear { get; set; }
        public double? FlightCyearRemain { get; set; }
        public int? Cnt { get; set; }
        public int? ScheduledFlightTime { get; set; }
        public double? Ratio { get; set; }
    }
}
