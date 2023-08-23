using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class Product
{
    public int ProductsId { get; set; }

    public int BrancheCode { get; set; }

    public int? IncomeCenterId { get; set; }

    public int? MonthNumber { get; set; }

    public string? MonthName { get; set; }

    public decimal IbcrowdVol { get; set; }

    public int IbcardIssueQty { get; set; }

    public int CardQty { get; set; }

    public int KargozariBoursCode { get; set; }

    public decimal DealValue { get; set; }

    public decimal Income { get; set; }

    public virtual BranchesInfo BrancheCodeNavigation { get; set; } = null!;

    public virtual IncomeCenter? IncomeCenter { get; set; }
}
