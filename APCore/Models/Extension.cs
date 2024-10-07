using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class Extension
    {
        public int Id { get; set; }
        public DateTime? DutyStart { get; set; }
        public DateTime? DutyEnd { get; set; }
        public int? Sectors { get; set; }
        public int? MaxFdp { get; set; }
        public TimeSpan? MaxFdph { get; set; }
    }
}
