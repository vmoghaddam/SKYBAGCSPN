﻿using System;
using System.Collections.Generic;

#nullable disable

namespace APCore.Models
{
    public partial class ViewEfbdsprelease
    {
        public int Id { get; set; }
        public int? FlightId { get; set; }
        public bool? ActualWxdsp { get; set; }
        public bool? ActualWxcpt { get; set; }
        public string ActualWxdspremark { get; set; }
        public string ActualWxcptremark { get; set; }
        public bool? WxforcastDsp { get; set; }
        public bool? WxforcastCpt { get; set; }
        public string WxforcastDspremark { get; set; }
        public string WxforcastCptremark { get; set; }
        public bool? SigxWxdsp { get; set; }
        public bool? SigxWxcpt { get; set; }
        public string SigxWxdspremark { get; set; }
        public string SigxWxcptremark { get; set; }
        public bool? WindChartDsp { get; set; }
        public bool? WindChartCpt { get; set; }
        public string WindChartDspremark { get; set; }
        public string WindChartCptremark { get; set; }
        public bool? NotamDsp { get; set; }
        public bool? NotamCpt { get; set; }
        public string NotamDspremark { get; set; }
        public string NotamCptremark { get; set; }
        public bool? ComputedFligthPlanDsp { get; set; }
        public bool? ComputedFligthPlanCpt { get; set; }
        public string ComputedFligthPlanDspremark { get; set; }
        public string ComputedFligthPlanCptremark { get; set; }
        public bool? AtcflightPlanDsp { get; set; }
        public bool? AtcflightPlanCpt { get; set; }
        public string AtcflightPlanDspremark { get; set; }
        public string AtcflightPlanCptremark { get; set; }
        public bool? PermissionsDsp { get; set; }
        public bool? PermissionsCpt { get; set; }
        public string PermissionsDspremark { get; set; }
        public string PermissionsCptremark { get; set; }
        public bool? JeppesenAirwayManualDsp { get; set; }
        public bool? JeppesenAirwayManualCpt { get; set; }
        public string JeppesenAirwayManualDspremark { get; set; }
        public string JeppesenAirwayManualCptremark { get; set; }
        public bool? MinFuelRequiredDsp { get; set; }
        public bool? MinFuelRequiredCpt { get; set; }
        public decimal? MinFuelRequiredPilotReq { get; set; }
        public bool? GeneralDeclarationDsp { get; set; }
        public bool? GeneralDeclarationCpt { get; set; }
        public string GeneralDeclarationDspremark { get; set; }
        public string GeneralDeclarationCptremark { get; set; }
        public bool? FlightReportDsp { get; set; }
        public bool? FlightReportCpt { get; set; }
        public string FlightReportDspremark { get; set; }
        public string FlightReportCptremark { get; set; }
        public bool? TolndCardsDsp { get; set; }
        public bool? TolndCardsCpt { get; set; }
        public string TolndCardsDspremark { get; set; }
        public string TolndCardsCptremark { get; set; }
        public bool? LoadSheetDsp { get; set; }
        public bool? LoadSheetCpt { get; set; }
        public string LoadSheetDspremark { get; set; }
        public string LoadSheetCptremark { get; set; }
        public bool? FlightSafetyReportDsp { get; set; }
        public bool? FlightSafetyReportCpt { get; set; }
        public string FlightSafetyReportDspremark { get; set; }
        public string FlightSafetyReportCptremark { get; set; }
        public bool? AvsecincidentReportDsp { get; set; }
        public bool? AvsecincidentReportCpt { get; set; }
        public string AvsecincidentReportDspremark { get; set; }
        public string AvsecincidentReportCptremark { get; set; }
        public bool? OperationEngineeringDsp { get; set; }
        public bool? OperationEngineeringCpt { get; set; }
        public string OperationEngineeringDspremark { get; set; }
        public string OperationEngineeringCptremark { get; set; }
        public bool? VoyageReportDsp { get; set; }
        public bool? VoyageReportCpt { get; set; }
        public string VoyageReportDspremark { get; set; }
        public string VoyageReportCptremark { get; set; }
        public bool? Pifdsp { get; set; }
        public bool? Pifcpt { get; set; }
        public string Pifdspremark { get; set; }
        public string Pifcptremark { get; set; }
        public bool? GoodDeclarationDsp { get; set; }
        public bool? GoodDeclarationCpt { get; set; }
        public string GoodDeclarationDspremark { get; set; }
        public string GoodDeclarationCptremark { get; set; }
        public bool? Ipaddsp { get; set; }
        public bool? Ipadcpt { get; set; }
        public string Ipaddspremark { get; set; }
        public string Ipadcptremark { get; set; }
        public DateTime? DateConfirmed { get; set; }
        public int? DispatcherId { get; set; }
        public string Dspname { get; set; }
        public string Dsppid { get; set; }
        public string Dspnid { get; set; }
        public string Dspmobile { get; set; }
        public string JlsignedBy { get; set; }
        public DateTime? JldatePicapproved { get; set; }
        public int? Picid { get; set; }
        public string Pic { get; set; }
        public bool? OperationalFlightPlanFoo { get; set; }
        public bool? OperationalFlightPlanCmdr { get; set; }
        public string OperationalFlightPlanFooremark { get; set; }
        public string OperationalFlightPlanCmdrremark { get; set; }
        public bool? AtsflightPlanFoo { get; set; }
        public bool? AtsflightPlanCmdr { get; set; }
        public string AtsflightPlanFooremark { get; set; }
        public string AtsflightPlanCmdrremark { get; set; }
        public bool? VldEfbfoo { get; set; }
        public bool? VldEfbcmdr { get; set; }
        public string VldEfbfooremark { get; set; }
        public string VldEfbcmdrremark { get; set; }
        public bool? VldFlightCrewFoo { get; set; }
        public bool? VldFlightCrewCmdr { get; set; }
        public string VldFlightCrewFooremark { get; set; }
        public string VldFlightCrewCmdrremark { get; set; }
        public bool? VldMedicalFoo { get; set; }
        public bool? VldMedicalCmdr { get; set; }
        public string VldMedicalFooremark { get; set; }
        public string VldMedicalCmdrremark { get; set; }
        public bool? VldPassportFoo { get; set; }
        public bool? VldPassportCmdr { get; set; }
        public string VldPassportFooremark { get; set; }
        public string VldPassportCmdrremark { get; set; }
        public bool? VldCmcfoo { get; set; }
        public bool? VldCmccmdr { get; set; }
        public string VldCmcfooremark { get; set; }
        public string VldCmccmdrremark { get; set; }
        public bool? VldRampPassFoo { get; set; }
        public bool? VldRampPassCmdr { get; set; }
        public string VldRampPassFooremark { get; set; }
        public string VldRampPassCmdrremark { get; set; }
        public string Note { get; set; }
    }
}
