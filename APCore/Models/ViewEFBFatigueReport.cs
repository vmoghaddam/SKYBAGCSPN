using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewEFBFatigueReport
    {
        public int? ActualRest { get; set; }
        public bool? AlmostTired { get; set; }
        public bool? DifficultyKeepingEyes { get; set; }
        public bool? Exhausted { get; set; }
        public bool? Fidgeting { get; set; }
        public int? FlightId { get; set; }
        public bool? Fresh { get; set; }
        public bool? FullyAlert { get; set; }
        public bool? HeadNodding { get; set; }
        public bool? ImpairedAttention { get; set; }
        public bool? ImpairedMemory { get; set; }
        public bool? ImpairedProblemSolving { get; set; }
        public bool? ImpairedSituationalAwareness { get; set; }
        public bool? LittleTired { get; set; }
        public bool? Lively { get; set; }
        public bool? LongBlinks { get; set; }
        public int? MaxDuty { get; set; }
        public bool? NegativeMood { get; set; }
        public string Other { get; set; }
        public string PositionInFlight { get; set; }
        public int? Rank { get; set; }
        public bool? ReducedCommunication { get; set; }
        public string Report { get; set; }
        public string ReporterName { get; set; }
        public int? RequiredRest { get; set; }
        public bool? RubbingEyes { get; set; }
        public bool? StaringBlankly { get; set; }
        public int? TotalDuty { get; set; }
        public bool? VeryTired { get; set; }
        public bool? Yawing { get; set; }
        public bool? Day { get; set; }
        public bool? Night { get; set; }
        public int? Sector { get; set; }
        public string State { get; set; }
        public string FollowUp { get; set; }
        public string FromAirportIATA { get; set; }
        public string ToAirportIATA { get; set; }
        public string Register { get; set; }
        public string FlightNumber { get; set; }
    }
}
