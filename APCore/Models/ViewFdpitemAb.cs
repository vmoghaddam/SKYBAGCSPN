using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewFdpitemAb
    {
        public int Id { get; set; }
        public int Fdpid { get; set; }
        public int? FlightId { get; set; }
        public bool? IsSector { get; set; }
        public bool? IsOff { get; set; }
        public bool? IsPositioning { get; set; }
        public int? FlightStatusId { get; set; }
    }
}
