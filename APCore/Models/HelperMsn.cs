using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class HelperMsn
    {
        public int Id { get; set; }
        public int? AcModelId { get; set; }
        public int? TypeId { get; set; }
        public string Type { get; set; }
        public int? TotalSeat { get; set; }
        public int? Msn { get; set; }
        public string Register { get; set; }
        public int? MaxWeightTo { get; set; }
        public int? MaxWeightLnd { get; set; }
        public string MaxWeighUnit { get; set; }
    }
}
