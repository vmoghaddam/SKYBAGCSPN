using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class FlightInformation1
    {
        public FlightInformation1()
        {
            Efbdspreleases = new HashSet<Efbdsprelease>();
            Fdpitems = new HashSet<Fdpitem>();
            FlightCrews = new HashSet<FlightCrew>();
            FlightDelays = new HashSet<FlightDelay>();
            FlightLinkFlight1s = new HashSet<FlightLink>();
            FlightLinkFlight2s = new HashSet<FlightLink>();
            FlightStatusLogs = new HashSet<FlightStatusLog>();
            FlightStatusWeathers = new HashSet<FlightStatusWeather>();
            FltgroupItems = new HashSet<FltgroupItem>();
            Mvtapis = new HashSet<Mvtapi>();
            Mvts = new HashSet<Mvt>();
            OffItems = new HashSet<OffItem>();
        }

        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? RegisterId { get; set; }
        public int? FlightTypeId { get; set; }
        public int? FlightStatusId { get; set; }
        public int? AirlineOperatorsId { get; set; }
        public int? FlightGroupId { get; set; }
        public string FlightNumber { get; set; }
        public int? FromAirportId { get; set; }
        public int? ToAirportId { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
        public DateTime? ChocksOut { get; set; }
        public DateTime? Takeoff { get; set; }
        public DateTime? Landing { get; set; }
        public DateTime? ChocksIn { get; set; }
        public int? FlightH { get; set; }
        public byte? FlightM { get; set; }
        public int? BlockH { get; set; }
        public byte? BlockM { get; set; }
        public decimal? Gwto { get; set; }
        public decimal? Gwland { get; set; }
        public decimal? FuelPlanned { get; set; }
        public decimal? FuelActual { get; set; }
        public decimal? FuelDeparture { get; set; }
        public decimal? FuelArrival { get; set; }
        public int? PaxAdult { get; set; }
        public int? PaxInfant { get; set; }
        public int? PaxChild { get; set; }
        public int? CargoWeight { get; set; }
        public int? CargoUnitId { get; set; }
        public int? BaggageCount { get; set; }
        public int? CustomerId { get; set; }
        public int? FlightPlanId { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? CargoCount { get; set; }
        public int? BaggageWeight { get; set; }
        public int? FuelUnitId { get; set; }
        public string ArrivalRemark { get; set; }
        public string DepartureRemark { get; set; }
        public int? EstimatedDelay { get; set; }
        public int? FlightStatusUserId { get; set; }
        public int? CancelReasonId { get; set; }
        public string CancelRemark { get; set; }
        public DateTime? CancelDate { get; set; }
        public int? OtoAirportId { get; set; }
        public DateTime? Osta { get; set; }
        public string OtoAirportIata { get; set; }
        public int? RedirectReasonId { get; set; }
        public string RedirectRemark { get; set; }
        public DateTime? RedirectDate { get; set; }
        public bool? IsApplied { get; set; }
        public DateTime? DateApplied { get; set; }
        public int? FlightPlanRegisterId { get; set; }
        public int? CalendarId { get; set; }
        public int? BoxId { get; set; }
        public int? RampReasonId { get; set; }
        public string RampRemark { get; set; }
        public DateTime? RampDate { get; set; }
        public int? FpflightHh { get; set; }
        public int? FpflightMm { get; set; }
        public decimal? Fpfuel { get; set; }
        public decimal? Defuel { get; set; }
        public bool? SplitDuty { get; set; }
        public decimal? UsedFuel { get; set; }
        public int? Jlblhh { get; set; }
        public int? Jlblmm { get; set; }
        public int? Pflr { get; set; }
        public int? CpcrewId { get; set; }
        public string Cpregister { get; set; }
        public int? CppositionId { get; set; }
        public int? CpflightTypeId { get; set; }
        public int? CpfdpitemId { get; set; }
        public bool? Cpdh { get; set; }
        public int? Cpfdpid { get; set; }
        public string Cpinstructor { get; set; }
        public string Cpp1 { get; set; }
        public string Cpp2 { get; set; }
        public string Cpsccm { get; set; }
        public string Cpisccm { get; set; }
        public int? NightTime { get; set; }
        public DateTime? JloffBlock { get; set; }
        public DateTime? JlonBlock { get; set; }
        public DateTime? JltakeOff { get; set; }
        public DateTime? Jllanding { get; set; }
        public int? NotifiedDelay { get; set; }
        public DateTime? FlightDate { get; set; }
        public string Updnote { get; set; }
        public Guid? Guid { get; set; }
        public int? JluserId { get; set; }
        public int? JlapproverId { get; set; }
        public DateTime? Jldate { get; set; }
        public DateTime? JldateApproved { get; set; }
        public string Jlno { get; set; }
        public string SerialNo { get; set; }
        public string Ltr { get; set; }
        public decimal? RvsmGndCpt { get; set; }
        public decimal? RvsmGndStby { get; set; }
        public decimal? RvsmGndFo { get; set; }
        public decimal? RvsmFltCpt { get; set; }
        public decimal? RvsmFltStby { get; set; }
        public decimal? RvsmFltFo { get; set; }
        public decimal? Cargo { get; set; }
        public decimal? FuelDensity { get; set; }
        public string CommanderNote { get; set; }
        public bool? AttAsr { get; set; }
        public bool? AttVoyageReport { get; set; }
        public bool? AttRepositioning1 { get; set; }
        public bool? AttRepositioning2 { get; set; }
        public int? Version { get; set; }
        public bool? IsSynced { get; set; }
        public string Pf { get; set; }
        public string Pic { get; set; }
        public int? Picid { get; set; }
        public string Sic { get; set; }
        public int? Sicid { get; set; }
        public DateTime? JldatePicapproved { get; set; }
        public string JlsignedBy { get; set; }
        public string Alt1 { get; set; }
        public string Alt2 { get; set; }
        public string Alt3 { get; set; }
        public string Alt4 { get; set; }
        public string Alt5 { get; set; }
        public int? Utcdiff { get; set; }
        public decimal? FptripFuel { get; set; }
        public string Atcplan { get; set; }
        public string Atl { get; set; }
        public string ChrCode { get; set; }
        public string ChrTitle { get; set; }
        public int? ChrAdult { get; set; }
        public int? ChrChild { get; set; }
        public int? ChrInfant { get; set; }
        public int? ChrCapacity { get; set; }
        public string Charterer { get; set; }
        public int? Ttl { get; set; }
        public int? Dow { get; set; }
        public decimal? Zfw { get; set; }
        public decimal? Tow { get; set; }
        public decimal? Lnw { get; set; }
        public decimal? Doi { get; set; }
        public decimal? Lizfw { get; set; }
        public decimal? Litow { get; set; }
        public decimal? Lilnw { get; set; }
        public decimal? Dli { get; set; }
        public decimal? Maczfw { get; set; }
        public decimal? Mactow { get; set; }
        public decimal? Maclnw { get; set; }
        public int? Maxtow { get; set; }
        public int? Cpt1 { get; set; }
        public int? Cpt2 { get; set; }
        public int? Cpt3 { get; set; }
        public int? Cpt4 { get; set; }
        public string PantryCode { get; set; }
        public decimal? StabTrimFive { get; set; }
        public decimal? StabTrimFifteen { get; set; }
        public int? Fso { get; set; }
        public int? Fm { get; set; }
        public int? Pilot { get; set; }
        public int? Cabin { get; set; }
        public int? Oasec { get; set; }
        public int? Obsec { get; set; }
        public int? Ocsec { get; set; }
        public int? Odsec { get; set; }
        public int? Maxzfw { get; set; }
        public int? Maxlnw { get; set; }
        public long? CargoCost { get; set; }

        public virtual Organization AirlineOperators { get; set; }
        public virtual Box Box { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual FlightGroup FlightGroup { get; set; }
        public virtual FlightPlanItem FlightPlan { get; set; }
        public virtual FlightStatus FlightStatus { get; set; }
        public virtual Airport FromAirport { get; set; }
        public virtual AcMsn Register { get; set; }
        public virtual Airport ToAirport { get; set; }
        public virtual AircraftType Type { get; set; }
        public virtual ICollection<Efbdsprelease> Efbdspreleases { get; set; }
        public virtual ICollection<Fdpitem> Fdpitems { get; set; }
        public virtual ICollection<FlightCrew> FlightCrews { get; set; }
        public virtual ICollection<FlightDelay> FlightDelays { get; set; }
        public virtual ICollection<FlightLink> FlightLinkFlight1s { get; set; }
        public virtual ICollection<FlightLink> FlightLinkFlight2s { get; set; }
        public virtual ICollection<FlightStatusLog> FlightStatusLogs { get; set; }
        public virtual ICollection<FlightStatusWeather> FlightStatusWeathers { get; set; }
        public virtual ICollection<FltgroupItem> FltgroupItems { get; set; }
        public virtual ICollection<Mvtapi> Mvtapis { get; set; }
        public virtual ICollection<Mvt> Mvts { get; set; }
        public virtual ICollection<OffItem> OffItems { get; set; }
    }
}
