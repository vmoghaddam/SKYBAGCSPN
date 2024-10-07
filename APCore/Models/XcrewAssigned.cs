using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class XcrewAssigned
    {
        public string Crew { get; set; }
        public string Name { get; set; }
        public string JobGroup { get; set; }
        public int? Groupid { get; set; }
        public int? CrewId { get; set; }
        public string Route { get; set; }
        public string FlightNumber { get; set; }
        public DateTime? DateUtc { get; set; }
        public int? FlightId { get; set; }
    }
}
