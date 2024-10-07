using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FdmcptAll
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public string CptCode { get; set; }
        public int CptId { get; set; }
        public string CptName { get; set; }
        public string JobGroup { get; set; }
        public int? FlightCount { get; set; }
        public int? EventCount { get; set; }
        public int? HighCount { get; set; }
        public int? MediumCount { get; set; }
        public int? Score { get; set; }
        public int? LowCount { get; set; }
    }
}
