﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewFlightCrewNewXtime
    {
        public int Fdpid { get; set; }
        public int FdpitemId { get; set; }
        public int? CrewId { get; set; }
        public int? FlightId { get; set; }
        public bool? IsPositioning { get; set; }
        public string Name { get; set; }
        public string ScheduleName { get; set; }
        public int? GroupId { get; set; }
        public string JobGroup { get; set; }
        public string JobGroupCode { get; set; }
        public int SexId { get; set; }
        public int GroupOrder { get; set; }
        public int IsCockpit { get; set; }
        public int? BlockTime { get; set; }
        public int? FlightTime { get; set; }
        public int? FlightTimeActual { get; set; }
        public int? FixTime { get; set; }
        public int? Sitatime { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Stdday { get; set; }
        public int? FlightStatusId { get; set; }
    }
}
