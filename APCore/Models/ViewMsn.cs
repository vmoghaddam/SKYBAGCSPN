using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewMsn
    {
        public int Id { get; set; }
        public int? AcModelId { get; set; }
        public int AirlineOperatorsId { get; set; }
        public int? Msn { get; set; }
        public string Register { get; set; }
        public int? TfhHours { get; set; }
        public byte? TfhMinutes { get; set; }
        public int? Tfc { get; set; }
        public DateTime? ManDate { get; set; }
        public DateTime? LastWb { get; set; }
        public bool? Etops { get; set; }
        public bool? AcFlag { get; set; }
        public int? CabinSeatVerF { get; set; }
        public int? CabinSeatVerB { get; set; }
        public int? CabinSeatVerC { get; set; }
        public int? CabinSeatVerR { get; set; }
        public int? LavQty { get; set; }
        public int? GalleyQty { get; set; }
        public int? CabinCrewVer { get; set; }
        public int? CockpitSeatVerPilot { get; set; }
        public int? CockpitSeatVerFlightEngineer { get; set; }
        public int? CockpitSeatVerObserver { get; set; }
        public string PreviousRegister { get; set; }
        public int? FuelLhOuter { get; set; }
        public int? FuelLhInner { get; set; }
        public int? FuelCenter { get; set; }
        public int? FuelRhInner { get; set; }
        public int? FuelRhOuter { get; set; }
        public int? FuelAct2 { get; set; }
        public int? FuelAct1 { get; set; }
        public int? FuelTrim { get; set; }
        public int? FuelTotal { get; set; }
        public bool? FuelUnit { get; set; }
        public int CustomerId { get; set; }
        public string Model { get; set; }
        public int? AircraftTypeId { get; set; }
        public string AircraftType { get; set; }
        public int? ManufacturerId { get; set; }
        public string Manufacturer { get; set; }
        public string AirlineOperators { get; set; }
        public string Customer { get; set; }
        public bool? Isvirtual { get; set; }
    }
}
