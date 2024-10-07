using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class Updbl2
    {
        public int Id { get; set; }
        public int SourceAirportId { get; set; }
        public int DestinationAirportId { get; set; }
        public int? FlightH { get; set; }
        public int? FlightM { get; set; }
        public string Org { get; set; }
        public string Des { get; set; }
        public int? Orgid { get; set; }
        public int? Desid { get; set; }
        public int? Hh { get; set; }
        public int? Mm { get; set; }
    }
}
