using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class IdeaSession
    {
        public IdeaSession()
        {
            IdeaSessionItems = new HashSet<IdeaSessionItem>();
        }

        public int Id { get; set; }
        public string IdeaId { get; set; }
        public DateTime? DateCreate { get; set; }
        public string Pid { get; set; }
        public string Nid { get; set; }
        public string ClassId { get; set; }
        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }
        public DateTime? DateBegin { get; set; }
        public DateTime? DateEnd { get; set; }
        public string SessionsStr { get; set; }
        public string Remark { get; set; }

        public virtual ICollection<IdeaSessionItem> IdeaSessionItems { get; set; }
    }
}
