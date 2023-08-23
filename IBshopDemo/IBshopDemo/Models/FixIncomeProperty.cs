using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class FixIncomeProperty
{
    public int FixIncomeId { get; set; }

    public int BrancheCode { get; set; }

    public int? InComeCenterId { get; set; }

    public string? MonthNumber { get; set; }

    public string? MonthName { get; set; }

    public int? CustomerQty { get; set; }

    public decimal GanjinehIssue { get; set; }

    public decimal GanjinehRev { get; set; }

    public decimal AndookhtehIssue { get; set; }

    public decimal AndookhtehRev { get; set; }

    public int VirIssueBillQty { get; set; }

    public decimal VirIssueBillVol { get; set; }

    public decimal TotalIssue { get; set; }

    public decimal TotalRev { get; set; }

    public virtual BranchesInfo BrancheCodeNavigation { get; set; } = null!;

    public virtual IncomeCenter? InComeCenter { get; set; }
}
