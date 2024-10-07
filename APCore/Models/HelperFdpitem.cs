﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class HelperFdpitem
    {
        public int Id { get; set; }
        public int Fdpid { get; set; }
        public int? FlightId { get; set; }
        public bool IsSector { get; set; }
        public int? SplitDutyPairId { get; set; }
        public bool? SplitDuty { get; set; }
        public bool? IsPositioning { get; set; }
        public bool? IsOff { get; set; }
        public int? PositionId { get; set; }
        public int? RosterPositionId { get; set; }
        public DateTime? Pickup { get; set; }
        public string Remark { get; set; }
        public int CrewId { get; set; }
        public string ScheduleName { get; set; }
        public string Name { get; set; }
    }
}
