using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class Efbasr
    {
        public int FlightId { get; set; }
        public int? EventTypeId { get; set; }
        public DateTime? OccurrenceDate { get; set; }
        public bool? IsDay { get; set; }
        public string Squawk { get; set; }
        public decimal? FuelJettisoned { get; set; }
        public decimal? Altitude { get; set; }
        public double? Speed { get; set; }
        public decimal? Acweight { get; set; }
        public string TechLogPageNo { get; set; }
        public string TechLogItemNo { get; set; }
        public int? FlightPhaseId { get; set; }
        public string Locairport { get; set; }
        public string Locstand { get; set; }
        public string Locrunway { get; set; }
        public string Locgeolongtitude { get; set; }
        public string Locgeoaltitude { get; set; }
        public int? Metid { get; set; }
        public string ActualWx { get; set; }
        public int? SigxWxid { get; set; }
        public int? RunwayConditionId { get; set; }
        public string AcconfigAp { get; set; }
        public string AcconfigAthr { get; set; }
        public string AcconfigGear { get; set; }
        public string AcconfigFlap { get; set; }
        public string AcconfigSlat { get; set; }
        public string AcconfigSpoilers { get; set; }
        public string Summary { get; set; }
        public string Result { get; set; }
        public string OthersInfo { get; set; }
        public int? AatriskId { get; set; }
        public bool? AatisActionTaken { get; set; }
        public string AatreportedToAtc { get; set; }
        public string Aatatcinstruction { get; set; }
        public string Aatfrequency { get; set; }
        public decimal? Aatheading { get; set; }
        public string AatclearedAltitude { get; set; }
        public string AatminVerticalSep { get; set; }
        public string AatminHorizontalSep { get; set; }
        public int? AattcasalertId { get; set; }
        public string AattypeRa { get; set; }
        public bool? AatisRafollowed { get; set; }
        public string AatverticalDeviation { get; set; }
        public string AatotherActype { get; set; }
        public string AatmarkingColour { get; set; }
        public string AatcallSign { get; set; }
        public string Aatlighting { get; set; }
        public decimal? Wtheading { get; set; }
        public int? WtturningId { get; set; }
        public int? WtglideSlopePosId { get; set; }
        public int? WtextendedCenterlinePosId { get; set; }
        public int? WtattitudeChangeId { get; set; }
        public decimal? WtattitudeChangeDeg { get; set; }
        public bool? WtisBuffet { get; set; }
        public bool? WtisStickShaker { get; set; }
        public string Wtsuspect { get; set; }
        public string WtdescribeVa { get; set; }
        public string WtprecedingAc { get; set; }
        public bool? WtisAware { get; set; }
        public string BsbirdType { get; set; }
        public int? BsnrSeenId { get; set; }
        public int? BsnrStruckId { get; set; }
        public int? BstimeId { get; set; }
        public DateTime? Picdate { get; set; }
        public int Id { get; set; }
        public int? DayNightStatusId { get; set; }
        public int? IncidentTypeId { get; set; }
        public int? Aatxabove { get; set; }
        public int? Aatyabove { get; set; }
        public int? Aatxastern { get; set; }
        public int? Aatyastern { get; set; }
        public int? AathorizontalPlane { get; set; }
        public string BsimpactDec { get; set; }
        public bool? IsSecurityEvent { get; set; }
        public bool? IsAirproxAtc { get; set; }
        public bool? IsTcasra { get; set; }
        public bool? IsWakeTur { get; set; }
        public bool? IsBirdStrike { get; set; }
        public bool? IsOthers { get; set; }
        public double? MachNo { get; set; }
        public int? SigxWxtypeId { get; set; }
        public double? Bsheading { get; set; }
        public int? BsturningId { get; set; }
        public string DateUpdate { get; set; }
        public string User { get; set; }
        public string JlsignedBy { get; set; }
        public DateTime? JldatePicapproved { get; set; }
        public int? Picid { get; set; }
        public string Pic { get; set; }
        public DateTime? OpsstaffRemarkDate { get; set; }
        public string Opsuser { get; set; }
        public string OpsstaffUser { get; set; }
        public int? OpsstatusId { get; set; }
        public int? OpsstaffStatusId { get; set; }
        public string Opsremark { get; set; }
        public DateTime? OpsremarkDate { get; set; }
        public int? Opsid { get; set; }
        public DateTime? OpsconfirmDate { get; set; }
        public string OpsstaffRemark { get; set; }
        public DateTime? OpsstaffDateVisit { get; set; }
        public DateTime? OpsstaffConfirmDate { get; set; }
        public int? OpsstaffId { get; set; }
    }
}
