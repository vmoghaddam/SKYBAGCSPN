using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class Fdm
    {
        public Fdm()
        {
            FdmeventActions = new HashSet<FdmeventAction>();
        }

        public int Id { get; set; }
        public string Severity { get; set; }
        public string EventName { get; set; }
        public string Value { get; set; }
        public double? Minor { get; set; }
        public double? Major { get; set; }
        public double? Critical { get; set; }
        public DateTime? Tddatetime { get; set; }
        public string P1 { get; set; }
        public string P2 { get; set; }
        public string Phase { get; set; }
        public string StateName { get; set; }
        public string Context { get; set; }
        public string Type { get; set; }
        public DateTime? Todatetime { get; set; }
        public string Units { get; set; }
        public string ValueName { get; set; }
        public int? FlightId { get; set; }
        public string Pflr { get; set; }
        public string Limit { get; set; }
        public DateTime? Date { get; set; }
        public string FileName { get; set; }
        public int? P1id { get; set; }
        public int? P2id { get; set; }
        public int? RegisterId { get; set; }
        public int? FromAirport { get; set; }
        public int? ToAirport { get; set; }
        public string Ip { get; set; }
        public int? Ipid { get; set; }
        public string FromAirportIata { get; set; }
        public string ToAirportIata { get; set; }
        public string Key { get; set; }
        public string AircraftType { get; set; }
        public int? AircraftTypeId { get; set; }
        public bool? Removed { get; set; }
        public DateTime? DateRemoved { get; set; }
        public string RemovedBy { get; set; }
        public DateTime? DateCreate { get; set; }
        public bool? Published { get; set; }
        public string PublishedBy { get; set; }
        public bool? Deleted { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? DateApproved { get; set; }
        public TimeSpan? Duration { get; set; }
        public bool? Islocked { get; set; }
        public DateTime? IsLockedDate { get; set; }
        public bool? IsVisible { get; set; }
        public DateTime? IsVisibleDate { get; set; }
        public string Remark { get; set; }

        public virtual ICollection<FdmeventAction> FdmeventActions { get; set; }
    }
}
