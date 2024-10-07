﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FdmeventDaily
    {
        public DateTime FlightDate { get; set; }
        public string EventName { get; set; }
        public int? EventCount { get; set; }
        public int? HighCount { get; set; }
        public int? MediumCount { get; set; }
        public int? LowCount { get; set; }
    }
}