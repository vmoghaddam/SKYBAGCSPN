using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewDutyFdp
    {
        public DateTime Cdate { get; set; }
        public DateTime? DatePart { get; set; }
        public int Fdpid { get; set; }
        public int? CrewId { get; set; }
        public DateTime? DutyStart { get; set; }
        public DateTime? DutyEnd { get; set; }
        public DateTime? DutyStartLocal { get; set; }
        public DateTime? DutyEndLocal { get; set; }
        public double? Duration { get; set; }
        public double? DurationLocal { get; set; }
    }
}
