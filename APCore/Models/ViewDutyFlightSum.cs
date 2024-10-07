﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewDutyFlightSum
    {
        public DateTime Cdate { get; set; }
        public DateTime? DatePart { get; set; }
        public int? CrewId { get; set; }
        public int? Duration { get; set; }
        public int? DurationLocal { get; set; }
        public int? Positioning { get; set; }
        public int? PositioningLocal { get; set; }
        public int? FlightCount { get; set; }
    }
}
