using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class HelperBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public DateTime? DateRelease { get; set; }
        public int? PublisherId { get; set; }
        public string Issnprint { get; set; }
        public string Issnelectronic { get; set; }
        public string Doi { get; set; }
        public string Pages { get; set; }
        public int CategoryId { get; set; }
        public int? CustomerId { get; set; }
        public string Category { get; set; }
        public string Publisher { get; set; }
        public string PublisherWebsite { get; set; }
        public DateTime? DateCreate { get; set; }
        public string Abstract { get; set; }
        public string ImageUrl { get; set; }
        public DateTime? DateExposure { get; set; }
        public int IsExposed { get; set; }
    }
}
