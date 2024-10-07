using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class RptDelayLegMap
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public DateTime? Stdday { get; set; }
        public string Pdate { get; set; }
        public int DelayCodeId { get; set; }
        public string Code { get; set; }
        public int? Delay { get; set; }
        public string Remark { get; set; }
        public string Categoty { get; set; }
        public string CategoryIata { get; set; }
        public string MapTitle { get; set; }
        public string MapTitle2 { get; set; }
    }
}
