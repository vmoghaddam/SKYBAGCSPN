using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewFlightPlanCalanderCrew
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int? CalanderId { get; set; }
        public int? FlightPlanId { get; set; }
        public int GroupId { get; set; }
        public int? AvStatusId { get; set; }
        public string AvStatus { get; set; }
        public string JobGroup { get; set; }
        public string JobGroupCode { get; set; }
        public string Remark { get; set; }
        public int? BoxId { get; set; }
        public int? FlightPlanItemId { get; set; }
        public string Pid { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int PersonId { get; set; }
        public DateTime? DateJoinCompany { get; set; }
        public int? ExpCompany { get; set; }
        public DateTime? DateRegister { get; set; }
        public DateTime? DateConfirmed { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string Username { get; set; }
        public int? CustomerId { get; set; }
        public int MarriageId { get; set; }
        public string Nid { get; set; }
        public int SexId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateBirth { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string FaxTelNumber { get; set; }
        public string PassportNumber { get; set; }
        public DateTime? DatePassportExpire { get; set; }
        public DateTime? DatePassportIssue { get; set; }
        public string Address { get; set; }
        public DateTime? DateJoinAvation { get; set; }
        public int? Exp { get; set; }
        public DateTime? DateLastCheckUp { get; set; }
        public DateTime? DateNextCheckUp { get; set; }
        public DateTime? DateYearOfExperience { get; set; }
        public string CaoCardNumber { get; set; }
        public DateTime? DateCaoCardIssue { get; set; }
        public string CompetencyNo { get; set; }
        public int? CaoInterval { get; set; }
        public DateTime? DateCaoCardExpire { get; set; }
        public string Pplnumber { get; set; }
        public DateTime? PpldateIssue { get; set; }
        public DateTime? PpldateExpire { get; set; }
        public int? PplexpireStatus { get; set; }
        public string Cplnumber { get; set; }
        public DateTime? CpldateIssue { get; set; }
        public DateTime? CpldateExpire { get; set; }
        public int? CplexpireStatus { get; set; }
        public string Atplnumber { get; set; }
        public DateTime? AtpldateIssue { get; set; }
        public DateTime? AtpldateExpire { get; set; }
        public int? AtplexpireStatus { get; set; }
        public string Mccnumber { get; set; }
        public DateTime? MccdateIssue { get; set; }
        public DateTime? MccdateExpire { get; set; }
        public int? MccexpireStatus { get; set; }
        public int? CurrentLocationAirportId { get; set; }
        public string CurrentLocationAirporIata { get; set; }
        public int IsMedicalExpired { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
        public int? FromAirportId { get; set; }
        public int? ToAirportId { get; set; }
        public string Flights { get; set; }
        public DateTime? Date { get; set; }
        public string FromAirportIata { get; set; }
        public string ToAirportIata { get; set; }
    }
}
