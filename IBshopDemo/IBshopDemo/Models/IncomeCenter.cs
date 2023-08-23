using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class IncomeCenter
{
    public int IncomecenterId { get; set; }

    public string IncomeCenterName { get; set; } = null!;

    public virtual ICollection<FixIncomeProperty> FixIncomeProperties { get; set; } = new List<FixIncomeProperty>();

    public virtual ICollection<MixProperty> MixProperties { get; set; } = new List<MixProperty>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
