using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewCrewFlightApp
    {
        public int Fdpid { get; set; }
        public int FdpitemId { get; set; }
        public int? CrewId { get; set; }
        public int? FlightId { get; set; }
        public bool? IsPositioning { get; set; }
        public int? PositionId { get; set; }
        public string Position { get; set; }
        public string Name { get; set; }
        public string ScheduleName { get; set; }
        public int? GroupId { get; set; }
        public string JobGroup { get; set; }
        public string JobGroupCode { get; set; }
        public int SexId { get; set; }
        public string Sex { get; set; }
        public int GroupOrder { get; set; }
        public int IsCockpit { get; set; }
        public DateTime? Stdday { get; set; }
        public DateTime? StddayEnd { get; set; }
        public string FlightNumber { get; set; }
        public string FromAirportIata { get; set; }
        public string ToAirportIata { get; set; }
        public int? FromAirport { get; set; }
        public int? ToAirport { get; set; }
        public DateTime? Std { get; set; }
        public DateTime? Sta { get; set; }
        public DateTime? Stdlocal { get; set; }
        public DateTime? Stalocal { get; set; }
        public string Register { get; set; }
        public int? RegisterId { get; set; }
        public DateTime? ChocksOut { get; set; }
        public DateTime? ChocksIn { get; set; }
        public DateTime? TakeOff { get; set; }
        public DateTime? Landing { get; set; }
        public DateTime? ChocksOutLocal { get; set; }
        public DateTime? ChocksInLocal { get; set; }
        public DateTime? TakeOffLocal { get; set; }
        public DateTime? LandingLocal { get; set; }
        public int? BlockTime { get; set; }
        public int? FlightTime { get; set; }
        public int? FlightTimeActual { get; set; }
        public int? Fixtime { get; set; }
        public int? Sitatime { get; set; }
        public string FlightStatus { get; set; }
        public int? FlightStatusId { get; set; }
        public string Airline { get; set; }
        public int? AirlineOperatorsId { get; set; }
        public int? CpcrewId { get; set; }
        public string Cpinstructor { get; set; }
        public string Cpp1 { get; set; }
        public string Cpp2 { get; set; }
        public string Cpsccm { get; set; }
        public string Cpisccm { get; set; }
        public bool? SplitDuty { get; set; }
        public int NightTime { get; set; }
        public int? DayTime { get; set; }
        public int? NightTakeOff { get; set; }
        public int? DayTakeOff { get; set; }
        public int? NightLanding { get; set; }
        public int? DayLanding { get; set; }
        public DateTime? Pickup { get; set; }
        public DateTime? PickupLocal { get; set; }
        public int? RampId { get; set; }
        public string Ramp { get; set; }
    }
}
