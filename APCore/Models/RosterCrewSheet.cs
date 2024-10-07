using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class RosterCrewSheet
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public int CrewId { get; set; }
        public bool Dh { get; set; }
        public int PositionId { get; set; }
        public int? FdpitemId { get; set; }

        public virtual Fdpitem Fdpitem { get; set; }
    }
}
