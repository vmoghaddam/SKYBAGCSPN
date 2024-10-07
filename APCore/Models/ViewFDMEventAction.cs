using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewFdmeventAction
    {
        public int Id { get; set; }
        public int? Fdmid { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? ActionTypeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? PreActionId { get; set; }
        public int? CrewId { get; set; }
        public string UserId { get; set; }
        public string ActionInfo { get; set; }
        public int? Fdpid { get; set; }
        public string ClassId { get; set; }
        public string TrainingResult { get; set; }
        public string ActionType { get; set; }
        public DateTime? DateTrainingAction { get; set; }
        public DateTime? DateTrainingVisit { get; set; }
        public string CourseName { get; set; }
        public int? CourseDuration { get; set; }
        public DateTime? DateCourseStart { get; set; }
        public DateTime? DateCourseEnd { get; set; }
        public string CourseInstructor { get; set; }
        public string CourseLocation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobGroup { get; set; }
        public string Context { get; set; }
        public double? Critical { get; set; }
        public DateTime? Date { get; set; }
        public double? Duration { get; set; }
        public string EventName { get; set; }
        public int? FlightId { get; set; }
        public string Limit { get; set; }
        public double? Major { get; set; }
        public double? Minor { get; set; }
        public string Pflr { get; set; }
        public string Severity { get; set; }
        public string Phase { get; set; }
        public string StateName { get; set; }
        public DateTime? Tddatetime { get; set; }
        public DateTime? Todatetime { get; set; }
        public string Type { get; set; }
        public string Units { get; set; }
        public string Value { get; set; }
        public string ValueName { get; set; }
        public int? ToAirport { get; set; }
        public int? FromAirport { get; set; }
        public string ToAirportIata { get; set; }
        public string FromAirportIata { get; set; }
        public string Register { get; set; }
        public int? RegisterId { get; set; }
        public string FlightNumber { get; set; }
    }
}
