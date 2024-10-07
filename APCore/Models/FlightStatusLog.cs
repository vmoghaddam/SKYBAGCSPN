using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FlightStatusLog
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public int FlightStatusId { get; set; }
        public DateTime Date { get; set; }
        public string Remark { get; set; }
        public int UserId { get; set; }

        public virtual FlightInformation1 Flight { get; set; }
    }
}
