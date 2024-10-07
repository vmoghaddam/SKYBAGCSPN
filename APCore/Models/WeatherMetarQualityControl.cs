using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class WeatherMetarQualityControl
    {
        public int Id { get; set; }
        public int MetarId { get; set; }
        public string Corrected { get; set; }
        public string Auto { get; set; }
        public string AutoStation { get; set; }
        public string MaintenanceIndicatorOn { get; set; }
        public string NoSignal { get; set; }
        public string LightningSensorOff { get; set; }
        public string FreezingRainSensorOff { get; set; }
        public string PresentWeatherSensorOff { get; set; }

        public virtual WeatherMetar Metar { get; set; }
    }
}
