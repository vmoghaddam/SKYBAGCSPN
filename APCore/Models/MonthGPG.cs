using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class MonthGpg
    {
        public int? Year { get; set; }
        public int? Month { get; set; }
        public string MonthName { get; set; }
        public string YearMonthName { get; set; }
    }
}
