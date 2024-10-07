﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewIdeaLast
    {
        public string Nid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CourseTitle { get; set; }
        public string MappedTitle { get; set; }
        public string CourseCode { get; set; }
        public string Name { get; set; }
        public string ScheduleName { get; set; }
        public string JobGroup { get; set; }
        public string JobGroupCode { get; set; }
        public int CrewId { get; set; }
        public DateTime? DateIssue { get; set; }
        public DateTime? DateExpire { get; set; }
    }
}
