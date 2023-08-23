using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class Kpihr
{
    public int Id { get; set; }

    public int Kpihrcode { get; set; }

    public string? RecEff { get; set; }

    public string? EduEfc { get; set; }

    public string? SurveyFeedback { get; set; }

    public string? TrnColeagPer { get; set; }

    public string? MistakeinPersonalInfo { get; set; }

    public string? SalMistakePerc { get; set; }

    public string? ColLoyPer { get; set; }

    public string? EduCap { get; set; }

    public string? ProEduCap { get; set; }

    public string? MgmEduCap { get; set; }

    public string? GenEduCap { get; set; }

    public string? PapConCap { get; set; }

    public string? IntColCam { get; set; }

    public string? ReqToNeed { get; set; }

    public string? IctsrvSat { get; set; }

    public string? ColSat { get; set; }

    public string? OutcallCostAvg { get; set; }

    public string? RecDelRat { get; set; }

    public string? HrRecDelRat { get; set; }

    public string? Sal { get; set; }
}
