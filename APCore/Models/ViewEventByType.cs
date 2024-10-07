using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewEventByType
    {
        public int? TypeId { get; set; }
        public string Type { get; set; }
        public int? HighLevel { get; set; }
        public int? MediumLevel { get; set; }
        public int? LowLevel { get; set; }
        public int? FlightCount { get; set; }
    }
}
