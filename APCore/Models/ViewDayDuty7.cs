using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewDayDuty7
    {
        public DateTime Date { get; set; }
        public int CrewId { get; set; }
        public double? Duration { get; set; }
        public double? DurationLocal { get; set; }
        public double? Duty7 { get; set; }
        public double? Duty7Local { get; set; }
    }
}
