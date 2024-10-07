using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FdmphaseTypeMonthly
    {
        public string Phase { get; set; }
        public string Severity { get; set; }
        public int CrewId { get; set; }
        public string Name { get; set; }
        public string JobGroup { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public int? Score { get; set; }
        public int? EventsCount { get; set; }
    }
}
