using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewCourseSession
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public bool Done { get; set; }
        public string Remark { get; set; }
        public string DayName { get; set; }
        public int? Year { get; set; }
        public string MonthName { get; set; }
        public int? Month { get; set; }
        public string Pdate { get; set; }
        public string PyearName { get; set; }
        public int? Pyear { get; set; }
        public string PmonthName { get; set; }
        public int? Pmonth { get; set; }
        public string PdayName { get; set; }
        public string No { get; set; }
        public string Instructor { get; set; }
        public string Title { get; set; }
        public string CtTitle { get; set; }
        public int? CustomerId { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public int? OrganizationId { get; set; }
        public string Organization { get; set; }
        public bool? IsGeneral { get; set; }
        public int? StatusId { get; set; }
        public string Status { get; set; }
    }
}
