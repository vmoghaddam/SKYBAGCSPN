using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class RptReposition
    {
        public int Fdpid { get; set; }
        public int? CrewId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JobGroup { get; set; }
        public string JobGroupCode { get; set; }
        public DateTime? DateFdp { get; set; }
        public string Flights { get; set; }
        public string Route { get; set; }
        public int Pos1 { get; set; }
        public int Pos2 { get; set; }
        public int? Pos { get; set; }
        public int? PosFixTime { get; set; }
        public int? Pyear { get; set; }
        public string PmonthName { get; set; }
        public int? Pmonth { get; set; }
        public string Pdate { get; set; }
        public string PeriodFixTime { get; set; }
    }
}
