﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewApplicableCoursePerson
    {
        public int CourseId { get; set; }
        public int PersonId { get; set; }
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
        public int? StatusId { get; set; }
        public DateTime? DateStatus { get; set; }
        public bool? StatusConfirmed { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public DateTime? DateIssue { get; set; }
        public string CerNumber { get; set; }
    }
}
