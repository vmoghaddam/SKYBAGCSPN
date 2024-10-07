using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FdmfoMonthly
    {
        public int? Month { get; set; }
        public int? Year { get; set; }
        public string P2name { get; set; }
        public int? P2id { get; set; }
        public string P2code { get; set; }
        public int? FlightCount { get; set; }
        public int? EventCount { get; set; }
        public int? HighCount { get; set; }
        public int? MediumCount { get; set; }
        public int? LowCount { get; set; }
        public int? Score { get; set; }
        public int? ScoresPerFlight { get; set; }
    }
}
