using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewFdpab
    {
        public int Id { get; set; }
        public int? CrewId { get; set; }
        public int? BaseAirportId { get; set; }
        public int? JobGroupId { get; set; }
        public int? Sectors { get; set; }
        public int? ActypeId { get; set; }
        public string FromAirport { get; set; }
        public string FromAirportIata { get; set; }
        public int? FromAirportId { get; set; }
        public int? FromAirportCityId { get; set; }
        public int? CityId { get; set; }
        public int? FdplocationId { get; set; }
        public string ToAirport { get; set; }
        public string ToAirportIata { get; set; }
        public int? ToAirportId { get; set; }
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
        public int? Fdpscheduled { get; set; }
        public int? Fdp { get; set; }
        public double? DutyScheduled { get; set; }
        public double? Duty { get; set; }
        public DateTime? Fdpstart { get; set; }
        public DateTime? FdpstartLocal { get; set; }
        public DateTime? Fdpend { get; set; }
        public DateTime? FdpendLocal { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DutyStart { get; set; }
        public DateTime? DateStartLocal { get; set; }
        public DateTime? DutyStartLocal { get; set; }
        public DateTime? DateEnd { get; set; }
        public DateTime? DutyEnd { get; set; }
        public DateTime? DateEndLocal { get; set; }
        public DateTime? DutyEndLocal { get; set; }
        public DateTime? RestFrom { get; set; }
        public DateTime? RestFromLocal { get; set; }
        public DateTime? RestUntil { get; set; }
        public DateTime? RestUntilLocal { get; set; }
        public int DelayAmount { get; set; }
        public DateTime? DelayedReportingTime { get; set; }
        public DateTime? NextNotification { get; set; }
        public DateTime? RevisedDelayedReportingTime { get; set; }
        public DateTime? FirstNotification { get; set; }
        public double? MaxFdp { get; set; }
        public double? MaxFdpextended { get; set; }
        public int IsDutyOver { get; set; }
        public int ExtendedBySplitDuty { get; set; }
        public bool IsTemplate { get; set; }
        public DateTime? DateContact { get; set; }
        public DateTime? DateContactLocal { get; set; }
        public int DutyType { get; set; }
        public string DutyTypeTitle { get; set; }
        public int IsFdp { get; set; }
        public int? Wocl { get; set; }
        public int? Fdpcount { get; set; }
        public string Fdptitle { get; set; }
        public string Fdpremark { get; set; }
        public int? DateStartYear { get; set; }
        public int? DateStartMonth { get; set; }
        public int? DateStartDay { get; set; }
        public string Flights { get; set; }
        public string Message { get; set; }
        public int? StandById { get; set; }
    }
}
