using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class BranchesMonthlyReport
{
    public int BranchMonthlyReportId { get; set; }

    public int Year { get; set; }

    public string Month { get; set; } = null!;

    public int MonthNumber { get; set; }

    public int IbcardConflictBranchQty { get; set; }

    public int IbcrowdConflictBranchQty { get; set; }

    public int IBcrowdKpiconflictQty { get; set; }

    public int CoursesQty { get; set; }

    public int OnlineExamsQty { get; set; }

    public int CoursesNeedQty { get; set; }

    public int ServicesToBranchQty { get; set; }

    public int CandstoDevelopmentQty { get; set; }

    public int ReportsConflictsToBranchQty { get; set; }

    public int InvestmentCapitalConflicts { get; set; }

    public int FacilityReqQty { get; set; }

    public int SwsolvedQty { get; set; }

    public int FundSettlementQty { get; set; }

    public int FundsConflictsQty { get; set; }

    public int SendtoBranch { get; set; }

    public int MrkpacTobranchQty { get; set; }

    public int CrttoCusQty { get; set; }

    public int InpersonBranchQty { get; set; }

    public int BranchTickects { get; set; }

    public int TicketConflictsQty { get; set; }

    public int BranchInfractionQty { get; set; }

    public int BranchReformQty { get; set; }

    public int BranchMonQty { get; set; }

    public int BranchCompCheckedQty { get; set; }

    public int AccBranchQty { get; set; }

    public int BranchCompQty { get; set; }

    public int BranchpersonnelQty { get; set; }

    public int PersonnelAssuranceReqQty { get; set; }

    public int PersonnelAdReqQty { get; set; }
}
