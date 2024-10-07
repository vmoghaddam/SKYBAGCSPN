using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewRegisterGround
    {
        public int RegisterId { get; set; }
        public int GroundTypeId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateEnd { get; set; }
        public DateTime? DateFromLocal { get; set; }
        public DateTime? DateEndLocal { get; set; }
        public string Remark { get; set; }
        public string GroundType { get; set; }
        public int? Msn { get; set; }
        public string Register { get; set; }
        public string Model { get; set; }
        public int? AircraftTypeId { get; set; }
        public string AircraftType { get; set; }
        public int? ManufacturerId { get; set; }
        public string Manufacturer { get; set; }
        public string Customer { get; set; }
        public bool? Isvirtual { get; set; }
        public string AirlineOperators { get; set; }
        public int CustomerId { get; set; }
        public int AirlineOperatorsId { get; set; }
        public decimal? Duration { get; set; }
        public int FlightStatusId { get; set; }
        public string FlightStatus { get; set; }
        public int? TypeId { get; set; }
        public int Id { get; set; }
        public int? TaskId { get; set; }
        public int FlightTypeId { get; set; }
    }
}
