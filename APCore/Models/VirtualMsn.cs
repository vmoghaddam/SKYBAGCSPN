using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class VirtualMsn
    {
        public int Id { get; set; }
        public int? ModelId { get; set; }
        public int? TypeId { get; set; }
        public string Register { get; set; }
        public int CustomerId { get; set; }
    }
}
