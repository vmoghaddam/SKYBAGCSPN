using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewCrewValidFtl
    {
        public int Id { get; set; }
        public int SexId { get; set; }
        public string Pid { get; set; }
        public int PersonId { get; set; }
        public int? CustomerId { get; set; }
        public int? GroupId { get; set; }
        public string JobGroup { get; set; }
        public string JobGroupCode { get; set; }
        public string Position { get; set; }
        public int PositionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public int? CurrentLocationAirportId { get; set; }
        public string CurrentLocationAirporIata { get; set; }
        public string CurrentLocationCity { get; set; }
        public int? CurrentLocationCityId { get; set; }
        public int? LastLocationId { get; set; }
        public string LastLocation { get; set; }
        public string ScheduleName { get; set; }
        public string Code { get; set; }
        public string ValidationMessage { get; set; }
        public int Flight { get; set; }
        public int GroupOrder { get; set; }
        public DateTime DateInactiveBegin { get; set; }
        public DateTime DateInactiveEnd { get; set; }
        public int? StandById { get; set; }
        public double? Duty1 { get; set; }
        public double? Duty7 { get; set; }
        public double? Duty14 { get; set; }
        public double? Duty28 { get; set; }
        public double? Flight1 { get; set; }
        public double? Flight28 { get; set; }
        public double? FlightYear { get; set; }
        public double? FlightCyear { get; set; }
        public int? BaseAirportId { get; set; }
        public int? AircraftTypeId { get; set; }
        public DateTime? DateTypeIssue { get; set; }
        public DateTime? DateTypeExpire { get; set; }
        public string ValidTypes { get; set; }
        public double FlightSum { get; set; }
        public int FlightEarly { get; set; }
        public int FlightLate { get; set; }
        public DateTime? MedicalExpired { get; set; }
        public DateTime? MedicalIssued { get; set; }
        public DateTime? Cmcexpired { get; set; }
        public DateTime? Septexpired { get; set; }
        public DateTime? Septissued { get; set; }
        public DateTime? Septpissued { get; set; }
        public DateTime? Septpexpired { get; set; }
        public DateTime? Dgexpired { get; set; }
        public DateTime? Dgissued { get; set; }
        public DateTime? Ccrmexpired { get; set; }
        public DateTime? Ccrmissued { get; set; }
        public DateTime? Crmissued { get; set; }
        public DateTime? Crmexpired { get; set; }
        public DateTime? Smsexpired { get; set; }
        public DateTime? Smsissued { get; set; }
        public DateTime? AvSecExpired { get; set; }
        public DateTime? AvSecIssued { get; set; }
        public DateTime? ColdWxissued { get; set; }
        public DateTime? HotWxissued { get; set; }
        public DateTime? ColdWxexpired { get; set; }
        public DateTime? HotWxexpired { get; set; }
        public DateTime? LineIssued { get; set; }
        public DateTime? LineExpired { get; set; }
        public DateTime? RecurrentIssued { get; set; }
        public DateTime? RecurrentExpired { get; set; }
        public DateTime? Lpcexpired { get; set; }
        public DateTime? Lpcissued { get; set; }
        public DateTime? Opcissued { get; set; }
        public DateTime? Opcexpired { get; set; }
        public DateTime? Lprexpired { get; set; }
        public DateTime? FirstAidExpired { get; set; }
        public DateTime? FirstAidIssued { get; set; }
        public DateTime? LicenceExpired { get; set; }
        public DateTime? LicenceIssued { get; set; }
        public DateTime? Treexpired { get; set; }
        public DateTime? Triexpired { get; set; }
    }
}
