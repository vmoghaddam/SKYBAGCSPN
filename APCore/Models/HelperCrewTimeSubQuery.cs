using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class HelperCrewTimeSubQuery
    {
        public int Id { get; set; }
        public string Pid { get; set; }
        public string Name { get; set; }
        public DateTime Cdate { get; set; }
        public int BoxId { get; set; }
        public string DateStr { get; set; }
        public int Positioning { get; set; }
        public int Day1Flight { get; set; }
        public int Day7Flight { get; set; }
        public int Day14Flight { get; set; }
        public int Day28Flight { get; set; }
        public int YearFlight { get; set; }
        public int CyearFlight { get; set; }
        public double Day1Duty { get; set; }
        public double Day7Duty { get; set; }
        public double Day14Duty { get; set; }
        public double Day28Duty { get; set; }
        public decimal YearDuty { get; set; }
    }
}
