using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class HelperFdpbox
    {
        public int Id { get; set; }
        public int? Cid { get; set; }
        public int DelayAmount { get; set; }
        public int DelayAmountLast { get; set; }
        public DateTime? DelayedReportingTime { get; set; }
        public DateTime? NextNotification { get; set; }
        public DateTime? RevisedDelayedReportingTime { get; set; }
        public DateTime? FirstNotification { get; set; }
        public int? Sectors { get; set; }
        public int? ActypeId { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
        public DateTime? Departure { get; set; }
        public DateTime? Arrival { get; set; }
        public DateTime? DepartureLocal { get; set; }
        public DateTime? ArrivalLocal { get; set; }
        public DateTime? DefaultReportingTime { get; set; }
        public DateTime? ReportingTime { get; set; }
        public DateTime? ReportingTimeLcl { get; set; }
        public int? LastFlightStatusId { get; set; }
        public string FlightNumber { get; set; }
        public int? FromAirport { get; set; }
        public string FromAirportIata { get; set; }
        public int? FromAirportCityId { get; set; }
        public int? ToAirport { get; set; }
        public string ToAirportIata { get; set; }
    }
}
