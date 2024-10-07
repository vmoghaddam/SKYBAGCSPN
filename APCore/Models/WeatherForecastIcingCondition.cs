using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class WeatherForecastIcingCondition
    {
        public int Id { get; set; }
        public int ForecastId { get; set; }
        public string IcingIntensity { get; set; }
        public double? IcingMinAltFtAgl { get; set; }
        public double? IcingMaxAltFtAgl { get; set; }

        public virtual WeatherTafForecast Forecast { get; set; }
    }
}
