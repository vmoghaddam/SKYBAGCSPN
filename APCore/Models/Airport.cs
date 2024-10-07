using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class Airport
    {
        public Airport()
        {
            EmployeeBaseAirports = new HashSet<Employee>();
            EmployeeCurrentLocationAirportNavigations = new HashSet<Employee>();
            FlightInformation1FromAirports = new HashSet<FlightInformation1>();
            FlightInformation1ToAirports = new HashSet<FlightInformation1>();
            FlightPlanItemFromAirportNavigations = new HashSet<FlightPlanItem>();
            FlightPlanItemToAirportNavigations = new HashSet<FlightPlanItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Iata { get; set; }
        public string Icao { get; set; }
        public int? CityId { get; set; }
        public string ImportId { get; set; }
        public string Type { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public int? SortIndex { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<Employee> EmployeeBaseAirports { get; set; }
        public virtual ICollection<Employee> EmployeeCurrentLocationAirportNavigations { get; set; }
        public virtual ICollection<FlightInformation1> FlightInformation1FromAirports { get; set; }
        public virtual ICollection<FlightInformation1> FlightInformation1ToAirports { get; set; }
        public virtual ICollection<FlightPlanItem> FlightPlanItemFromAirportNavigations { get; set; }
        public virtual ICollection<FlightPlanItem> FlightPlanItemToAirportNavigations { get; set; }
    }
}
