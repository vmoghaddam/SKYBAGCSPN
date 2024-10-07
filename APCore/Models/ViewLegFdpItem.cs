using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewLegFdpItem
    {
        public int Id { get; set; }
        public DateTime? ChocksIn { get; set; }
        public DateTime? Landing { get; set; }
        public DateTime? Takeoff { get; set; }
        public DateTime? ChocksOut { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
        public DateTime? Stdlocal { get; set; }
        public DateTime? Stalocal { get; set; }
        public DateTime? Date { get; set; }
        public int? FlightStatusId { get; set; }
        public DateTime? Stdday { get; set; }
        public DateTime? Staday { get; set; }
        public DateTime? Departure { get; set; }
        public DateTime? Arrival { get; set; }
        public DateTime? DepartureLocal { get; set; }
        public DateTime? ArrivalLocal { get; set; }
    }
}
