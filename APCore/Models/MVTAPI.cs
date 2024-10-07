using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class Mvtapi
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public string Type { get; set; }
        public string FlightNo { get; set; }
        public int? DayOfMonth { get; set; }
        public string Register { get; set; }
        public string FromIata { get; set; }
        public DateTime? OffBlock { get; set; }
        public DateTime? TakeOff { get; set; }
        public DateTime? Eta { get; set; }
        public string ToIata { get; set; }
        public string Pax { get; set; }
        public string Bag { get; set; }
        public string Cpt { get; set; }
        public string Dl { get; set; }
        public string Message { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateSent { get; set; }
        public string UserName { get; set; }
        public string SendTo { get; set; }
        public string SendFrom { get; set; }
        public DateTime? OnBlock { get; set; }

        public virtual FlightInformation1 Flight { get; set; }
    }
}
