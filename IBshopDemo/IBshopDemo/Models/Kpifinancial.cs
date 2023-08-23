using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class Kpifinancial
{
    public int Id { get; set; }

    public string KpifinCode { get; set; } = null!;

    public string? OtdecLegRe { get; set; }

    public string? RvwAccConflicts { get; set; }

    public string? RvwInvConflicts { get; set; }

    public string? DevPlnBudPer { get; set; }

    public string? IncBudMeetPer { get; set; }

    public string? DemistakeFin { get; set; }

    public string? AcrFinRepPer { get; set; }

    public string? Cnt { get; set; }

    public string? CtrTimeDuration { get; set; }

    public string? FixedAssetConflict { get; set; }

    public string? BillIssueAvgTime { get; set; }

    public string? CnrctrInvoicesMatch { get; set; }

    public string? OdrecintotalRec { get; set; }
}
