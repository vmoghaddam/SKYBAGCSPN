using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class EfbflightIrregularity
    {
        public int Id { get; set; }
        public int? VoyageReportId { get; set; }
        public int? IrrId { get; set; }

        public virtual EfbvoyageReport VoyageReport { get; set; }
    }
}
