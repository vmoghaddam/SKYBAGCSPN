﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewDelayCategoryGrouped
    {
        public DateTime? Stdday { get; set; }
        public string MonthName { get; set; }
        public string DayName { get; set; }
        public string YearName { get; set; }
        public string Pdate { get; set; }
        public string PyearName { get; set; }
        public string PmonthName { get; set; }
        public string PdayName { get; set; }
        public string Category { get; set; }
        public int? Delay { get; set; }
        public int? Count { get; set; }
    }
}
