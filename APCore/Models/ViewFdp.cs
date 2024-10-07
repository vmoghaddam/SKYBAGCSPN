using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewFdp
    {
        public int Id { get; set; }
        public int? CrewId { get; set; }
        public int? BaseAirportId { get; set; }
        public int? JobGroupId { get; set; }
        public int? BoxId { get; set; }
        public int? Sectors { get; set; }
        public string FromAirport { get; set; }
        public string FromAirportIata { get; set; }
        public int? FromAirportId { get; set; }
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
        public int? DutyScheduled { get; set; }
        public int? Duty { get; set; }
        public DateTime? Fdpstart { get; set; }
        public DateTime? FdpstartLocal { get; set; }
        public DateTime? Fdpend { get; set; }
        public DateTime? FdpendLocal { get; set; }
        public DateTime? DutyStart { get; set; }
        public DateTime? DutyStartLocal { get; set; }
        public DateTime? DutyEnd { get; set; }
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
        public int? Wocl { get; set; }
        public int Woclerror { get; set; }
        public int ExtendedBySplitDuty { get; set; }
        public int? StandById { get; set; }
        public DateTime? StandByStart { get; set; }
        public DateTime? StandByStartLocal { get; set; }
        public int? StandByDuration { get; set; }
        public int? FdpstandByScheduled { get; set; }
        public int? Fdpstandby { get; set; }
        public int FdpstandByScheduledError { get; set; }
        public int FdpstandbyError { get; set; }
        public double? FdpreductionByStandBy { get; set; }
        public bool IsTemplate { get; set; }
    }
}
