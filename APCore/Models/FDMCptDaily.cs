﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FdmcptDaily
    {
        public DateTime? Day { get; set; }
        public string CptName { get; set; }
        public int CptId { get; set; }
        public string CptCode { get; set; }
        public bool? Approved { get; set; }
        public int? FlightCount { get; set; }
        public int? EventCount { get; set; }
        public int? P1EventCount { get; set; }
        public int? IpeventCount { get; set; }
        public int? HighCount { get; set; }
        public int? MediumCount { get; set; }
        public int? LowCount { get; set; }
        public int? P1highCount { get; set; }
        public int? IphighCount { get; set; }
        public int? IpmediumCount { get; set; }
        public int? P1mediumCount { get; set; }
        public int? IplowCount { get; set; }
        public int? P1lowCount { get; set; }
        public int? ForesEventsCount { get; set; }
        public int? IpresEventsCount { get; set; }
        public int? P1resEventsCount { get; set; }
        public int? IpselfResEventsCount { get; set; }
        public int? P1selfResEventsCount { get; set; }
        public int? IpotherResEventsCount { get; set; }
        public int? P1otherResEventsCount { get; set; }
    }
}
