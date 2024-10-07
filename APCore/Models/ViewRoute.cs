using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewRoute
    {
        public int Id { get; set; }
        public int FromAirport { get; set; }
        public string FromAirportIata { get; set; }
        public int ToAirport { get; set; }
        public string ToAirportIata { get; set; }
        public string Route { get; set; }
        public int? FlightH { get; set; }
        public int? FlightM { get; set; }
    }
}
