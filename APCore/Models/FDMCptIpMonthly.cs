using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FdmcptIpMonthly
    {
        public int? Year { get; set; }
        public int? Month { get; set; }
        public string P1name { get; set; }
        public int? P1Id { get; set; }
        public string IpName { get; set; }
        public int? IpId { get; set; }
        public string P1code { get; set; }
        public string IpCode { get; set; }
        public int? FlightCount { get; set; }
        public int? EventCount { get; set; }
        public int? HighCount { get; set; }
        public int? MediumCount { get; set; }
        public int? LowCount { get; set; }
        public int? Score { get; set; }
    }
}
