using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FdmregCptDaily
    {
        public DateTime? Day { get; set; }
        public string Register { get; set; }
        public int? RegisterId { get; set; }
        public string CptName { get; set; }
        public int CptId { get; set; }
        public string CptCode { get; set; }
        public int? FlightCount { get; set; }
        public int? EventCount { get; set; }
        public int? HighCount { get; set; }
        public int? MediumCount { get; set; }
        public int? LowCount { get; set; }
        public int? Score { get; set; }
    }
}
