﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APTraining.Models
{
    public partial class SumLibraryAddedByMonth
    {
        public int CustomerId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string MonthName { get; set; }
        public int? Count { get; set; }
    }
}
