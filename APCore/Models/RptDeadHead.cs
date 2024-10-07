using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class RptDeadHead
    {
        public int Id { get; set; }
        public int Fdpid { get; set; }
        public int? CrewId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JobGroup { get; set; }
        public string JobGroupCode { get; set; }
        public int FlightId { get; set; }
        public string FlightNumber { get; set; }
        public string FromAirportIata { get; set; }
        public string ToAirportIata { get; set; }
        public DateTime? StddayLocal { get; set; }
        public DateTime? Stdday { get; set; }
        public DateTime? BlockOff { get; set; }
        public DateTime? BlockOn { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
        public DateTime? TakeOff { get; set; }
        public DateTime? Landing { get; set; }
        public DateTime? ChocksOut { get; set; }
        public DateTime? TakeOffStn { get; set; }
        public DateTime? LandingStn { get; set; }
        public DateTime? ChocksIn { get; set; }
        public int? BlockTimeStn { get; set; }
        public int? FlightTimeStn { get; set; }
        public DateTime? DateFdp { get; set; }
        public int? Pyear { get; set; }
        public string PmonthName { get; set; }
        public int? Pmonth { get; set; }
        public string Pdate { get; set; }
        public string PeriodFixTime { get; set; }
    }
}
