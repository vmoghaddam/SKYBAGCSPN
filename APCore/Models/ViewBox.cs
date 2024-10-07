using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewBox
    {
        public int Id { get; set; }
        public int FlightPlanId { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? DefaultStart { get; set; }
        public DateTime? Sta { get; set; }
        public DateTime? DefaultEnd { get; set; }
        public int? FromAirportId { get; set; }
        public int? ToAirportId { get; set; }
        public DateTime? Date { get; set; }
        public int? CalanderId { get; set; }
        public string Flights { get; set; }
        public int? Duty { get; set; }
        public int? ScheduledDuty { get; set; }
        public int? Flight { get; set; }
        public int? Fdp { get; set; }
        public int? ScheduledFdp { get; set; }
        public int? NotAllAssignedCount { get; set; }
        public int? CrewProblemCount { get; set; }
        public int? AssignedCrewCount { get; set; }
        public DateTime? RestUntil { get; set; }
        public DateTime? RestFrom { get; set; }
        public double? MaxFdp { get; set; }
        public double? MaxFdpextended { get; set; }
        public int IsDutyOver { get; set; }
        public int? Wocl { get; set; }
        public int Woclerror { get; set; }
        public int? Sector { get; set; }
        public int? DelayAmount { get; set; }
        public DateTime? DelayedReportingTime { get; set; }
    }
}
