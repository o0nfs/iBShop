using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class CrmMonthlyReport
{
    public int Crmmrid { get; set; }

    public int Year { get; set; }

    public string Month { get; set; } = null!;

    public int MonthNumber { get; set; }

    public int InChatQty { get; set; }

    public int InCompCallQty { get; set; }

    public int InVmQty { get; set; }

    public int InCallQty { get; set; }

    public int OutAccNumEditQty { get; set; }

    public int OutsurveyQty { get; set; }

    public int OutComTrtQty { get; set; }

    public int OutVmQty { get; set; }

    public int SejamQty { get; set; }

    public double AvgCallDuration { get; set; }

    public double AvgCallWaitingDuration { get; set; }

    public double ToalCallDuration { get; set; }

    public int GanjinehIssuesQty { get; set; }

    public double GanjinehIssuesVol { get; set; }

    public int AndookhtehIssuesQty { get; set; }

    public double AndookhtehIssuesVol { get; set; }

    public int GoharandServatIssuesQty { get; set; }

    public double GoharandServatIssuesVol { get; set; }

    public int TotalIssuesQty { get; set; }

    public double TotalIssuesVol { get; set; }

    public int CrmcoursesQty { get; set; }

    public int TicketOnlineQty { get; set; }

    public int Inticket { get; set; }

    public int ComplaintTicketQty { get; set; }

    public int SurveyTicketQty { get; set; }

    public int InSurveyCallQty { get; set; }

    public int OutSurveyCallQty { get; set; }

    public int OnlineChatsurveyQty { get; set; }

    public int GanjinehTicketQty { get; set; }

    public int AndookhtehicketQty { get; set; }

    public int ServatafarinanTicketQty { get; set; }

    public int GoharTicketQty { get; set; }

    public int IbCardTicketQty { get; set; }

    public int IbCrowdTicketQty { get; set; }

    public int BranchComplTicketQty { get; set; }
}
