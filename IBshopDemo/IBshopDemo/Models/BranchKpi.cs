using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class BranchKpi
{
    public string KpibranchCode { get; set; } = null!;

    public string? WrsupReq { get; set; }

    public string? WrongIssue { get; set; }

    public string? BrcCnf { get; set; }

    public string? WrongQty { get; set; }

    public string? BrnReqQty { get; set; }

    public string? BranchCap { get; set; }

    public string? PurchaseAvgTime { get; set; }

    public string? Kllevel { get; set; }

    public string? ConIntMonPercentage { get; set; }

    public string? ClienttoIssue { get; set; }

    public string? BrcClient { get; set; }

    public string? MrkSpv { get; set; }

    public string? NewUser { get; set; }
}
