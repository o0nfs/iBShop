using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class FinancialMonthlyReport
{
    public int FinancialMrid { get; set; }

    public int Year { get; set; }

    public string Month { get; set; } = null!;

    public int MonthNumber { get; set; }

    public int PersonnelSetQty { get; set; }

    public int CheckedfundQty { get; set; }

    public int ContQty { get; set; }

    public int TreasuryBillsQty { get; set; }

    public int Recivedgaurantee { get; set; }

    public int RestaxinstallmentQty { get; set; }

    public int ResFundInstallmenQty { get; set; }

    public int TaminInstallmentQty { get; set; }

    public int TaminPenaltyVol { get; set; }

    public int TranCommissionQty { get; set; }

    public int TaminInstallmentDelay { get; set; }

    public int TaxInstallmentDelay { get; set; }

    public int PrpReqQty { get; set; }

    public int MtnprpQty { get; set; }

    public int ColPrpQty { get; set; }

    public int LblPrpQty { get; set; }
}
