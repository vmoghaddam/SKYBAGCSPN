using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewFlighPlanAssignedRegister
    {
        public int FlightPlanItemId { get; set; }
        public int FlightPlanId { get; set; }
        public int PlannedRegisterId { get; set; }
        public int RegisterId { get; set; }
        public string Register { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string DateFromTo { get; set; }
        public int? TypeId { get; set; }
        public int? FlightTypeId { get; set; }
        public string FlightType { get; set; }
        public int? AirlineOperatorsId { get; set; }
        public string FlightNumber { get; set; }
        public int FromAirport { get; set; }
        public int ToAirport { get; set; }
        public DateTime? Sta { get; set; }
        public DateTime? Std { get; set; }
        public int FlightH { get; set; }
        public int FlightM { get; set; }
        public string FlightPlan { get; set; }
        public int CustomerId { get; set; }
        public string Customer { get; set; }
        public string FromAirportName { get; set; }
        public string FromAirportIata { get; set; }
        public int? FromAirportCityId { get; set; }
        public string ToAirportName { get; set; }
        public string ToAirportIata { get; set; }
        public int? ToAirportCityId { get; set; }
        public string FromAirportCity { get; set; }
        public string ToAirportCity { get; set; }
        public string AircraftType { get; set; }
        public string FromCity { get; set; }
        public string FromContry { get; set; }
        public string FromSortName { get; set; }
        public string ToCity { get; set; }
        public string ToSortName { get; set; }
        public string ToCountry { get; set; }
        public decimal? ToLatitude { get; set; }
        public decimal? ToLongitude { get; set; }
        public decimal? FromLatitude { get; set; }
        public decimal? FromLongitude { get; set; }
        public int? RouteId { get; set; }
    }
}
