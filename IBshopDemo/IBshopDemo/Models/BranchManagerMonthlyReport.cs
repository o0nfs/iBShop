using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class BranchManagerMonthlyReport
{
    public int BranchManagerMonthlyReportIdBranchManagerMonthlyReportId { get; set; }

    public int Year { get; set; }

    public string Month { get; set; } = null!;

    public int MonthNumber { get; set; }

    public int BranchCode { get; set; }

    public string BranchLocation { get; set; } = null!;

    public int IBcardMrkmtgqty { get; set; }

    public int IBcardSuccessMtgqty { get; set; }

    public int IBcrowdMrkmtgqty { get; set; }

    public int IBcrowdSuccessMtgqty { get; set; }

    public int AssuranceMrkmtgqty { get; set; }

    public int AssuranceSuccessMtgqty { get; set; }

    public int DebtSharesMrkmtgqty { get; set; }

    public int DebtSharesSuccessMtgqty { get; set; }

    public int InvestmentMrkmtgqty { get; set; }

    public int InvesmentSuccessMtgqty { get; set; }

    public int CoursesReq { get; set; }

    public int CoursesMrkmtgqty { get; set; }

    public int CoursesMrkmtgfirstAgreementQty { get; set; }

    public int ComplainantQty { get; set; }

    public int Conciliation { get; set; }
}
