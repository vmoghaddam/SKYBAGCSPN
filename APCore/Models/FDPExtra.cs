using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class Fdpextra
    {
        public int Id { get; set; }
        public int Fdpid { get; set; }
        public decimal? MaxFdp { get; set; }

        public virtual Fdp Fdp { get; set; }
    }
}
