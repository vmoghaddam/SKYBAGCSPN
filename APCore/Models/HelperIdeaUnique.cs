using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class HelperIdeaUnique
    {
        public int Id { get; set; }
        public string IdeaId { get; set; }
        public string Nid { get; set; }
        public string Pid { get; set; }
        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }
        public string CourseType { get; set; }
        public string ClassId { get; set; }
        public DateTime? DateBegin { get; set; }
        public DateTime? DateEnd { get; set; }
        public DateTime? DateExpire { get; set; }
        public string Remark { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? CrewId { get; set; }
        public string CrewPid { get; set; }
        public int? GroupId { get; set; }
        public string JobGroup { get; set; }
        public string JobGroupCode { get; set; }
        public string CrewNid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string ScheduleName { get; set; }
        public int? IsCockpit { get; set; }
        public int? IsCabin { get; set; }
    }
}
