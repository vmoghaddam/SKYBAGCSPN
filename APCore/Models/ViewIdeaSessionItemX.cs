﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewIdeaSessionItemX
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public DateTime? DateFromUtc { get; set; }
        public DateTime? DateToUtc { get; set; }
        public string Remark { get; set; }
        public int? Fdpid { get; set; }
        public string Nid { get; set; }
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
