using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class Employee
    {
        public Employee()
        {
            BookRelatedEmployees = new HashSet<BookRelatedEmployee>();
            BoxCrews = new HashSet<BoxCrew>();
            CourseRelatedEmployees = new HashSet<CourseRelatedEmployee>();
            CourseSessionPresences = new HashSet<CourseSessionPresence>();
            Efbdspreleases = new HashSet<Efbdsprelease>();
            EmployeeBookStatuses = new HashSet<EmployeeBookStatus>();
            EmployeeLocations = new HashSet<EmployeeLocation>();
            FdmeventActions = new HashSet<FdmeventAction>();
            Fdps = new HashSet<Fdp>();
            FlightCrews = new HashSet<FlightCrew>();
            FlightGroups = new HashSet<FlightGroup>();
            FlightPlanCalanderCrews = new HashSet<FlightPlanCalanderCrew>();
            FlightPlanStatuses = new HashSet<FlightPlanStatus>();
        }

        public int Id { get; set; }
        public string Pid { get; set; }
        public string Phone { get; set; }
        public int? CurrentLocationAirport { get; set; }
        public int? BaseAirportId { get; set; }
        public DateTime? DateInactiveBegin { get; set; }
        public DateTime? DateInactiveEnd { get; set; }
        public double? FlightSum { get; set; }
        public int? FlightEarly { get; set; }
        public int? FlightLate { get; set; }
        public bool? InActive { get; set; }

        public virtual Airport BaseAirport { get; set; }
        public virtual Airport CurrentLocationAirportNavigation { get; set; }
        public virtual PersonCustomer IdNavigation { get; set; }
        public virtual ICollection<BookRelatedEmployee> BookRelatedEmployees { get; set; }
        public virtual ICollection<BoxCrew> BoxCrews { get; set; }
        public virtual ICollection<CourseRelatedEmployee> CourseRelatedEmployees { get; set; }
        public virtual ICollection<CourseSessionPresence> CourseSessionPresences { get; set; }
        public virtual ICollection<Efbdsprelease> Efbdspreleases { get; set; }
        public virtual ICollection<EmployeeBookStatus> EmployeeBookStatuses { get; set; }
        public virtual ICollection<EmployeeLocation> EmployeeLocations { get; set; }
        public virtual ICollection<FdmeventAction> FdmeventActions { get; set; }
        public virtual ICollection<Fdp> Fdps { get; set; }
        public virtual ICollection<FlightCrew> FlightCrews { get; set; }
        public virtual ICollection<FlightGroup> FlightGroups { get; set; }
        public virtual ICollection<FlightPlanCalanderCrew> FlightPlanCalanderCrews { get; set; }
        public virtual ICollection<FlightPlanStatus> FlightPlanStatuses { get; set; }
    }
}
