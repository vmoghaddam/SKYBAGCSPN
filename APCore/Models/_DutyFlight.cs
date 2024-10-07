using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class _DutyFlight
    {
        public DateTime CDate { get; set; }
        public DateTime? DatePart { get; set; }
        public int FDPItemId { get; set; }
        public int? FDPId { get; set; }
        public int? BoxId { get; set; }
        public int? CrewId { get; set; }
    }
}
