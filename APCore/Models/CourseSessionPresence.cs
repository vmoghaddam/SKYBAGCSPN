using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class CourseSessionPresence
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public string Remark { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual CourseSession Session { get; set; }
    }
}
