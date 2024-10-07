using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class TableBlockTime
    {
        public int Id { get; set; }
        public int? CrewId { get; set; }
        public double? BlockTime { get; set; }
        public DateTime? Cdate { get; set; }
        public int? Fdpid { get; set; }

        public virtual Fdp Fdp { get; set; }
    }
}
