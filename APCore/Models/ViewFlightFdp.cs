using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewFlightFdp
    {
        public int Fdpid { get; set; }
        public int? FlightId { get; set; }
        public string Fdptitle { get; set; }
        public string Fdpremark { get; set; }
        public DateTime? DutyStart { get; set; }
        public DateTime? DutyEnd { get; set; }
        public DateTime? DutyStartLocal { get; set; }
        public DateTime? DutyEndLocal { get; set; }
        public int? Sectors { get; set; }
        public string ToAirportIata { get; set; }
        public string FromAirportIata { get; set; }
        public DateTime? DefaultReportingTime { get; set; }
        public DateTime? DefaultReportingTimeLocal { get; set; }
        public int? Fdp { get; set; }
        public int? Fdpscheduled { get; set; }
        public double? DutyScheduled { get; set; }
        public double? Duty { get; set; }
        public DateTime? RestFrom { get; set; }
        public DateTime? RestFromLocal { get; set; }
        public DateTime? RestUntil { get; set; }
        public DateTime? RestUntilLocal { get; set; }
        public double? MaxFdpextended { get; set; }
        public int IsDutyOver { get; set; }
        public int ExtendedBySplitDuty { get; set; }
    }
}
