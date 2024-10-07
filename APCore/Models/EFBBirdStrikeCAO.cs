using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class EfbbirdStrikeCao
    {
        public int Id { get; set; }
        public int? FlightId { get; set; }
        public int? OperatorId { get; set; }
        public string EngineModel { get; set; }
        public DateTime? Date { get; set; }
        public int? LocalTimeId { get; set; }
        public string AerodromeName { get; set; }
        public string RunwayUsed { get; set; }
        public string EnRouteLoc { get; set; }
        public decimal? HeightAgl { get; set; }
        public decimal? SpeedIas { get; set; }
        public int? PhaseOrFlightId { get; set; }
        public int? ACpartRadom { get; set; }
        public int? ACpartWindShield { get; set; }
        public int? ACpartNose { get; set; }
        public int? ACpartEngineNo1 { get; set; }
        public int? ACpartEngineNo2 { get; set; }
        public int? ACpartEngineNo3 { get; set; }
        public int? ACpartEngineNo4 { get; set; }
        public int? ACpartPropeller { get; set; }
        public int? ACpartWingRotor { get; set; }
        public int? ACpartFuselage { get; set; }
        public int? ACpartLandingGear { get; set; }
        public int? ACpartTail { get; set; }
        public int? ACpartLight { get; set; }
        public int? ACpartOtherSpecify { get; set; }
        public bool? IsEffectNone { get; set; }
        public bool? IsEffectAbortedTakeOff { get; set; }
        public bool? IsEffectLanding { get; set; }
        public bool? IsEffectEngineShutDown { get; set; }
        public bool? IsEffectOther { get; set; }
        public int? SkyConditionId { get; set; }
        public int? IsPrecipitationFog { get; set; }
        public int? IsPrecipitationRain { get; set; }
        public int? IsPrecipitationSnow { get; set; }
        public string BirdSpecies { get; set; }
        public int? BirdNrSeenId { get; set; }
        public int? BirdNrStruckId { get; set; }
        public int? BirdSizeId { get; set; }
        public bool? IspilotWarned { get; set; }
        public string Remarks { get; set; }
        public int? ReportedById { get; set; }
    }
}
