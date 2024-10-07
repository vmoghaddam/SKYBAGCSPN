using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class Idea
    {
        public string Pid { get; set; }
        public string Nid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }
        public string ClassId { get; set; }
        public string Instructor { get; set; }
        public string BeginDate { get; set; }
        public string EndDate { get; set; }
        public string Days { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public string Issue { get; set; }
        public string Expire { get; set; }
        public Guid Id { get; set; }
        public DateTime? DateIssue { get; set; }
        public DateTime? DateExpire { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
