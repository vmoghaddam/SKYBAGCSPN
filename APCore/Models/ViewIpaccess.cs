using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewIpaccess
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public string UserId { get; set; }
        public bool? Role { get; set; }
        public string UserName { get; set; }
    }
}
