using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewFlightCrew
    {
        public int Id { get; set; }
        public int FlightInformationId { get; set; }
        public int? Status { get; set; }
        public string Remark { get; set; }
        public int? FlightPlanCrewId { get; set; }
        public int? EmployeeId { get; set; }
        public int? CalanderId { get; set; }
        public int? FlightPlanId { get; set; }
        public int? GroupId { get; set; }
        public string JobGroup { get; set; }
        public string JobGroupCode { get; set; }
        public string Pid { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int? FlightStatusId { get; set; }
        public int? ActualFlightHoffBlock { get; set; }
        public decimal? ActualFlightMoffBlock { get; set; }
        public DateTime? ChocksOut { get; set; }
        public DateTime? ChocksIn { get; set; }
        public int? ActualFlightHtakeoff { get; set; }
        public decimal? ActualFlightMtakeoff { get; set; }
        public int? TotalFlightMinutesOffBlock { get; set; }
        public decimal? TotalFlightHoursOffBlock { get; set; }
        public decimal? PastHoursFromOffBlock { get; set; }
        public DateTime? ActualDateOffBlock { get; set; }
    }
}
