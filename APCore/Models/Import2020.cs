using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class Import2020
    {
        public string Date { get; set; }
        public string Flightno { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Register { get; set; }
        public string Status { get; set; }
        public string Adult { get; set; }
        public string Child { get; set; }
        public string Infant { get; set; }
        public string Total { get; set; }
        public string Bag { get; set; }
        public string Cargo { get; set; }
        public string Std { get; set; }
        public string Sta { get; set; }
        public string Takeoff { get; set; }
        public string Landing { get; set; }
        public string Offblock { get; set; }
        public string Onblock { get; set; }
        public string Uplift { get; set; }
        public string Used { get; set; }
        public int? Statusid { get; set; }
        public int? Registerid { get; set; }
        public int? Fromid { get; set; }
        public int? Toid { get; set; }
    }
}
