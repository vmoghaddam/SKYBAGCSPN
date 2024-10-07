using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class TableCrewTime
    {
        public int Id { get; set; }
        public double? Day1Flight { get; set; }
        public double? Day7Flight { get; set; }
        public double? Day14Flight { get; set; }
        public double? Day28Flight { get; set; }
        public double? YearFlight { get; set; }
        public double? CyearFlight { get; set; }
        public double? Day1Duty { get; set; }
        public double? Day14Duty { get; set; }
        public double? Day28Duty { get; set; }
        public DateTime Cdate { get; set; }
        public double? Day7Duty { get; set; }
    }
}
