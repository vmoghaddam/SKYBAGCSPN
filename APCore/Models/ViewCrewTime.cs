using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewCrewTime
    {
        public int Id { get; set; }
        public string Pid { get; set; }
        public string Name { get; set; }
        public DateTime? Cdate { get; set; }
        public int BoxId { get; set; }
        public string DateStr { get; set; }
        public int Positioning { get; set; }
        public int? Day1Flight { get; set; }
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
        public int CalendarStatusId { get; set; }
        public string CalendarStatus { get; set; }
        public int EcsplitedId { get; set; }
        public int Ecid { get; set; }
        public DateTime EcdateStartLocal { get; set; }
        public DateTime EcdateEndLocal { get; set; }
        public DateTime EcdateStart { get; set; }
        public DateTime EcdateEnd { get; set; }
        public int? Ecduty { get; set; }
        public int EcboxId { get; set; }
        public decimal Fdpreduction { get; set; }
        public int ErrorDay28Flight { get; set; }
        public int ErrorYearFlight { get; set; }
        public int ErrorCyearFlight { get; set; }
        public int ErrorDay7Duty { get; set; }
        public int ErrorDay14Duty { get; set; }
        public int ErrorDay28Duty { get; set; }
    }
}
