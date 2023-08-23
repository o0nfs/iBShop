using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class HrMonthlyReport
{
    public int HrmonthlyreportId { get; set; }

    public int Year { get; set; }

    public string Month { get; set; } = null!;

    public int MonthNumber { get; set; }

    public int HrpersonnelQty { get; set; }

    public int LeftQty { get; set; }

    public int HrmhiredQty { get; set; }

    public int Obqty { get; set; }

    public int Reqqty { get; set; }

    public int SentCvtoDep { get; set; }

    public int CoursQty { get; set; }

    public int IntQty { get; set; }

    public int RsgReq { get; set; }

    public int UsedImp { get; set; }

    public int Gcissu { get; set; }

    public int SrvAsgNewPer { get; set; }

    public int AsuAsgNewPer { get; set; }

    public int GurReqFun { get; set; }

    public int GurReqLtt { get; set; }

    public int PyrDedReqLtt { get; set; }

    public int SendOutLtt { get; set; }

    public int SendIntLtt { get; set; }

    public int RecLtt { get; set; }

    public int PerEntCnfQty { get; set; }

    public int PreFailQty { get; set; }

    public int ReplacemntQty { get; set; }

    public int Rrfail { get; set; }

    public int RrfacFail { get; set; }

    public int LobFailQty { get; set; }

    public int FloFailQty { get; set; }

    public int TblFailQty { get; set; }

    public int StrFailQty { get; set; }

    public int MngRfailQty { get; set; }

    public int BrkFailQty { get; set; }

    public int PntFailQty { get; set; }
}
