using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class AppFdprest
    {
        public int Id { get; set; }
        public int? CrewId { get; set; }
        public int? JobGroupId { get; set; }
        public string JobGroup { get; set; }
        public int? BoxId { get; set; }
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
        public double DelayAmount { get; set; }
        public DateTime? DelayedReportingTime { get; set; }
        public DateTime? NextNotification { get; set; }
        public DateTime? RevisedDelayedReportingTime { get; set; }
        public DateTime? FirstNotification { get; set; }
        public double? MaxFdp { get; set; }
        public double? MaxFdpextended { get; set; }
        public int IsDutyOver { get; set; }
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
        public DateTime? DateContact { get; set; }
        public DateTime? DateContactLocal { get; set; }
        public int DutyType { get; set; }
        public string DutyTypeTitle { get; set; }
        public DateTime? RestUntil { get; set; }
        public DateTime? RestUntilLocal { get; set; }
        public int? LocationId { get; set; }
        public string Location { get; set; }
        public DateTime? DayStdlocal { get; set; }
        public int? Fdpid { get; set; }
        public int? DateStartYear { get; set; }
        public int? DateStartMonth { get; set; }
        public int? DateStartDay { get; set; }
        public int? TemplateId { get; set; }
        public string Remark { get; set; }
        public string Remark2 { get; set; }
        public string InitFlts { get; set; }
        public string InitRoute { get; set; }
        public string CanceledNo { get; set; }
        public string CanceledRoute { get; set; }
        public int? Extension { get; set; }
        public int IsExtension { get; set; }
        public DateTime? DateConfirmed { get; set; }
        public string ConfirmedBy { get; set; }
        public int IsConfirmed { get; set; }
        public string UserName { get; set; }
        public int? Upd { get; set; }
        public int IsSynced { get; set; }
        public DateTime? Istart { get; set; }
        public int? CustomerId { get; set; }
        public string Customer { get; set; }
        public int? Legs { get; set; }
        public DateTime? DateDutyStart { get; set; }
        public DateTime? DateDutyEnd { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? Day { get; set; }
        public int? YearEnd { get; set; }
        public int? MonthEnd { get; set; }
        public int? DayEnd { get; set; }
    }
}
