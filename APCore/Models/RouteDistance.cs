using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class RouteDistance
    {
        public int Id { get; set; }
        public string FromIata { get; set; }
        public int FromId { get; set; }
        public string ToIata { get; set; }
        public int ToId { get; set; }
        public double? Distance { get; set; }
    }
}
