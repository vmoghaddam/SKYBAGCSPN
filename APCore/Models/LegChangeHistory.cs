﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class LegChangeHistory
    {
        public string ChangeTime { get; set; }
        public string DateUTC { get; set; }
        public string FltNo { get; set; }
        public string DepStn { get; set; }
        public string ArrStn { get; set; }
        public string ChangeUser { get; set; }
        public string ChangeType { get; set; }
        public string DepTime { get; set; }
        public string ArrTime { get; set; }
        public string DepTimeLCL { get; set; }
        public string ArrTimeLCL { get; set; }
        public string STD { get; set; }
        public string STA { get; set; }
        public string STC { get; set; }
        public string ACType { get; set; }
        public string ACReg { get; set; }
        public string Flt { get; set; }
        public string ScheduleGroup { get; set; }
        public string LegDesc { get; set; }
        public int? Id { get; set; }
        public DateTime? Date2 { get; set; }
    }
}
