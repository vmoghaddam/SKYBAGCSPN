using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ReportRoster
    {
        public int Id { get; set; }
        public string DayName { get; set; }
        public DateTime? Stdday { get; set; }
        public string Pdate { get; set; }
        public string FlightNumber { get; set; }
        public string Register { get; set; }
        public string Route { get; set; }
        public string Std { get; set; }
        public string Sta { get; set; }
        public string Stdloc { get; set; }
        public string Staloc { get; set; }
        public DateTime? Stdlocal { get; set; }
        public DateTime? Stalocal { get; set; }
        public DateTime? Stdx { get; set; }
        public DateTime? Stax { get; set; }
        public string FromAirportIata { get; set; }
        public string ToAirportIata { get; set; }
        public string Ip { get; set; }
        public string Cpt { get; set; }
        public string Fo { get; set; }
        public string Safety { get; set; }
        public string Check { get; set; }
        public string Obs { get; set; }
        public string Isccm { get; set; }
        public string Sccm { get; set; }
        public string Ccm { get; set; }
        public string Checkc { get; set; }
        public string Obsc { get; set; }
        public string Fm { get; set; }
        public string Positioning { get; set; }
        public string Positioningcockpit { get; set; }
        public string Positioningcabin { get; set; }
    }
}
