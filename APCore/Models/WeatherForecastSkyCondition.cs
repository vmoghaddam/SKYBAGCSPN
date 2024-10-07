using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class WeatherForecastSkyCondition
    {
        public int Id { get; set; }
        public int ForecastId { get; set; }
        public string SkyCover { get; set; }
        public double? CloudBaseFtAgl { get; set; }
        public string CloudType { get; set; }

        public virtual WeatherTafForecast Forecast { get; set; }
    }
}
