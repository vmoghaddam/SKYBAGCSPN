using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class EfbvoyageReport
    {
        public EfbvoyageReport()
        {
            EfbflightIrregularities = new HashSet<EfbflightIrregularity>();
            Efbreasons = new HashSet<Efbreason>();
        }

        public int Id { get; set; }
        public int? FlightId { get; set; }
        public string Route { get; set; }
        public int? RestReduction { get; set; }
        public int? DutyExtention { get; set; }
        public string Report { get; set; }
        public DateTime? DatePicsignature { get; set; }
        public int? ActionedById { get; set; }
        public DateTime? DateActioned { get; set; }
        public DateTime? DateConfirmed { get; set; }
        public int? DepDelay { get; set; }
        public string DateUpdate { get; set; }
        public string User { get; set; }
        public string JlsignedBy { get; set; }
        public DateTime? JldatePicapproved { get; set; }
        public int? Picid { get; set; }
        public string Pic { get; set; }
        public string Opsremark { get; set; }
        public DateTime? OpsremarkDate { get; set; }
        public int? Opsid { get; set; }
        public DateTime? OpsconfirmDate { get; set; }
        public string OpsstaffRemark { get; set; }
        public DateTime? OpsstaffDateVisit { get; set; }
        public DateTime? OpsstaffConfirmDate { get; set; }
        public int? OpsstaffId { get; set; }
        public DateTime? OpsstaffRemarkDate { get; set; }
        public string Opsuser { get; set; }
        public string OpsstaffUser { get; set; }
        public int? OpsstatusId { get; set; }
        public int? OpsstaffStatusId { get; set; }

        public virtual ICollection<EfbflightIrregularity> EfbflightIrregularities { get; set; }
        public virtual ICollection<Efbreason> Efbreasons { get; set; }
    }
}
