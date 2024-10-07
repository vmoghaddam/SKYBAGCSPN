using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class Cyear
    {
        public int Id { get; set; }
        public int? CrewId { get; set; }
        public int? Cyear1 { get; set; }
        public string CyearStr { get; set; }
    }
}
