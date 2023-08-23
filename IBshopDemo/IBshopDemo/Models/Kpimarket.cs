using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class Kpimarket
{
    public int Id { get; set; }

    public string KpimarketingCode { get; set; } = null!;

    public string? NewUser { get; set; }

    public string? RegistertoIssue { get; set; }

    public string? NewCusAsset { get; set; }

    public string? LegMrk { get; set; }

    public string? BrcMrkRti { get; set; }

    public string? SalePlanDsg { get; set; }

    public string? MrkStgDsg { get; set; }
}
