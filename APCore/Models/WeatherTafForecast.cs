using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class WeatherTafForecast
    {
        public WeatherTafForecast()
        {
            WeatherForecastIcingConditions = new HashSet<WeatherForecastIcingCondition>();
            WeatherForecastSkyConditions = new HashSet<WeatherForecastSkyCondition>();
            WeatherForecastTemperatures = new HashSet<WeatherForecastTemperature>();
            WeatherForecastTurbulences = new HashSet<WeatherForecastTurbulence>();
        }

        public int Id { get; set; }
        public DateTime? FcstTimeFrom { get; set; }
        public DateTime? FcstTimeTo { get; set; }
        public string ChangeIndicator { get; set; }
        public DateTime? TimeBecoming { get; set; }
        public double? Probability { get; set; }
        public double? WindDirDegrees { get; set; }
        public double? WindSpeedKt { get; set; }
        public double? WindGustKt { get; set; }
        public double? WindShearHgtFtAgl { get; set; }
        public double? WindShearDirDegrees { get; set; }
        public double? WindShearSpeedKt { get; set; }
        public double? VisibilityStatuteMi { get; set; }
        public double? AltimInHg { get; set; }
        public double? VertVisFt { get; set; }
        public string WxString { get; set; }
        public string NotDecoded { get; set; }
        public int WeatherId { get; set; }

        public virtual WeatherTaf Weather { get; set; }
        public virtual ICollection<WeatherForecastIcingCondition> WeatherForecastIcingConditions { get; set; }
        public virtual ICollection<WeatherForecastSkyCondition> WeatherForecastSkyConditions { get; set; }
        public virtual ICollection<WeatherForecastTemperature> WeatherForecastTemperatures { get; set; }
        public virtual ICollection<WeatherForecastTurbulence> WeatherForecastTurbulences { get; set; }
    }
}
