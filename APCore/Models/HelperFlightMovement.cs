using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class HelperFlightMovement
    {
        public int Id { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
        public DateTime? ChocksOut { get; set; }
        public DateTime? ChocksIn { get; set; }
        public DateTime? ActualDeparture { get; set; }
        public DateTime? ActualArrival { get; set; }
    }
}
