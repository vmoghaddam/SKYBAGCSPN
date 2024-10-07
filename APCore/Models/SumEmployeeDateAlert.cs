using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class SumEmployeeDateAlert
    {
        public int Id { get; set; }
        public int? PassportExpired { get; set; }
        public int? PassportExpiring { get; set; }
        public int? Ndtexpired { get; set; }
        public int? Ndtexpiring { get; set; }
        public int? Caoexpired { get; set; }
        public int? Caoexpiring { get; set; }
        public int? MedicalExpired { get; set; }
        public int? MedicalExpiring { get; set; }
    }
}
