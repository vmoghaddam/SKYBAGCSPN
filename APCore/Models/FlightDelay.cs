using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FlightDelay
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public int DelayCodeId { get; set; }
        public int? Hh { get; set; }
        public int? Mm { get; set; }
        public string Remark { get; set; }
        public int? UserId { get; set; }
        public string Icategory { get; set; }

        public virtual DelayCode DelayCode { get; set; }
        public virtual FlightInformation1 Flight { get; set; }
    }
}
