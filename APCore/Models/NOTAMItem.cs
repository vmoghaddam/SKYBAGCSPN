using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class Notamitem
    {
        public int Id { get; set; }
        public int Notamid { get; set; }
        public string Text { get; set; }

        public virtual Notam Notam { get; set; }
    }
}
