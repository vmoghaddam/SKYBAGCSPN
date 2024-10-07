using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class DlyGrpAirportDaily
    {
        public int? Pyear { get; set; }
        public string PmonthName { get; set; }
        public int? Pmonth { get; set; }
        public string PdayName { get; set; }
        public string Pdate { get; set; }
        public int? Pday { get; set; }
        public int? FromAirport { get; set; }
        public string FromAirportIata { get; set; }
        public int? Delay { get; set; }
        public int? DelayUnder30 { get; set; }
        public int? DelayOver30 { get; set; }
        public int? Delay3060 { get; set; }
        public int? Delay60120 { get; set; }
        public int? Delay120180 { get; set; }
        public int? DelayOver180 { get; set; }
        public int? DelayOver240 { get; set; }
    }
}
