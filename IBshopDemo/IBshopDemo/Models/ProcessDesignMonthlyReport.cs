using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class ProcessDesignMonthlyReport
{
    public int ProcessDesignMrid { get; set; }

    public int? Year { get; set; }

    public string Month { get; set; } = null!;

    public int MonthNumber { get; set; }

    public int PrcdQty { get; set; }

    public int RelPrcdQty { get; set; }

    public int InsQty { get; set; }

    public int RelInsQty { get; set; }

    public int RegQty { get; set; }

    public int RelReqQty { get; set; }

    public int FormQty { get; set; }

    public int PrcDesign { get; set; }

    public int ReviewPrc { get; set; }

    public int AsmPrc { get; set; }

    public int DlgQty { get; set; }

    public int IndexQty { get; set; }

    public int ReviwIndxQty { get; set; }

    public int KpimonitoringQty { get; set; }

    public int MrkcommHold { get; set; }

    public int MrkDoneCmm { get; set; }

    public int MrkFailCmm { get; set; }

    public int DevCommHold { get; set; }

    public int DevDoneCmm { get; set; }

    public int DevFailCmm { get; set; }

    public int CrmcommHold { get; set; }

    public int CrmdoneCmm { get; set; }

    public int CrmfailCmm { get; set; }
}
