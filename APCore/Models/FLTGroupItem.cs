using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FltgroupItem
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public int FltgroupId { get; set; }

        public virtual FlightInformation1 Flight { get; set; }
        public virtual Fltgroup Fltgroup { get; set; }
    }
}
