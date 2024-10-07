using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class WeatherForecastTemperature
    {
        public int Id { get; set; }
        public int ForecastId { get; set; }
        public DateTime? ValidTime { get; set; }
        public double? SfcTempC { get; set; }
        public string MaxTempC { get; set; }
        public string MinTempC { get; set; }

        public virtual WeatherTafForecast Forecast { get; set; }
    }
}
