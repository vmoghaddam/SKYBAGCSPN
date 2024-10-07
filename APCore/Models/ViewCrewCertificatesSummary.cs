using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewCrewCertificatesSummary
    {
        public string Name { get; set; }
        public string JobGroup { get; set; }
        public string JobGroupCode { get; set; }
        public DateTime? MedicalLastCheckup { get; set; }
        public DateTime? MedicalNextChechup { get; set; }
        public int IsMedicalExpired { get; set; }
        public int? RemainMedical { get; set; }
        public DateTime? LprexpireDate { get; set; }
        public int IsLprexpired { get; set; }
        public int? RemainLpr { get; set; }
        public DateTime? ProficiencyCheckDate { get; set; }
        public DateTime? ProficiencyExpireDate { get; set; }
        public int? RemainProficiency { get; set; }
        public int IsProficiencyExpired { get; set; }
        public DateTime? CmcexpireDate { get; set; }
        public int? RemainCmc { get; set; }
        public int IsCmcexpired { get; set; }
        public DateTime? CcrmissueDate { get; set; }
        public DateTime? CcrmexpireDate { get; set; }
        public int? RemainCcrm { get; set; }
        public int IsCcrmexpired { get; set; }
        public DateTime? AvSecIssueDate { get; set; }
        public DateTime? AvSecExpireDate { get; set; }
        public int? RemainAvSec { get; set; }
        public int IsAvSecExpired { get; set; }
        public DateTime? SeptissueDate { get; set; }
        public DateTime? SeptexpireDate { get; set; }
        public int? RemainSept { get; set; }
        public int IsSeptexpired { get; set; }
        public DateTime? SeptpracticalIssueDate { get; set; }
        public DateTime? SeptpracticalExpireDate { get; set; }
        public int? RemainSeptp { get; set; }
        public int IsSeptpexpired { get; set; }
        public DateTime? DgissueDate { get; set; }
        public DateTime? DgexpireDate { get; set; }
        public int? RemainDg { get; set; }
        public int IsDgexpired { get; set; }
        public DateTime? SmsissueDate { get; set; }
        public DateTime? SmsexpireDate { get; set; }
        public int? RemainSms { get; set; }
        public int IsSmsexpired { get; set; }
        public DateTime? FirstAidIssueDate { get; set; }
        public DateTime? FirstAidExpireDate { get; set; }
        public int? RemainFirstAid { get; set; }
        public int IsFirstAidExpired { get; set; }
        public DateTime? ColdWeatherIssueDate { get; set; }
        public DateTime? ColdWeatherExpireDate { get; set; }
        public int? RemainColdWeather { get; set; }
        public int IsColdWeatherExpired { get; set; }
        public DateTime? HotWeatherIssueDate { get; set; }
        public DateTime? HotWeatherExpireDate { get; set; }
        public int? RemainHotWeather { get; set; }
        public int IsHotWeatherExpired { get; set; }
    }
}
