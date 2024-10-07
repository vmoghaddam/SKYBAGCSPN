using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class RptFdpitem
    {
        public int Id { get; set; }
        public int Fdpid { get; set; }
        public int? FlightId { get; set; }
        public bool? IsSector { get; set; }
        public bool? IsOff { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsActiveFix { get; set; }
        public bool? IsPositioning { get; set; }
        public bool? IsCanceled { get; set; }
        public int? FlightStatusId { get; set; }
        public string FlightNumber { get; set; }
        public int? FromAirportId { get; set; }
        public int? ToAirportId { get; set; }
        public string FromAirport { get; set; }
        public string ToAirport { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
        public DateTime? ChocksOut { get; set; }
        public DateTime? Stdlocal { get; set; }
        public DateTime? Stalocal { get; set; }
        public DateTime? StddayUtc { get; set; }
        public DateTime? StadayUtc { get; set; }
        public DateTime? Stdday { get; set; }
        public DateTime? Staday { get; set; }
        public int? FlightTime { get; set; }
        public int? FixedFlightTime { get; set; }
        public int? BlockTime { get; set; }
        public int? ScheduledTime { get; set; }
        public int? CrewId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ScheduleName { get; set; }
        public string JobGroup { get; set; }
        public string JobGroupCode { get; set; }
        public string JobGroupRoot { get; set; }
        public long? Rank { get; set; }
    }
}
