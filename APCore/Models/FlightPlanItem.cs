using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FlightPlanItem
    {
        public FlightPlanItem()
        {
            BoxItems = new HashSet<BoxItem>();
            FlightInformation1s = new HashSet<FlightInformation1>();
            FlightPlanCalanderCrews = new HashSet<FlightPlanCalanderCrew>();
            FlightPlanGroups = new HashSet<FlightPlanGroup>();
            FlightPlanItemPermits = new HashSet<FlightPlanItemPermit>();
        }

        public int Id { get; set; }
        public int FlightPlanId { get; set; }
        public int? TypeId { get; set; }
        public int? RegisterId { get; set; }
        public int? FlightTypeId { get; set; }
        public int? AirlineOperatorsId { get; set; }
        public string FlightNumber { get; set; }
        public int FromAirport { get; set; }
        public int ToAirport { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
        public int FlightH { get; set; }
        public int FlightM { get; set; }
        public string Unknown { get; set; }
        public int? StatusId { get; set; }
        public int? RouteId { get; set; }
        public int? BoxId { get; set; }
        public string DepartureRemark { get; set; }

        public virtual Organization AirlineOperators { get; set; }
        public virtual Box Box { get; set; }
        public virtual FlightPlan FlightPlan { get; set; }
        public virtual Airport FromAirportNavigation { get; set; }
        public virtual AcMsn Register { get; set; }
        public virtual Airport ToAirportNavigation { get; set; }
        public virtual AircraftType Type { get; set; }
        public virtual ICollection<BoxItem> BoxItems { get; set; }
        public virtual ICollection<FlightInformation1> FlightInformation1s { get; set; }
        public virtual ICollection<FlightPlanCalanderCrew> FlightPlanCalanderCrews { get; set; }
        public virtual ICollection<FlightPlanGroup> FlightPlanGroups { get; set; }
        public virtual ICollection<FlightPlanItemPermit> FlightPlanItemPermits { get; set; }
    }
}
