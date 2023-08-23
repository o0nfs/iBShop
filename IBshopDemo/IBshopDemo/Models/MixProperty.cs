using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class MixProperty
{
    public int MixIncomeId { get; set; }

    public int BrancheCode { get; set; }

    public int? IncomeCenterId { get; set; }

    public int? MonthNumber { get; set; }

    public string? MonthName { get; set; }

    public decimal ServatIssue { get; set; }

    public decimal ServatRev { get; set; }

    public decimal GoharIssue { get; set; }

    public decimal GoharRev { get; set; }

    public decimal TotalIssue { get; set; }

    public decimal TotalRev { get; set; }

    public virtual BranchesInfo BrancheCodeNavigation { get; set; } = null!;

    public virtual IncomeCenter? IncomeCenter { get; set; }
}
