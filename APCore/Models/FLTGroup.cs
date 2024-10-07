using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class Fltgroup
    {
        public Fltgroup()
        {
            FltgroupItems = new HashSet<FltgroupItem>();
        }

        public int Id { get; set; }
        public DateTime Cdate { get; set; }
        public string Remark { get; set; }
        public int? FirstFlightId { get; set; }
        public int? LastFlightId { get; set; }

        public virtual ICollection<FltgroupItem> FltgroupItems { get; set; }
    }
}
