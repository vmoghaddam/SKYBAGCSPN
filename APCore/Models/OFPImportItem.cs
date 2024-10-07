using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class OfpimportItem
    {
        public int Id { get; set; }
        public int Ofpid { get; set; }
        public string Line { get; set; }

        public virtual Ofpimport Ofp { get; set; }
    }
}
