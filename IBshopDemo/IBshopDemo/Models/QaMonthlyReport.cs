using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class QaMonthlyReport
{
    public int Qamrid { get; set; }

    public int Year { get; set; }

    public string Month { get; set; } = null!;

    public int MonthNumber { get; set; }

    public int TotalPersonnelIncCallQty { get; set; }

    public int TotalChcIncCallQty { get; set; }

    public int WelFailPerIncQty { get; set; }

    public int WelFailIncQty { get; set; }

    public int SurFailPerIncQty { get; set; }

    public int SurFailIncQty { get; set; }

    public int KnwFailPerIncQty { get; set; }

    public int KnwFailIncQty { get; set; }

    public int ProFailPerIncQty { get; set; }

    public int ProFailIncQty { get; set; }

    public int TicFailPerIncQty { get; set; }

    public int TicFailIncQty { get; set; }

    public int CalMgtPerIncQty { get; set; }

    public int CalMgtIncQty { get; set; }

    public int SysFailPerIncQty { get; set; }

    public int SysFailIncQty { get; set; }

    public int TotalPersonnelOutCallQty { get; set; }

    public int TotalChcOutCallQty { get; set; }

    public int SurFailPerOutQty { get; set; }

    public int SurFailOutQty { get; set; }

    public int ProFailPerOutQty { get; set; }

    public int ProFailOutQty { get; set; }

    public int TicFailPerOutQty { get; set; }

    public int TicFailOutQty { get; set; }

    public int CalMgtPerOutQty { get; set; }

    public int CalMgtOutQty { get; set; }

    public int ToalOnlineChat { get; set; }

    public int TotalCheckedOnlineChat { get; set; }

    public int SurFailPerChatQty { get; set; }

    public int SurFailChatQty { get; set; }

    public int ProFailPerChatQty { get; set; }

    public int ProFailChatQty { get; set; }

    public int TicFailPerChatQty { get; set; }

    public int TicFailChatQty { get; set; }

    public int TimFailPerChatQty { get; set; }

    public int TimFailChatQty { get; set; }

    public int? SurveyChatOnline { get; set; }

    public int HgradeQty { get; set; }

    public int GgradeQty { get; set; }

    public int FgradeQty { get; set; }

    public int EgradeQty { get; set; }

    public int DgradeQty { get; set; }

    public int CgradeQty { get; set; }

    public int BgradeQty { get; set; }

    public int AgradeQty { get; set; }

    public int ApgradeQty { get; set; }

    public int? RepFail { get; set; }
}
