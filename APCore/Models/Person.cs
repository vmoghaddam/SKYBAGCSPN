using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class Person
    {
        public Person()
        {
            PersonAircraftTypes = new HashSet<PersonAircraftType>();
            PersonCaoLicenceHistories = new HashSet<PersonCaoLicenceHistory>();
            PersonCaoLicenses = new HashSet<PersonCaoLicense>();
            PersonCourses = new HashSet<PersonCourse>();
            PersonCustomers = new HashSet<PersonCustomer>();
            PersonDocuments = new HashSet<PersonDocument>();
            PersonEducations = new HashSet<PersonEducation>();
            PersonExperienses = new HashSet<PersonExperiense>();
            PersonRatings = new HashSet<PersonRating>();
        }

        public int Id { get; set; }
        public DateTime DateCreate { get; set; }
        public int MarriageId { get; set; }
        public string Nid { get; set; }
        public int SexId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateBirth { get; set; }
        public string Email { get; set; }
        public string EmailPassword { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Mobile { get; set; }
        public string FaxTelNumber { get; set; }
        public string PassportNumber { get; set; }
        public DateTime? DatePassportIssue { get; set; }
        public DateTime? DatePassportExpire { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DateJoinAvation { get; set; }
        public DateTime? DateLastCheckUp { get; set; }
        public DateTime? DateNextCheckUp { get; set; }
        public DateTime? DateYearOfExperience { get; set; }
        public string CaoCardNumber { get; set; }
        public DateTime? DateCaoCardIssue { get; set; }
        public DateTime? DateCaoCardExpire { get; set; }
        public string CompetencyNo { get; set; }
        public int? CaoInterval { get; set; }
        public int? CaoIntervalCalanderTypeId { get; set; }
        public bool IsDeleted { get; set; }
        public string Remark { get; set; }
        public string StampNumber { get; set; }
        public string StampUrl { get; set; }
        public string TechLogNo { get; set; }
        public DateTime? DateIssueNdt { get; set; }
        public int? IntervalNdt { get; set; }
        public string Ndtnumber { get; set; }
        public int? NdtintervalCalanderTypeId { get; set; }
        public bool? IsAuditor { get; set; }
        public bool? IsAuditee { get; set; }
        public string Nickname { get; set; }
        public int? CityId { get; set; }
        public string FatherName { get; set; }
        public string Idno { get; set; }
        public Guid? RowId { get; set; }
        public string UserId { get; set; }
        public string ImageUrl { get; set; }
        public int? CustomerCreatorId { get; set; }
        public DateTime? DateExpireNdt { get; set; }
        public DateTime? ProficiencyExpireDate { get; set; }
        public DateTime? CrewMemberCertificateExpireDate { get; set; }
        public DateTime? LicenceExpireDate { get; set; }
        public DateTime? SimulatorLastCheck { get; set; }
        public DateTime? SimulatorNextCheck { get; set; }
        public string RampPassNo { get; set; }
        public DateTime? RampPassExpireDate { get; set; }
        public DateTime? LanguageCourseExpireDate { get; set; }
        public string LicenceTitle { get; set; }
        public DateTime? LicenceInitialIssue { get; set; }
        public string RaitingCertificates { get; set; }
        public DateTime? LicenceIssueDate { get; set; }
        public string LicenceDescription { get; set; }
        public int? ProficiencyCheckType { get; set; }
        public DateTime? ProficiencyCheckDate { get; set; }
        public DateTime? ProficiencyValidUntil { get; set; }
        public int? Icaolprlevel { get; set; }
        public DateTime? IcaolprvalidUntil { get; set; }
        public int? MedicalClass { get; set; }
        public string CmcemployedBy { get; set; }
        public string Cmcoccupation { get; set; }
        public string PostalCode { get; set; }
        public bool? ProficiencyIpc { get; set; }
        public bool? ProficiencyOpc { get; set; }
        public string MedicalLimitation { get; set; }
        public string ProficiencyDescription { get; set; }
        public DateTime? VisaExpireDate { get; set; }
        public DateTime? SeptissueDate { get; set; }
        public DateTime? SeptexpireDate { get; set; }
        public DateTime? DangerousGoodsIssueDate { get; set; }
        public DateTime? DangerousGoodsExpireDate { get; set; }
        public DateTime? CcrmissueDate { get; set; }
        public DateTime? CcrmexpireDate { get; set; }
        public DateTime? CrmissueDate { get; set; }
        public DateTime? CrmexpireDate { get; set; }
        public DateTime? SmsissueDate { get; set; }
        public DateTime? SmsexpireDate { get; set; }
        public DateTime? AviationSecurityIssueDate { get; set; }
        public DateTime? AviationSecurityExpireDate { get; set; }
        public DateTime? EgpwsissueDate { get; set; }
        public DateTime? EgpwsexpireDate { get; set; }
        public DateTime? UpsetRecoveryTrainingIssueDate { get; set; }
        public DateTime? UpsetRecoveryTrainingExpireDate { get; set; }
        public DateTime? ColdWeatherOperationIssueDate { get; set; }
        public DateTime? HotWeatherOperationIssueDate { get; set; }
        public DateTime? PbnrnavissueDate { get; set; }
        public DateTime? PbnrnavexpireDate { get; set; }
        public DateTime? ColdWeatherOperationExpireDate { get; set; }
        public DateTime? HotWeatherOperationExpireDate { get; set; }
        public string ScheduleName { get; set; }
        public string Code { get; set; }
        public DateTime? SeptpissueDate { get; set; }
        public DateTime? SeptpexpireDate { get; set; }
        public DateTime? FirstAidIssueDate { get; set; }
        public DateTime? FirstAidExpireDate { get; set; }
        public DateTime? LicenceIrexpireDate { get; set; }
        public int? RankId { get; set; }
        public string LinkedIn { get; set; }
        public string WhatsApp { get; set; }
        public string Telegram { get; set; }
        public int? AircraftTypeId { get; set; }
        public DateTime? DateTypeIssue { get; set; }
        public DateTime? DateTypeExpire { get; set; }
        public string ProficiencyDescriptionOpc { get; set; }
        public DateTime? ProficiencyCheckDateOpc { get; set; }
        public DateTime? ProficiencyValidUntilOpc { get; set; }
        public DateTime? DateTriexpired { get; set; }
        public DateTime? DateTreexpired { get; set; }
        public DateTime? LineIssueDate { get; set; }
        public DateTime? LineExpireDate { get; set; }
        public DateTime? RecurrentIssueDate { get; set; }
        public DateTime? RecurrentExpireDate { get; set; }
        public DateTime? FmtissueDate { get; set; }
        public DateTime? FmtexpireDate { get; set; }
        public bool? OtherAirline { get; set; }
        public string PfirstName { get; set; }
        public string PlastName { get; set; }
        public string MultiType { get; set; }
        public DateTime? TypeMdissueDate { get; set; }
        public DateTime? TypeMdexpireDate { get; set; }
        public DateTime? Type737IssueDate { get; set; }
        public DateTime? Type737ExpireDate { get; set; }
        public DateTime? TypeAirbusIssueDate { get; set; }
        public DateTime? TypeAirbusExpireDate { get; set; }
        public DateTime? TypeMdconversionIssueDate { get; set; }
        public DateTime? Type737ConversionIssueDate { get; set; }
        public DateTime? TypeAirbusConversionIssueDate { get; set; }
        public DateTime? LrcissueDate { get; set; }
        public DateTime? LrcexpireDate { get; set; }
        public DateTime? RspissueDate { get; set; }
        public DateTime? RspexpireDate { get; set; }
        public DateTime? CtuissueDate { get; set; }
        public DateTime? CtuexpireDate { get; set; }
        public DateTime? SaissueDate { get; set; }
        public DateTime? SaexpireDate { get; set; }
        public DateTime? HfissueDate { get; set; }
        public DateTime? HfexpireDate { get; set; }
        public DateTime? AsdissueDate { get; set; }
        public DateTime? AsdexpireDate { get; set; }
        public DateTime? GomissueDate { get; set; }
        public DateTime? GomexpireDate { get; set; }
        public DateTime? AsfissueDate { get; set; }
        public DateTime? AsfexpireDate { get; set; }
        public DateTime? CcissueDate { get; set; }
        public DateTime? CcexpireDate { get; set; }
        public DateTime? ErpissueDate { get; set; }
        public DateTime? ErpexpireDate { get; set; }
        public DateTime? MbissueDate { get; set; }
        public DateTime? MbexpireDate { get; set; }
        public DateTime? PsissueDate { get; set; }
        public DateTime? PsexpireDate { get; set; }
        public DateTime? AnnexissueDate { get; set; }
        public DateTime? AnnexexpireDate { get; set; }
        public DateTime? DrmissueDate { get; set; }
        public DateTime? DrmexpireDate { get; set; }
        public DateTime? FmtdissueDate { get; set; }
        public DateTime? FmtdexpireDate { get; set; }
        public DateTime? MelexpireDate { get; set; }
        public DateTime? MelissueDate { get; set; }
        public DateTime? MetissueDate { get; set; }
        public DateTime? MetexpireDate { get; set; }
        public DateTime? PerissueDate { get; set; }
        public DateTime? PerexpireDate { get; set; }
        public DateTime? Lpcc1expireDate { get; set; }
        public DateTime? Lpcc2expireDate { get; set; }
        public DateTime? Lpcc3expireDate { get; set; }
        public DateTime? Lpcc1issueDate { get; set; }
        public DateTime? Lpcc2issueDate { get; set; }
        public DateTime? Lpcc3issueDate { get; set; }
        public DateTime? Opcc1issueDate { get; set; }
        public DateTime? Opcc2issueDate { get; set; }
        public DateTime? Opcc3issueDate { get; set; }
        public DateTime? LineC1issueDate { get; set; }
        public DateTime? LineC2issueDate { get; set; }
        public DateTime? LineC3issueDate { get; set; }
        public DateTime? LineC1expireDate { get; set; }
        public DateTime? LineC2expireDate { get; set; }
        public DateTime? LineC3expireDate { get; set; }
        public DateTime? RampIssueDate { get; set; }
        public DateTime? RampExpireDate { get; set; }
        public DateTime? AcissueDate { get; set; }
        public DateTime? AcexpireDate { get; set; }
        public DateTime? UprtissueDate { get; set; }
        public DateTime? UprtexpireDate { get; set; }
        public DateTime? SfiissueDate { get; set; }
        public DateTime? SfiexpireDate { get; set; }
        public DateTime? SfeissueDate { get; set; }
        public DateTime? SfeexpireDate { get; set; }
        public DateTime? Tri2issueDate { get; set; }
        public DateTime? Tri2expireDate { get; set; }
        public DateTime? Tre2issueDate { get; set; }
        public DateTime? Tre2expireDate { get; set; }
        public DateTime? IriissueDate { get; set; }
        public DateTime? IriexpireDate { get; set; }
        public DateTime? IreissueDate { get; set; }
        public DateTime? IreexpireDate { get; set; }
        public DateTime? CriissueDate { get; set; }
        public DateTime? CriexpireDate { get; set; }
        public DateTime? CreissueDate { get; set; }
        public DateTime? CreexpireDate { get; set; }
        public DateTime? Sfi2issueDate { get; set; }
        public DateTime? Sfi2expireDate { get; set; }
        public DateTime? Sfe2issueDate { get; set; }
        public DateTime? Sfe2expireDate { get; set; }
        public DateTime? AirCrewIssueDate { get; set; }
        public DateTime? AirCrewExpireDate { get; set; }
        public DateTime? AirOpsIssueDate { get; set; }
        public DateTime? AirOpsExpireDate { get; set; }
        public DateTime? SopissueDate { get; set; }
        public DateTime? SopexpireDate { get; set; }
        public DateTime? Diff31IssueDate { get; set; }
        public DateTime? Diff31ExpireDate { get; set; }
        public DateTime? Diff34IssueDate { get; set; }
        public DateTime? Diff34ExpireDate { get; set; }
        public DateTime? Oma1issueDate { get; set; }
        public DateTime? Oma1expireDate { get; set; }
        public DateTime? Omb1issueDate { get; set; }
        public DateTime? Omb1expireDate { get; set; }
        public DateTime? Omc1issueDate { get; set; }
        public DateTime? Omc1expireDate { get; set; }
        public DateTime? Oma2issueDate { get; set; }
        public DateTime? Oma2expireDate { get; set; }
        public DateTime? Omb2issueDate { get; set; }
        public DateTime? Omb2expireDate { get; set; }
        public DateTime? Omc2issueDate { get; set; }
        public DateTime? Omc2expireDate { get; set; }
        public DateTime? Oma3issueDate { get; set; }
        public DateTime? Oma3expireDate { get; set; }
        public DateTime? Omb3issueDate { get; set; }
        public DateTime? Omb3expireDate { get; set; }
        public DateTime? Omc3issueDate { get; set; }
        public DateTime? Omc3expireDate { get; set; }
        public DateTime? MapIssueDate { get; set; }
        public DateTime? MapExpireDate { get; set; }
        public DateTime? ComResIssueDate { get; set; }
        public DateTime? ComResExpireDate { get; set; }
        public DateTime? Opcc1expireDate { get; set; }
        public DateTime? Opcc2expireDate { get; set; }
        public DateTime? Opcc3expireDate { get; set; }
        public DateTime? IssueDate1 { get; set; }
        public DateTime? ExpireDate1 { get; set; }
        public DateTime? IssueDate2 { get; set; }
        public DateTime? ExpireDate2 { get; set; }
        public DateTime? IssueDate3 { get; set; }
        public DateTime? ExpireDate3 { get; set; }
        public DateTime? IssueDate4 { get; set; }
        public DateTime? ExpireDate4 { get; set; }
        public DateTime? IssueDate5 { get; set; }
        public DateTime? ExpireDate5 { get; set; }
        public DateTime? IssueDate6 { get; set; }
        public DateTime? ExpireDate6 { get; set; }
        public DateTime? IssueDate7 { get; set; }
        public DateTime? ExpireDate7 { get; set; }
        public DateTime? IssueDate8 { get; set; }
        public DateTime? ExpireDate8 { get; set; }
        public DateTime? IssueDate9 { get; set; }
        public DateTime? ExpireDate9 { get; set; }
        public DateTime? IssueDate10 { get; set; }
        public DateTime? ExpireDate10 { get; set; }
        public string JobGroup { get; set; }
        public string Name { get; set; }
        public int? CrewId { get; set; }

        public virtual Option CaoIntervalCalanderType { get; set; }
        public virtual Option Marriage { get; set; }
        public virtual Option NdtintervalCalanderType { get; set; }
        public virtual ICollection<PersonAircraftType> PersonAircraftTypes { get; set; }
        public virtual ICollection<PersonCaoLicenceHistory> PersonCaoLicenceHistories { get; set; }
        public virtual ICollection<PersonCaoLicense> PersonCaoLicenses { get; set; }
        public virtual ICollection<PersonCourse> PersonCourses { get; set; }
        public virtual ICollection<PersonCustomer> PersonCustomers { get; set; }
        public virtual ICollection<PersonDocument> PersonDocuments { get; set; }
        public virtual ICollection<PersonEducation> PersonEducations { get; set; }
        public virtual ICollection<PersonExperiense> PersonExperienses { get; set; }
        public virtual ICollection<PersonRating> PersonRatings { get; set; }
    }
}
