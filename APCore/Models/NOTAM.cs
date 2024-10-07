using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class Notam
    {
        public Notam()
        {
            Notamitems = new HashSet<Notamitem>();
        }

        public int Id { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? FlightId { get; set; }
        public int? Fdpid { get; set; }
        public string StationId { get; set; }
        public DateTime? DateDay { get; set; }

        public virtual ICollection<Notamitem> Notamitems { get; set; }
    }
}
