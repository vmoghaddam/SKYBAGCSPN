using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FdmtypeDaily
    {
        public DateTime? FlightDate { get; set; }
        public int AircraftTypeId { get; set; }
        public string AircraftType { get; set; }
        public int? EventCount { get; set; }
        public int? Flightcount { get; set; }
        public int? HighCount { get; set; }
        public int? MediumCount { get; set; }
        public int? LowCount { get; set; }
    }
}
