using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class WeatherMetarSkyCondition
    {
        public int Id { get; set; }
        public int MetarId { get; set; }
        public string SkyCover { get; set; }
        public int? CloudBaseFtAgl { get; set; }

        public virtual WeatherMetar Metar { get; set; }
    }
}
