using System;
using System.Collections.Generic;

namespace IBshopDemo.Models;

public partial class OperationMonthlyReport
{
    public int Id { get; set; }

    public int Oprmrid { get; set; }

    public int Year { get; set; }

    public int? MonthNumber { get; set; }

    public string Month { get; set; } = null!;

    public int BillConflictReqQty { get; set; }

    public int PoseConflictReqQty { get; set; }

    public int SmsinternetConflictReqQty { get; set; }

    public int BranchInternetConflictReqQty { get; set; }

    public int IntternetEntranceConflictReq { get; set; }

    public int FixedConflictQty { get; set; }

    public int TotalConflictsProcess { get; set; }

    public int BkgNewCustomer { get; set; }

    public int BkgReqCnfqty { get; set; }

    public int BkgCrdVol { get; set; }

    public int BkgCrdQty { get; set; }

    public int TotalIbcardIssuesVol { get; set; }

    public int TotalIbcardIssuesQty { get; set; }

    public int TotalTransferVol { get; set; }

    public int TotalmsgQty { get; set; }

    public int RemotChcAut { get; set; }

    public int TotalEditAcc { get; set; }

    public int TotalIdeEdit { get; set; }

    public int TotalLegAut { get; set; }

    public int TotalChcSejam { get; set; }

    public int TotalIssuCrt { get; set; }

    public decimal? AbCganjinehTamaddon { get; set; }

    public decimal? AbCganjinehTamaddonRe { get; set; }

    public decimal? AbCganjinehShahr { get; set; }

    public decimal? AbCganjinehShahrRe { get; set; }

    public decimal? AbCganjinehSandogh { get; set; }

    public decimal? AbCganjinehSandoghRe { get; set; }

    public decimal? AbCganjinehSamaneh { get; set; }

    public decimal? AbCganjinehSamanehRe { get; set; }

    public decimal? AbCganjinehBranches { get; set; }

    public decimal? AbCganjinehBranchesRe { get; set; }

    public decimal? AbCganjinehShahrnet { get; set; }

    public decimal? AbCganjinehShahrnetRe { get; set; }

    public decimal? AbCganjinehTotal { get; set; }

    public decimal? AbCganjinehTotalRe { get; set; }

    public decimal? AbCandookhtehTamaddon { get; set; }

    public decimal? AbCandookhtehTamaddonRe { get; set; }

    public decimal? AbCandookhtehShahr { get; set; }

    public decimal? AbCandookhtehShahrRe { get; set; }

    public decimal? AbCandookhtehOtherBanks { get; set; }

    public decimal? AbCandookhtehOtherBanksRe { get; set; }

    public decimal? AbCandookhtehSandogh { get; set; }

    public decimal? AbCandookhtehSandoghRe { get; set; }

    public decimal? AbCandookhtehSamaneh { get; set; }

    public decimal? AbCandookhtehSamanehRe { get; set; }

    public decimal? AbCandookhtehBranch { get; set; }

    public decimal? AbCandookhtehBranchRe { get; set; }

    public decimal? AbCandookhtehShahrnet { get; set; }

    public decimal? AbCandookhtehShahrnetRe { get; set; }

    public decimal? AbCandookhtehTotal { get; set; }

    public decimal? AbCandookhtehTotalRe { get; set; }

    public decimal? AbCservatTamaddon { get; set; }

    public decimal? AbCservatTamaddonRe { get; set; }

    public decimal? AbCservatSamaneh { get; set; }

    public decimal? AbCservatSamanehRe { get; set; }

    public decimal? AbCservatBranch { get; set; }

    public decimal? AbCservatBranchRe { get; set; }

    public decimal? AbCservatSandogh { get; set; }

    public decimal? AbCservatSandoghRe { get; set; }

    public decimal? AbCservatTotal { get; set; }

    public decimal? AbCservatTotalRe { get; set; }

    public decimal? AbCgoharTamaddon { get; set; }

    public decimal? AbCgoharTamaddonRe { get; set; }

    public decimal? AbCgoharSamaneh { get; set; }

    public decimal? AbCgoharSamanehRe { get; set; }

    public decimal? AbCgoharBranch { get; set; }

    public decimal? AbCgoharBranchRe { get; set; }

    public decimal? AbCgoharSandogh { get; set; }

    public decimal? AbCgoharSandoghRe { get; set; }

    public decimal? AbCgoharTotal { get; set; }

    public decimal? AbCgoharTotalRe { get; set; }
}
