using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class Fdp
    {
        public Fdp()
        {
            CrewPickupSms = new HashSet<CrewPickupSm>();
            EmployeeCalendars = new HashSet<EmployeeCalendar>();
            ExtensionHistories = new HashSet<ExtensionHistory>();
            FdmeventActions = new HashSet<FdmeventAction>();
            Fdpextras = new HashSet<Fdpextra>();
            Fdpitems = new HashSet<Fdpitem>();
            IdeaSessionItems = new HashSet<IdeaSessionItem>();
            InverseFdpNavigation = new HashSet<Fdp>();
            OffItems = new HashSet<OffItem>();
            TableBlockTimes = new HashSet<TableBlockTime>();
        }

        public int Id { get; set; }
        public int? CrewId { get; set; }
        public DateTime? ReportingTime { get; set; }
        public DateTime? DelayedReportingTime { get; set; }
        public DateTime? RevisedDelayedReportingTime { get; set; }
        public DateTime? FirstNotification { get; set; }
        public DateTime? NextNotification { get; set; }
        public int? DelayAmount { get; set; }
        public int? BoxId { get; set; }
        public int? JobGroupId { get; set; }
        public bool IsTemplate { get; set; }
        public int DutyType { get; set; }
        public DateTime? DateContact { get; set; }
        public int? Fdpid { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? CityId { get; set; }
        public int? TemplateId { get; set; }
        public DateTime? FdpreportingTime { get; set; }
        public Guid? Guid { get; set; }
        public int? FirstFlightId { get; set; }
        public int? LastFlightId { get; set; }
        public int? Upd { get; set; }
        public bool? IsMain { get; set; }
        public string Key { get; set; }
        public bool? Cp { get; set; }
        public int? CustomerId { get; set; }
        public string Remark { get; set; }
        public int? LocationId { get; set; }
        public DateTime? InitStart { get; set; }
        public DateTime? InitEnd { get; set; }
        public DateTime? InitRestTo { get; set; }
        public string InitFlts { get; set; }
        public string InitRoute { get; set; }
        public string InitFromIata { get; set; }
        public string InitToIata { get; set; }
        public string InitNo { get; set; }
        public string InitKey { get; set; }
        public int? InitHomeBase { get; set; }
        public string InitRank { get; set; }
        public int? InitIndex { get; set; }
        public string InitGroup { get; set; }
        public string InitScheduleName { get; set; }
        public string InitFlights { get; set; }
        public string Remark2 { get; set; }
        public string CanceledNo { get; set; }
        public string CanceledRoute { get; set; }
        public int? Extension { get; set; }
        public double? Split { get; set; }
        public DateTime? DateConfirmed { get; set; }
        public string ConfirmedBy { get; set; }
        public string UserName { get; set; }
        public decimal? MaxFdp { get; set; }
        public int? Bl { get; set; }
        public int? Fx { get; set; }

        public virtual Box Box { get; set; }
        public virtual Employee Crew { get; set; }
        public virtual Fdp FdpNavigation { get; set; }
        public virtual ICollection<CrewPickupSm> CrewPickupSms { get; set; }
        public virtual ICollection<EmployeeCalendar> EmployeeCalendars { get; set; }
        public virtual ICollection<ExtensionHistory> ExtensionHistories { get; set; }
        public virtual ICollection<FdmeventAction> FdmeventActions { get; set; }
        public virtual ICollection<Fdpextra> Fdpextras { get; set; }
        public virtual ICollection<Fdpitem> Fdpitems { get; set; }
        public virtual ICollection<IdeaSessionItem> IdeaSessionItems { get; set; }
        public virtual ICollection<Fdp> InverseFdpNavigation { get; set; }
        public virtual ICollection<OffItem> OffItems { get; set; }
        public virtual ICollection<TableBlockTime> TableBlockTimes { get; set; }
    }
}
