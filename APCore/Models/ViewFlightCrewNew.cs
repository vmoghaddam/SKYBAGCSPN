﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewFlightCrewNew
    {
        public int Fdpid { get; set; }
        public int FdpitemId { get; set; }
        public int? CrewId { get; set; }
        public int? FlightId { get; set; }
        public bool? IsPositioning { get; set; }
        public int PositionId { get; set; }
        public string Position { get; set; }
        public string Name { get; set; }
        public int? GroupId { get; set; }
        public string JobGroup { get; set; }
        public string JobGroupCode { get; set; }
        public int SexId { get; set; }
        public string Sex { get; set; }
        public int GroupOrder { get; set; }
        public string Fdptitle { get; set; }
        public int IsCockpit { get; set; }
        public string Pid { get; set; }
        public long? Rank { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
    }
}
