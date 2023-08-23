using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class BranchesInfo
{
    public int BranchCode { get; set; }

    public string BranchLocation { get; set; } = null!;

    public string? BranchManager { get; set; }

    public virtual ICollection<FixIncomeProperty> FixIncomeProperties { get; set; } = new List<FixIncomeProperty>();

    public virtual ICollection<MixProperty> MixProperties { get; set; } = new List<MixProperty>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
