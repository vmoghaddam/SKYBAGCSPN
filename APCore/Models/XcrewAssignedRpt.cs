using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class XcrewAssignedRpt
    {
        public string Sch { get; set; }
        public string Code { get; set; }
        public string Pdate { get; set; }
        public DateTime? Date { get; set; }
        public string Fn { get; set; }
        public int? FlightId { get; set; }
        public int? CrewId2 { get; set; }
        public string Name { get; set; }
        public string JobGroup { get; set; }
        public int? Groupid { get; set; }
    }
}
