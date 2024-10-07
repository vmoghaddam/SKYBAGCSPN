using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class WeatherForecastTurbulence
    {
        public int Id { get; set; }
        public string TurbulenceIntensity { get; set; }
        public double? TurbulenceMinAltFtAgl { get; set; }
        public double? TurbulenceMaxAltFtAgl { get; set; }
        public int ForecastId { get; set; }

        public virtual WeatherTafForecast Forecast { get; set; }
    }
}
