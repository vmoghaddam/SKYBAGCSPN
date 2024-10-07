using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewApplicableCourse
    {
        public int CourseId { get; set; }
        public int PersonId { get; set; }
        public string No { get; set; }
        public int CourseTypeId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public string Instructor { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public int? OrganizationId { get; set; }
        public int? Duration { get; set; }
        public int? CourseStatusId { get; set; }
        public int? DurationUnitId { get; set; }
        public string CourseRemark { get; set; }
        public int? Capacity { get; set; }
        public int? Tuition { get; set; }
        public int? CurrencyId { get; set; }
        public DateTime? DateDeadlineRegistration { get; set; }
        public string TrainingDirector { get; set; }
        public string Title { get; set; }
        public bool? Recurrent { get; set; }
        public int? Interval { get; set; }
        public int? CalanderTypeId { get; set; }
        public bool? IsInside { get; set; }
        public bool? Quarantine { get; set; }
        public DateTime? DateStartPractical { get; set; }
        public DateTime? DateEndPractical { get; set; }
        public int? DurationPractical { get; set; }
        public int? DurationPracticalUnitId { get; set; }
        public int? CtCalendarTypeId { get; set; }
        public string CtTitle { get; set; }
        public int? CtLicenseResultBasicId { get; set; }
        public string CtRemark { get; set; }
        public int? CtCourseCategoryId { get; set; }
        public int? CtInterval { get; set; }
        public bool? CtIsGeneral { get; set; }
        public bool? CtStatus { get; set; }
        public int? CtId { get; set; }
        public string CcTitle { get; set; }
        public string CaoTypeTitle { get; set; }
        public string CaoTypeRemark { get; set; }
        public string Organization { get; set; }
        public string DurationUnit { get; set; }
        public string Duration2 { get; set; }
        public string CourseStatus { get; set; }
        public string Currency { get; set; }
        public string CalendarType { get; set; }
        public string DurationPracticalUnit { get; set; }
        public int? Remain { get; set; }
        public DateTime? ExpireDate { get; set; }
        public bool? IsGeneral { get; set; }
        public int? CourseCustomerId { get; set; }
        public bool? LastCourse { get; set; }
        public string Pid { get; set; }
        public DateTime? DateJoinCompany { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int? CustomerId { get; set; }
        public int? GroupId { get; set; }
        public string JobGroup { get; set; }
        public string JobGroupCode { get; set; }
        public string Nid { get; set; }
        public int SexId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public DateTime? DateBirth { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Mobile { get; set; }
        public string FaxTelNumber { get; set; }
        public DateTime? DateJoinAvation { get; set; }
        public DateTime? DateYearOfExperience { get; set; }
        public string CaoCardNumber { get; set; }
        public DateTime? DateCaoCardIssue { get; set; }
        public DateTime? DateCaoCardExpire { get; set; }
        public string CompetencyNo { get; set; }
        public int? CaoInterval { get; set; }
        public int? CaoIntervalCalanderTypeId { get; set; }
        public string StampNumber { get; set; }
        public string StampUrl { get; set; }
        public string TechLogNo { get; set; }
        public DateTime? DateIssueNdt { get; set; }
        public int? IntervalNdt { get; set; }
        public string Ndtnumber { get; set; }
        public int? NdtintervalCalanderTypeId { get; set; }
        public string Idno { get; set; }
        public string ImageUrl { get; set; }
        public int? CustomerCreatorId { get; set; }
        public int? Age { get; set; }
        public string Sex { get; set; }
        public string CaoIntervalCalanderType { get; set; }
        public string NdtintervalCalanderType { get; set; }
        public string Customer { get; set; }
        public string Remark { get; set; }
        public string CerNumber { get; set; }
        public DateTime? DateIssue { get; set; }
        public int? StatusId { get; set; }
        public DateTime? DateStatus { get; set; }
        public bool? StatusConfirmed { get; set; }
        public string Status { get; set; }
    }
}
