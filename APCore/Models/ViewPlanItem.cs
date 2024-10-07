using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewPlanItem
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public DateTime? DateFrom { get; set; }
        public string Day { get; set; }
        public int FromAirport { get; set; }
        public int ToAirport { get; set; }
        public int FromId { get; set; }
        public int ToId { get; set; }
        public DateTime Dep { get; set; }
        public DateTime StartDateUtc { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime Arr { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
        public int TypeId { get; set; }
        public string AircraftType { get; set; }
        public DateTime? DateTo { get; set; }
        public string FlightNumber { get; set; }
        public string FromAirportIata { get; set; }
        public string ToAirportIata { get; set; }
        public int Progress { get; set; }
        public decimal? Duration { get; set; }
        public int EstimatedDelay { get; set; }
        public int DelayOffBlock { get; set; }
        public int DelayTakeoff { get; set; }
        public int DelayOnBlock { get; set; }
        public int DelayLanding { get; set; }
        public int IsDelayOffBlock { get; set; }
        public int IsDelayTakeoff { get; set; }
        public int IsDelayOnBlock { get; set; }
        public int IsDelayLanding { get; set; }
        public int? FlightH { get; set; }
        public int? FlightM { get; set; }
        public string Line { get; set; }
    }
}
