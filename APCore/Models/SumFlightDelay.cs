using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class SumFlightDelay
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; }
        public DateTime? Stdday { get; set; }
        public int Delay { get; set; }
    }
}
