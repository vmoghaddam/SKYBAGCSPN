using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FdmcptAnnually
    {
        public int? Year { get; set; }
        public string CptName { get; set; }
        public int CptId { get; set; }
        public string CptCode { get; set; }
        public int? FlightCount { get; set; }
        public int? IncidentCount { get; set; }
        public bool? Approved { get; set; }
        public int? HighCount { get; set; }
        public int? MediumCount { get; set; }
        public int? LowCount { get; set; }
        public int? Score { get; set; }
        public int? FaultPercentagePerFlight { get; set; }
    }
}
