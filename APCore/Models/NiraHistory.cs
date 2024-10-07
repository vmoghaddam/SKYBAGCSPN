using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class NiraHistory
    {
        public int Id { get; set; }
        public string Flight { get; set; }
        public string Chtime { get; set; }
        public string Newaircraft { get; set; }
        public string Newstatus { get; set; }
        public DateTime? DateSend { get; set; }
        public DateTime? DateReplied { get; set; }
        public string Remark { get; set; }
        public int? FlightId { get; set; }
        public int? FlightStatusId { get; set; }
        public DateTime? Departure { get; set; }
        public DateTime? Arrival { get; set; }
        public string Register { get; set; }
    }
}
