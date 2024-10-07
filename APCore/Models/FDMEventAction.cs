using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FdmeventAction
    {
        public FdmeventAction()
        {
            FdmactionRecipients = new HashSet<FdmactionRecipient>();
        }

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

        public virtual Employee Crew { get; set; }
        public virtual Fdm Fdm { get; set; }
        public virtual Fdp Fdp { get; set; }
        public virtual ICollection<FdmactionRecipient> FdmactionRecipients { get; set; }
    }
}
