using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewBookApplicableEmployeeX
    {
        public int EmployeeId { get; set; }
        public bool? IsDownloaded { get; set; }
        public bool? IsVisited { get; set; }
        public int? FolderId { get; set; }
        public string FolderCode { get; set; }
        public int? FileCount { get; set; }
    }
}
