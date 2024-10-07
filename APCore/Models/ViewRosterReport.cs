using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewRosterReport
    {
        public int Id { get; set; }
        public DateTime? DateLocal { get; set; }
        public string FltNo { get; set; }
        public string Route { get; set; }
        public DateTime? Stdlocal { get; set; }
        public DateTime? Stalocal { get; set; }
        public string Register { get; set; }
        public string AircraftType { get; set; }
        public string Ip { get; set; }
        public string Obs { get; set; }
        public string P1 { get; set; }
        public string P2 { get; set; }
        public string Safety { get; set; }
        public string Sccm { get; set; }
        public string Ccm1 { get; set; }
        public string Ccm2 { get; set; }
        public string Ccm3 { get; set; }
    }
}
