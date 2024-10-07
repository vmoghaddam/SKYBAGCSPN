using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class Xdaily
    {
        public DateTime? Xstd { get; set; }
        public DateTime? Xsta { get; set; }
        public int? XflightH { get; set; }
        public int? XflightM { get; set; }
        public DateTime? XdateUtc { get; set; }
        public DateTime? XoffBlock { get; set; }
        public DateTime? XtakeOff { get; set; }
        public DateTime? Xlanding { get; set; }
        public DateTime? XonBlock { get; set; }
        public string XflightNumber { get; set; }
        public string Reg { get; set; }
        public int? XregisterId { get; set; }
        public int XflightStatusId { get; set; }
        public DateTime? DateUtc { get; set; }
        public string Std { get; set; }
        public string Sta { get; set; }
        public string OffBlock { get; set; }
        public string OnBlock { get; set; }
        public string TakeOff { get; set; }
        public string Landing { get; set; }
        public string Adl { get; set; }
        public string Chd { get; set; }
        public string Inf { get; set; }
        public string Bag { get; set; }
        public string Cargo { get; set; }
        public string Uplift { get; set; }
        public string Trip { get; set; }
        public string Status { get; set; }
        public string XfromAirport { get; set; }
        public int? XfromAirportId { get; set; }
        public string XtoAirport { get; set; }
        public int? XtoAirportId { get; set; }
    }
}
