using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class Box
    {
        public Box()
        {
            BoxCrews = new HashSet<BoxCrew>();
            BoxFlightPlanItems = new HashSet<BoxFlightPlanItem>();
            BoxItems = new HashSet<BoxItem>();
            Fdps = new HashSet<Fdp>();
            FlightInformation1s = new HashSet<FlightInformation1>();
            FlightPlanCalanderCrews = new HashSet<FlightPlanCalanderCrew>();
            FlightPlanItems = new HashSet<FlightPlanItem>();
        }

        public int Id { get; set; }
        public int FlightPlanId { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
        public int? FromAirportId { get; set; }
        public int? ToAirportId { get; set; }
        public DateTime? Date { get; set; }
        public int? CalanderId { get; set; }
        public DateTime? DelayedReport { get; set; }
        public DateTime? NextNotification { get; set; }
        public DateTime? FirstNotification { get; set; }
        public int? DelayAmount { get; set; }
        public DateTime? ReportingTime { get; set; }
        public DateTime? DelayedReportingTime { get; set; }
        public DateTime? RevisedDelayedReportingTime { get; set; }

        public virtual ICollection<BoxCrew> BoxCrews { get; set; }
        public virtual ICollection<BoxFlightPlanItem> BoxFlightPlanItems { get; set; }
        public virtual ICollection<BoxItem> BoxItems { get; set; }
        public virtual ICollection<Fdp> Fdps { get; set; }
        public virtual ICollection<FlightInformation1> FlightInformation1s { get; set; }
        public virtual ICollection<FlightPlanCalanderCrew> FlightPlanCalanderCrews { get; set; }
        public virtual ICollection<FlightPlanItem> FlightPlanItems { get; set; }
    }
}
