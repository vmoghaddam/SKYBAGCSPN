using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class Ofpimport
    {
        public Ofpimport()
        {
            OfpimportItems = new HashSet<OfpimportItem>();
            OfpimportProps = new HashSet<OfpimportProp>();
        }

        public int Id { get; set; }
        public string FileName { get; set; }
        public string FlightNo { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime? DateFlight { get; set; }
        public DateTime? DateCreate { get; set; }
        public string Text { get; set; }
        public string User { get; set; }
        public string TextOutput { get; set; }
        public int? FlightId { get; set; }
        public string DateUpdate { get; set; }
        public DateTime? DateConfirmed { get; set; }
        public string UserConfirmed { get; set; }
        public int? Picid { get; set; }
        public DateTime? JldatePicapproved { get; set; }
        public string JlsignedBy { get; set; }
        public string Pic { get; set; }
        public decimal? Fpfuel { get; set; }
        public decimal? FptripFuel { get; set; }

        public virtual ICollection<OfpimportItem> OfpimportItems { get; set; }
        public virtual ICollection<OfpimportProp> OfpimportProps { get; set; }
    }
}
