using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewEfbvoyageReportsAll
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; }
        public DateTime? FlightDate { get; set; }
        public string AircraftType { get; set; }
        public string Register { get; set; }
        public string OriginIata { get; set; }
        public string DestinationIata { get; set; }
        public string Route { get; set; }
        public int? FlightId { get; set; }
        public int? RestReduction { get; set; }
        public int? DutyExtention { get; set; }
        public string Report { get; set; }
        public DateTime? DatePicsignature { get; set; }
        public int? ActionedById { get; set; }
        public DateTime? DateActioned { get; set; }
        public DateTime? DateConfirmed { get; set; }
        public string Name { get; set; }
        public string Pid { get; set; }
        public string Nid { get; set; }
        public string Mobile { get; set; }
    }
}
