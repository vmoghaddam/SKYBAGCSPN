using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class Organization
    {
        public Organization()
        {
            AcMsns = new HashSet<AcMsn>();
            AircraftTypes = new HashSet<AircraftType>();
            Books = new HashSet<Book>();
            FlightInformation1s = new HashSet<FlightInformation1>();
            FlightPlanItems = new HashSet<FlightPlanItem>();
            Ratings = new HashSet<Rating>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string ContactPerson { get; set; }
        public string Address { get; set; }
        public string Remark { get; set; }
        public string LogoUrl { get; set; }
        public int? TypeId { get; set; }
        public int CountryId { get; set; }

        public virtual ICollection<AcMsn> AcMsns { get; set; }
        public virtual ICollection<AircraftType> AircraftTypes { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<FlightInformation1> FlightInformation1s { get; set; }
        public virtual ICollection<FlightPlanItem> FlightPlanItems { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
