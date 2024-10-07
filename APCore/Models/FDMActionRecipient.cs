using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FdmactionRecipient
    {
        public int Id { get; set; }
        public int? ActionId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? RemarkDate { get; set; }
        public string Remarks { get; set; }

        public virtual FdmeventAction Action { get; set; }
    }
}
