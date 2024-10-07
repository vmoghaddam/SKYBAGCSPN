using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewFlightGroupItem
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public int FltgroupId { get; set; }
        public string FlightNumber { get; set; }
        public string Register { get; set; }
        public int? RegisterId { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
        public DateTime? Stdlocal { get; set; }
        public DateTime? Stalocal { get; set; }
        public DateTime? Stdday { get; set; }
        public long? Rank { get; set; }
        public long? RankDesc { get; set; }
    }
}
