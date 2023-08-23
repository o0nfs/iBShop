using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class FinancialSuperMarketMonthlyReport
{
    public int SuperMrid { get; set; }

    public int Year { get; set; }

    public string Month { get; set; } = null!;

    public int MonthNumber { get; set; }

    public int CustomersReplyQty { get; set; }

    public int IbshoppRegisterQty { get; set; }

    public int AuthenticationQty { get; set; }

    public int ActivationQty { get; set; }

    public int ReportForCustomerC { get; set; }

    public int ReportForCustomerF { get; set; }

    public int GanjinehIssueReqQty { get; set; }

    public int GanjinehIssuesVol { get; set; }

    public int AndookhtehIssueReqQty { get; set; }

    public int AndookhtehIssuesVol { get; set; }

    public int GoharandServatIssueReqQty { get; set; }

    public int GohrandServatIssuesVol { get; set; }

    public int GanjinehRevokeReqQty { get; set; }

    public int GanjinehRevokeVol { get; set; }

    public int AndookhtehRevokeReqQty { get; set; }

    public int AndookhtehRevokeVol { get; set; }

    public int GoharandServatRevokeReqQty { get; set; }

    public int GohrandServatRevokeVol { get; set; }

    public int TotIsuuVol { get; set; }

    public int TotRevVol { get; set; }

    public int EditQty { get; set; }

    public int LegalServQty { get; set; }

    public int CardIssuanceQty { get; set; }

    public int TotalIbcardVol { get; set; }

    public int InvestorsQty { get; set; }

    public int TotalIbcrowdVol { get; set; }

    public int InsuranceIssued { get; set; }

    public int CreaditQty { get; set; }

    public int CreaditVol { get; set; }

    public int OnlineCodeQty { get; set; }
}
