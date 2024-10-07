using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewFdm
    {
        public int? ToAirport { get; set; }
        public int? FromAirport { get; set; }
        public string ToAirportIata { get; set; }
        public string FromAirportIata { get; set; }
        public string AircraftType { get; set; }
        public int? TypeId { get; set; }
        public string Register { get; set; }
        public int? RegisterId { get; set; }
        public int? P1id { get; set; }
        public string P1code { get; set; }
        public int? P2id { get; set; }
        public string P2code { get; set; }
        public int? Ipid { get; set; }
        public string Ipcode { get; set; }
        public string Ipname { get; set; }
        public string P1name { get; set; }
        public string P2name { get; set; }
        public DateTime? BlockOff { get; set; }
        public DateTime? BlockOn { get; set; }
        public DateTime? TakeOff { get; set; }
        public DateTime? Landing { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
        public int? BlockTime { get; set; }
        public int? FlightTime { get; set; }
        public string Pf { get; set; }
        public string FlightNumber { get; set; }
        public string Context { get; set; }
        public double? Critical { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Duration { get; set; }
        public string EventName { get; set; }
        public int? FlightId { get; set; }
        public int Id { get; set; }
        public string Limit { get; set; }
        public double? Major { get; set; }
        public double? Minor { get; set; }
        public string Pflr { get; set; }
        public string Severity { get; set; }
        public string Phase { get; set; }
        public string StateName { get; set; }
        public DateTime? Tddatetime { get; set; }
        public DateTime? Todatetime { get; set; }
        public string Type { get; set; }
        public string Units { get; set; }
        public string Value { get; set; }
        public string ValueName { get; set; }
        public bool? Removed { get; set; }
        public string RemovedBy { get; set; }
        public DateTime? DateRemoved { get; set; }
        public bool? Approved { get; set; }
        public bool? IsLocked { get; set; }
        public int? ResponsibleId { get; set; }
        public string Responsible { get; set; }
        public string Status { get; set; }
    }
}
