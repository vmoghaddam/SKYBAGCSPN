using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewFdpcrew
    {
        public int Id { get; set; }
        public int? Fdpid { get; set; }
        public string Name { get; set; }
        public string ScheduleName { get; set; }
        public string Position { get; set; }
        public int? PositionId { get; set; }
        public int? RosterPositionId { get; set; }
        public string Mobile { get; set; }
        public string JobGroup { get; set; }
        public string JobGroupCode { get; set; }
    }
}
