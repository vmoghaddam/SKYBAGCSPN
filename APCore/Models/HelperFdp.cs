using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class HelperFdp
    {
        public int Id { get; set; }
        public int? CrewId { get; set; }
        public int? Sectors { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
        public DateTime? Stdlocal { get; set; }
        public DateTime? Stalocal { get; set; }
        public DateTime? Departure { get; set; }
        public DateTime? Arrival { get; set; }
        public DateTime? DepartureLocal { get; set; }
        public DateTime? ArrivalLocal { get; set; }
        public DateTime? DefaultReportingTime { get; set; }
        public DateTime? DefaultReportingTimeLocal { get; set; }
        public DateTime? ReportingTime { get; set; }
        public DateTime? ReportingTimeLocal { get; set; }
        public DateTime? Fdpstart { get; set; }
        public DateTime? Fdpend { get; set; }
        public double? MaxFdp { get; set; }
        public int DelayAmount { get; set; }
        public DateTime? DelayedReportingTime { get; set; }
        public DateTime? NextNotification { get; set; }
        public DateTime? RevisedDelayedReportingTime { get; set; }
        public DateTime? FirstNotification { get; set; }
        public int? FromAirportId { get; set; }
        public string FromAirportIata { get; set; }
        public int? FromAirportCityId { get; set; }
        public string FromAirport { get; set; }
        public int? ToAirportId { get; set; }
        public string ToAirportIata { get; set; }
        public string ToAirport { get; set; }
        public int? ActypeId { get; set; }
        public int ExtendedBySplitDuty { get; set; }
        public int? StandById { get; set; }
        public DateTime? StandByStart { get; set; }
        public int? StandByDuration { get; set; }
        public double? FdpreductionByStandBy { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DutyStart { get; set; }
        public DateTime? DutyStartLocal { get; set; }
        public DateTime? DateEnd { get; set; }
        public DateTime? DateEndLocal { get; set; }
        public string Flights { get; set; }
        public int R10 { get; set; }
        public int R12 { get; set; }
    }
}
