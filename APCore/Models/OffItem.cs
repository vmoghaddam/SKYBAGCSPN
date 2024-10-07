using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class OffItem
    {
        public int Fdpid { get; set; }
        public int FlightId { get; set; }
        public string Remark { get; set; }

        public virtual Fdp Fdp { get; set; }
        public virtual FlightInformation1 Flight { get; set; }
    }
}
