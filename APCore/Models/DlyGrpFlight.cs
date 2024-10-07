using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class DlyGrpFlight
    {
        public int? Pyear { get; set; }
        public string PmonthName { get; set; }
        public int? Pmonth { get; set; }
        public string Pdate { get; set; }
        public DateTime? Stdday { get; set; }
        public int FlightId { get; set; }
        public int? Delay { get; set; }
        public string FlightNumber { get; set; }
        public DateTime? ChocksIn { get; set; }
        public DateTime? Landing { get; set; }
        public DateTime? Takeoff { get; set; }
        public DateTime? ChocksOut { get; set; }
        public DateTime? DepartureLocal { get; set; }
        public DateTime? ArrivalLocal { get; set; }
        public DateTime? Stdlocal { get; set; }
        public DateTime? Stalocal { get; set; }
        public int? RegisterId { get; set; }
        public string Register { get; set; }
        public int? TypeId { get; set; }
        public string AircraftType { get; set; }
        public string FromAirportIata { get; set; }
        public string ToAirportIata { get; set; }
        public int? FromAirport { get; set; }
        public int? ToAirport { get; set; }
        public int? BlockTime { get; set; }
        public int? FlightTime { get; set; }
        public int? TotalPax { get; set; }
        public int? TotalPaxAll { get; set; }
        public int DelayUnder30 { get; set; }
        public int DelayOver30 { get; set; }
        public int Delay3060 { get; set; }
        public int Delay60120 { get; set; }
        public int Delay120180 { get; set; }
        public int DelayOver180 { get; set; }
        public int DelayOver240 { get; set; }
        public int? PaxDelayOver240 { get; set; }
        public int? PaxDelayOver30 { get; set; }
        public int? PaxDelay3060 { get; set; }
        public int? PaxDelay60120 { get; set; }
        public int? PaxDelay120180 { get; set; }
        public int? PaxDelayOver180 { get; set; }
    }
}
