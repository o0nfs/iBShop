using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class OperationKpi
{
    public int Id { get; set; }

    public string? OperationKpicode { get; set; }

    public string? Piapp { get; set; }

    public string? ErrApp { get; set; }

    public string? AppDev { get; set; }

    public string? Answeringspeed { get; set; }

    public string? IbCardAutAvgTime { get; set; }

    public string? SejAutAvgTime { get; set; }

    public string? PayToCusAvgTime { get; set; }

    public string? CusAutAsset { get; set; }

    public string? Cus { get; set; }

    public string? SucOprRate { get; set; }
}
