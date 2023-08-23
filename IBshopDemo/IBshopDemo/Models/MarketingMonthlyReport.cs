using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class MarketingMonthlyReport
{
    public int Mrkmrid { get; set; }

    public int Year { get; set; }

    public string Month { get; set; } = null!;

    public int MonthNumber { get; set; }

    public int SentSmsQty { get; set; }

    public int ReportAdvQty { get; set; }

    public int NotifPushQty { get; set; }

    public int PostMediaQty { get; set; }

    public int StateMedAdvQty { get; set; }

    public int BilboardQty { get; set; }

    public int SrchEntQty { get; set; }

    public int RefEntQty { get; set; }

    public int SmedEntQty { get; set; }

    public int SiteEntMonthlyAvg { get; set; }

    public int InstFlwQty { get; set; }

    public int EngQty { get; set; }

    public int TlgPostContentQty { get; set; }

    public int LinkdinContentQty { get; set; }

    public int DesignQty { get; set; }

    public int VideoQty { get; set; }

    public int HoldQty { get; set; }

    public int HoldComptQty { get; set; }

    public int RecVidPostQty { get; set; }

    public int TrainPostQty { get; set; }

    public int InsFlwQty { get; set; }

    public int NewsQty { get; set; }

    public int TrainingCntrctQty { get; set; }

    public int IbcrowdCalllegalCusQty { get; set; }

    public int PrdSrvAdvCallQty { get; set; }

    public int SucCallQty { get; set; }

    public int ToalInvestVol { get; set; }

    public int ConversationRate { get; set; }

    public int? BounceRate { get; set; }

    public int KeywordsRank { get; set; }

    public int GoogleEntTerRate { get; set; }

    public int LinkEntTerRate { get; set; }
}
