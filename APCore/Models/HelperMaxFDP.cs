using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class HelperMaxFdp
    {
        public int Id { get; set; }
        public double? MaxFdp { get; set; }
        public double? FdpreductionByStandBy { get; set; }
        public double? MaxFdpextended { get; set; }
    }
}
