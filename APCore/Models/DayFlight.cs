using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class DayFlight
    {
        public DateTime Date { get; set; }
        public int CrewId { get; set; }
        public int Id { get; set; }
        public double? Fltlocal { get; set; }
        public double? Flt { get; set; }
        public double? Flt28local { get; set; }
        public double? Flt28 { get; set; }
        public double? Fltyear { get; set; }
        public double? FltyearLocal { get; set; }
        public double? Fltcyear { get; set; }
        public double? FltcyearLocal { get; set; }
        public double? Dh { get; set; }
        public double? Dhlocal { get; set; }
        public double? Dh28 { get; set; }
        public double? Dh28local { get; set; }
        public double? Dhyear { get; set; }
        public double? DhyearLocal { get; set; }
        public double? Dhcyear { get; set; }
        public double? DhcyearLocal { get; set; }
        public int? Year { get; set; }
    }
}
