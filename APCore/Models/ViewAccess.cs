using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewAccess
    {
        public string UserName { get; set; }
        public string Roleid { get; set; }
        public string Role { get; set; }
        public string Application { get; set; }
        public string Type { get; set; }
        public string Group { get; set; }
        public string Ips { get; set; }
        public bool Disabled { get; set; }
    }
}
