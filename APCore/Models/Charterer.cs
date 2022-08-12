﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class Charterer
    {
        public Charterer()
        {
            FlightCharterers = new HashSet<FlightCharterer>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Title1 { get; set; }
        public string Remark { get; set; }
        public string NiraCode { get; set; }
        public string Title2 { get; set; }

        public virtual ICollection<FlightCharterer> FlightCharterers { get; set; }
    }
}
