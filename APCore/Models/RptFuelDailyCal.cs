using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class RptFuelDailyCal
    {
        public string Date { get; set; }
        public string ArgStr { get; set; }
        public int? ArgNum { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public string MonthName { get; set; }
        public string DayName { get; set; }
        public int? Legs { get; set; }
        public decimal Uplift { get; set; }
        public decimal Used { get; set; }
        public decimal PreUsed { get; set; }
        public decimal? UpliftKilo { get; set; }
        public decimal? UsedKilo { get; set; }
        public decimal? UpliftPerLeg { get; set; }
        public decimal? UsedPerLeg { get; set; }
        public decimal? UpliftKiloPerLeg { get; set; }
        public decimal? UsedKiloPerLeg { get; set; }
        public int TotalPax { get; set; }
        public int TotalPaxAll { get; set; }
        public double Distance { get; set; }
        public double DistanceKm { get; set; }
        public int Weight { get; set; }
        public decimal WeightTone { get; set; }
        public int PaxWeight { get; set; }
        public decimal PaxWeightTone { get; set; }
        public double WeightDistance { get; set; }
        public double WeightDistanceToneKm { get; set; }
        public decimal? UpliftPerPax { get; set; }
        public DateTime? LocalDate { get; set; }
        public decimal? UpliftPerWeight { get; set; }
        public double? UpliftPerDistance { get; set; }
        public double? UpliftPerDistanceKm { get; set; }
        public double? UpliftPerWeightDistance { get; set; }
        public double? UpliftPerWeightDistanceKm { get; set; }
        public decimal? UsedPerPax { get; set; }
        public decimal? UsedPerWeight { get; set; }
        public double? UsedPerDistance { get; set; }
        public double? UsedPerDistanceKm { get; set; }
        public double? UsedPerWeightDistance { get; set; }
        public double? UsedPerWeightDistanceKm { get; set; }
        public decimal? UsedDiff { get; set; }
        public decimal? UsedDiffPerLeg { get; set; }
        public decimal? UsedDiffPerPax { get; set; }
        public decimal? UsedDiffPerWeight { get; set; }
        public double? UsedDiffPerDistance { get; set; }
        public double? UsedDiffPerWeightDistance { get; set; }
        public decimal? UsedDiffPercent { get; set; }
        public decimal? UsedDiffPerLegPercent { get; set; }
        public decimal? UsedDiffPerPaxPercent { get; set; }
        public decimal? UsedDiffPerWeightPercent { get; set; }
        public double? UsedDiffPerDistancePercent { get; set; }
        public double? UsedDiffPerWeightDistancePercent { get; set; }
        public double? UsedPerWeightDistanceToneKm { get; set; }
    }
}
