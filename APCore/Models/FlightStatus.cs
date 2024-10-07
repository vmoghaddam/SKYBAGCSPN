using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FlightStatus
    {
        public FlightStatus()
        {
            FlightInformation1s = new HashSet<FlightInformation1>();
        }

        public int Id { get; set; }
        public string FlightStatus1 { get; set; }
        public string Description { get; set; }
        public string BgColor { get; set; }
        public string Color { get; set; }
        public string Class { get; set; }

        public virtual ICollection<FlightInformation1> FlightInformation1s { get; set; }
    }
}
