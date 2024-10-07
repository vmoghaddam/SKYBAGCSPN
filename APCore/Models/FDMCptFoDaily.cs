using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FdmcptFoDaily
    {
        public DateTime? Day { get; set; }
        public string P1name { get; set; }
        public int P1id { get; set; }
        public string P2name { get; set; }
        public int? P2id { get; set; }
        public int? Ipid { get; set; }
        public string Ipname { get; set; }
        public string P1code { get; set; }
        public string P2code { get; set; }
        public string IpCode { get; set; }
        public int? FlightCount { get; set; }
        public int? EventCount { get; set; }
        public int? HighCount { get; set; }
        public int? MediumCount { get; set; }
        public int? LowCount { get; set; }
        public int? Score { get; set; }
    }
}
