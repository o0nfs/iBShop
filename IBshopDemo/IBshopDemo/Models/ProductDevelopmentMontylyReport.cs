using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class ProductDevelopmentMontylyReport
{
    public int DevMrid { get; set; }

    public int Year { get; set; }

    public string Month { get; set; } = null!;

    public int MonthNumber { get; set; }

    public int CheckedSuggestQty { get; set; }

    public int AcceptedSuggestQty { get; set; }

    public int SuggestPersonnelQty { get; set; }

    public int EconomicalSuggestQty { get; set; }

    public int IbcCreaditCardCustQty { get; set; }

    public int IbcComplQty { get; set; }

    public int IbcCreadiCardReqQty { get; set; }

    public int IbcCreaditCardProcessAvgTime { get; set; }

    public int IbwDesignQty { get; set; }

    public int IbwDesignVol { get; set; }

    public int IbwDesignTime { get; set; }
}
