using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class _CYearFlight
    {
        public int Id { get; set; }
        public int? CrewId { get; set; }
        public string Name { get; set; }
        public int? FlightId { get; set; }
        public int? BlockTime { get; set; }
        public int? FlightTime { get; set; }
        public DateTime? CDate { get; set; }
        public int? CYear { get; set; }
        public int? CMonth { get; set; }
        public int? CDay { get; set; }
    }
}
