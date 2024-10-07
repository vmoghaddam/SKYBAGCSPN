using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class DutyFlight
    {
        public DateTime Cdate { get; set; }
        public DateTime? DatePart { get; set; }
        public int FdpitemId { get; set; }
        public int? Fdpid { get; set; }
        public int? BoxId { get; set; }
        public int? CrewId { get; set; }
    }
}
