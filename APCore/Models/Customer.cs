using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class Customer
    {
        public Customer()
        {
            AcMsns = new HashSet<AcMsn>();
            Books = new HashSet<Book>();
            FlightInformation1s = new HashSet<FlightInformation1>();
            FlightPlans = new HashSet<FlightPlan>();
            Locations = new HashSet<Location>();
            PersonCustomers = new HashSet<PersonCustomer>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int? TypeId { get; set; }
        public string Address { get; set; }
        public int? CountryId { get; set; }
        public string Idno { get; set; }
        public string Nid { get; set; }
        public string MapUrl { get; set; }
        public DateTime DateRegister { get; set; }
        public DateTime? DateConfirmed { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Remark { get; set; }

        public virtual Country Country { get; set; }
        public virtual Option Type { get; set; }
        public virtual ICollection<AcMsn> AcMsns { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<FlightInformation1> FlightInformation1s { get; set; }
        public virtual ICollection<FlightPlan> FlightPlans { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<PersonCustomer> PersonCustomers { get; set; }
    }
}
