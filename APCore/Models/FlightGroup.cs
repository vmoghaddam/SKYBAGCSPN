using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FlightGroup
    {
        public FlightGroup()
        {
            FlightInformation1s = new HashSet<FlightInformation1>();
        }

        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public string Remark { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ICollection<FlightInformation1> FlightInformation1s { get; set; }
    }
}
