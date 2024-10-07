using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewDutyFdpsumCom
    {
        public DateTime Cdate { get; set; }
        public DateTime? DatePart { get; set; }
        public int? CrewId { get; set; }
        public double? Duration { get; set; }
        public double? DurationLocal { get; set; }
        public int? Fdpcount { get; set; }
        public double? Day7Duty { get; set; }
        public double? Day14Duty { get; set; }
        public double? Day28Duty { get; set; }
    }
}
