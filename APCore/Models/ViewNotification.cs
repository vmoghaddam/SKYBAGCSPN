using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewNotification
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime DateSent { get; set; }
        public int? SenderId { get; set; }
        public string Sender { get; set; }
        public bool Sms { get; set; }
        public bool Email { get; set; }
        public bool App { get; set; }
        public DateTime? DateSmssent { get; set; }
        public int IsSmssent { get; set; }
        public DateTime? DateEmailSent { get; set; }
        public int IsEmailSent { get; set; }
        public DateTime? DateAppSent { get; set; }
        public int IsAppSent { get; set; }
        public string Smsissue { get; set; }
        public string EmailIssue { get; set; }
        public string AppIssue { get; set; }
        public DateTime? DateAppVisited { get; set; }
        public int TypeId { get; set; }
        public string Pid { get; set; }
        public string Nid { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string UserEmail { get; set; }
        public string Idno { get; set; }
        public int PersonId { get; set; }
        public string Type { get; set; }
        public int? ModuleId { get; set; }
        public string Subject { get; set; }
        public string Abstract { get; set; }
    }
}
