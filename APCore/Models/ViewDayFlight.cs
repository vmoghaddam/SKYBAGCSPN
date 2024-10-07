using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewDayFlight
    {
        public DateTime Date { get; set; }
        public int CrewId { get; set; }
        public int? Duration { get; set; }
        public int? DurationLocal { get; set; }
        public int? Flt28 { get; set; }
        public int? Flt28local { get; set; }
        public int? Fltyear { get; set; }
        public int? Fltcyear { get; set; }
    }
}
