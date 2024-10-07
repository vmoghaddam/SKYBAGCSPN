using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class HelperFuelAvgReg
    {
        public string FromAirportIata { get; set; }
        public string ToAirportIata { get; set; }
        public int? TypeId { get; set; }
        public string AircraftType { get; set; }
        public int? RegisterId { get; set; }
        public string Register { get; set; }
        public decimal? AvgfuelBurned { get; set; }
    }
}
