﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class DelayAvgByRegister
    {
        public int RegisterId { get; set; }
        public string Register { get; set; }
        public int? Avg { get; set; }
    }
}
