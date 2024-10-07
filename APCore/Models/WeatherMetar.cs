using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class WeatherMetar
    {
        public WeatherMetar()
        {
            WeatherMetarQualityControls = new HashSet<WeatherMetarQualityControl>();
            WeatherMetarSkyConditions = new HashSet<WeatherMetarSkyCondition>();
        }

        public int Id { get; set; }
        public DateTime? DateCreate { get; set; }
        public string StationId { get; set; }
        public string RawText { get; set; }
        public DateTime? ObservationTime { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public double? TempC { get; set; }
        public double? DewpointC { get; set; }
        public int? WindDirDegrees { get; set; }
        public int? WindSpeedKt { get; set; }
        public int? WindGustKt { get; set; }
        public double? VisibilityStatuteMi { get; set; }
        public double? AltimInHg { get; set; }
        public double? SeaLevelPressureMb { get; set; }
        public string FlightCategory { get; set; }
        public double? ThreeHrPressureTendencyMb { get; set; }
        public double? MaxTC { get; set; }
        public double? MinTC { get; set; }
        public double? MaxT24hrC { get; set; }
        public double? MinT24hrC { get; set; }
        public double? PrecipIn { get; set; }
        public double? Pcp3hrIn { get; set; }
        public double? Pcp6hrIn { get; set; }
        public double? Pcp24hrIn { get; set; }
        public double? SnowIn { get; set; }
        public int? VertVisFt { get; set; }
        public string MetarType { get; set; }
        public double? ElevationM { get; set; }
        public DateTime? DateDay { get; set; }
        public int? FlightId { get; set; }
        public int? Fdpid { get; set; }

        public virtual ICollection<WeatherMetarQualityControl> WeatherMetarQualityControls { get; set; }
        public virtual ICollection<WeatherMetarSkyCondition> WeatherMetarSkyConditions { get; set; }
    }
}
