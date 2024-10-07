using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewDelayDailyAirport
    {
        public DateTime? Date { get; set; }
        public string DayName { get; set; }
        public string YearName { get; set; }
        public string Pdate { get; set; }
        public string PyearName { get; set; }
        public string PmonthName { get; set; }
        public string PdayName { get; set; }
        public string Airport { get; set; }
        public int Delay { get; set; }
        public int Count { get; set; }
        public int? TotalFlights { get; set; }
        public int BlockTime { get; set; }
        public int FlightTime { get; set; }
        public double? DelayLeg { get; set; }
        public double? DelayRatio { get; set; }
        public double? Trnd { get; set; }
        public double? Trndleg { get; set; }
    }
}
