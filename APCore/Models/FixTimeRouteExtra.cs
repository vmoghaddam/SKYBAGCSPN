using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FixTimeRouteExtra
    {
        public int Id { get; set; }
        public string Route { get; set; }
        public TimeSpan? FixTime2 { get; set; }
    }
}
