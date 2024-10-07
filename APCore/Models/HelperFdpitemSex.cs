using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class HelperFdpitemSex
    {
        public int Id { get; set; }
        public int Fdpid { get; set; }
        public int? CrewId { get; set; }
        public int SexId { get; set; }
        public string Sex { get; set; }
        public int? FlightId { get; set; }
    }
}
