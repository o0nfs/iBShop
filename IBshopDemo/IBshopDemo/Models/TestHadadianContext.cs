using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IBshopDemo.Models;

public partial class TestHadadianContext : DbContext
{
    public TestHadadianContext()
    {
    }

    public TestHadadianContext(DbContextOptions<TestHadadianContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ArtMonthlyReport> ArtMonthlyReports { get; set; }

    public virtual DbSet<BranchKpi> BranchKpis { get; set; }

    public virtual DbSet<BranchManagerMonthlyReport> BranchManagerMonthlyReports { get; set; }

    public virtual DbSet<BranchRanking> BranchRankings { get; set; }

    public virtual DbSet<BranchesInfo> BranchesInfos { get; set; }

    public virtual DbSet<BranchesMonthlyReport> BranchesMonthlyReports { get; set; }

    public virtual DbSet<CrmMonthlyReport> CrmMonthlyReports { get; set; }

    public virtual DbSet<FinancialMonthlyReport> FinancialMonthlyReports { get; set; }

    public virtual DbSet<FinancialSuperMarketMonthlyReport> FinancialSuperMarketMonthlyReports { get; set; }

    public virtual DbSet<FixIncomeProperty> FixIncomeProperties { get; set; }

    public virtual DbSet<HrMonthlyReport> HrMonthlyReports { get; set; }

    public virtual DbSet<IncomeCenter> IncomeCenters { get; set; }

    public virtual DbSet<Kpicrm> Kpicrms { get; set; }

    public virtual DbSet<Kpidevelopment> Kpidevelopments { get; set; }

    public virtual DbSet<Kpifinancial> Kpifinancials { get; set; }

    public virtual DbSet<Kpihr> Kpihrs { get; set; }

    public virtual DbSet<Kpimarket> Kpimarkets { get; set; }

    public virtual DbSet<Kpiplanning> Kpiplannings { get; set; }

    public virtual DbSet<MarketingMonthlyReport> MarketingMonthlyReports { get; set; }

    public virtual DbSet<MixProperty> MixProperties { get; set; }

    public virtual DbSet<OperationKpi> OperationKpis { get; set; }

    public virtual DbSet<OperationMonthlyReport> OperationMonthlyReports { get; set; }

    public virtual DbSet<ProcessDesignMonthlyReport> ProcessDesignMonthlyReports { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductDevelopmentMontylyReport> ProductDevelopmentMontylyReports { get; set; }

    public virtual DbSet<QaMonthlyReport> QaMonthlyReports { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<User> Users { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=.;Database=Test-hadadian;user id=sa;pwd=sql;Trusted_Connection=True;encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ArtMonthlyReport>(entity =>
        {
            entity.ToTable("Art Monthly Report");

            entity.Property(e => e.ArtMonthlyReportId).ValueGeneratedNever();
            entity.Property(e => e.AppliedMotionAvgTime).HasColumnName("AppliedMotionAVgTime");
            entity.Property(e => e.BannerDesignQty).HasColumnName("BannerDesignQTY");
            entity.Property(e => e.BrochureDesignAvgTime).HasColumnName("brochureDesignAvgTime");
            entity.Property(e => e.Month)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MotionQty).HasColumnName("MotionQTY");
        });

        modelBuilder.Entity<BranchKpi>(entity =>
        {
            entity.HasKey(e => e.KpibranchCode);

            entity.ToTable("BranchKPI");

            entity.Property(e => e.KpibranchCode)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("KPIBranchCode");
            entity.Property(e => e.BranchCap)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("branchCap");
            entity.Property(e => e.BrcClient)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.BrcCnf)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.BrnReqQty)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ClienttoIssue)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ConIntMonPercentage)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Kllevel)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MrkSpv)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.NewUser)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.PurchaseAvgTime)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.WrongIssue)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.WrongQty)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.WrsupReq)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("WRSupReq");
        });

        modelBuilder.Entity<BranchManagerMonthlyReport>(entity =>
        {
            entity.HasKey(e => e.BranchManagerMonthlyReportIdBranchManagerMonthlyReportId);

            entity.ToTable("Branch Manager Monthly Report");

            entity.Property(e => e.BranchManagerMonthlyReportIdBranchManagerMonthlyReportId)
                .ValueGeneratedNever()
                .HasColumnName("BranchManagerMonthlyReportId]\r\nBranchManagerMonthlyReportId");
            entity.Property(e => e.AssuranceMrkmtgqty).HasColumnName("AssuranceMRKMTGQty");
            entity.Property(e => e.AssuranceSuccessMtgqty).HasColumnName("AssuranceSuccessMTGQty");
            entity.Property(e => e.BranchLocation).HasMaxLength(50);
            entity.Property(e => e.CoursesMrkmtgfirstAgreementQty).HasColumnName("CoursesMRKMTGFirstAgreementQty");
            entity.Property(e => e.CoursesMrkmtgqty).HasColumnName("CoursesMRKMTGQty");
            entity.Property(e => e.DebtSharesMrkmtgqty).HasColumnName("DebtSharesMRKMTGQty");
            entity.Property(e => e.DebtSharesSuccessMtgqty).HasColumnName("DebtSharesSuccessMTGQty");
            entity.Property(e => e.IBcardMrkmtgqty).HasColumnName("iBcardMRKMTGQty");
            entity.Property(e => e.IBcardSuccessMtgqty).HasColumnName("iBcardSuccessMTGQty");
            entity.Property(e => e.IBcrowdMrkmtgqty).HasColumnName("iBcrowdMRKMTGQty");
            entity.Property(e => e.IBcrowdSuccessMtgqty).HasColumnName("iBcrowdSuccessMTGQty");
            entity.Property(e => e.InvesmentSuccessMtgqty).HasColumnName("InvesmentSuccessMTGQty");
            entity.Property(e => e.InvestmentMrkmtgqty).HasColumnName("InvestmentMRKMTGQty");
            entity.Property(e => e.Month)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<BranchRanking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchRa__3213E83F7329D2F5");

            entity.ToTable("BranchRanking");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchRankingId).HasColumnName("BranchRankingID");
            entity.Property(e => e.IBcrowdrank).HasColumnName("iBcrowdrank");
            entity.Property(e => e.Servicerank).HasColumnName("servicerank");
        });

        modelBuilder.Entity<BranchesInfo>(entity =>
        {
            entity.HasKey(e => e.BranchCode);

            entity.ToTable("Branches Info");

            entity.Property(e => e.BranchCode).ValueGeneratedNever();
            entity.Property(e => e.BranchLocation).HasMaxLength(50);
            entity.Property(e => e.BranchManager).HasMaxLength(50);
        });

        modelBuilder.Entity<BranchesMonthlyReport>(entity =>
        {
            entity.HasKey(e => e.BranchMonthlyReportId).HasName("PK_CRM Monthly Report");

            entity.ToTable("Branches Monthly Report");

            entity.Property(e => e.BranchMonthlyReportId).ValueGeneratedNever();
            entity.Property(e => e.CrttoCusQty).HasColumnName("CRTToCusQty");
            entity.Property(e => e.IBcrowdKpiconflictQty).HasColumnName("iBcrowdKPIconflictQty");
            entity.Property(e => e.IbcrowdConflictBranchQty).HasColumnName("ibcrowdConflictBranchQty");
            entity.Property(e => e.Month)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MrkpacTobranchQty).HasColumnName("MRKPacTOBranchQty");
            entity.Property(e => e.SwsolvedQty).HasColumnName("SWSolvedQty");
        });

        modelBuilder.Entity<CrmMonthlyReport>(entity =>
        {
            entity.HasKey(e => e.Crmmrid);

            entity.ToTable("CRM Monthly Reports");

            entity.Property(e => e.Crmmrid)
                .ValueGeneratedNever()
                .HasColumnName("CRMMRId");
            entity.Property(e => e.CrmcoursesQty).HasColumnName("CRMcoursesQty");
            entity.Property(e => e.IbCardTicketQty).HasColumnName("ibCardTicketQty");
            entity.Property(e => e.IbCrowdTicketQty).HasColumnName("ibCrowdTicketQty");
            entity.Property(e => e.Inticket).HasColumnName("INTicket");
            entity.Property(e => e.Month)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<FinancialMonthlyReport>(entity =>
        {
            entity.HasKey(e => e.FinancialMrid);

            entity.ToTable("Financial Monthly Report");

            entity.Property(e => e.FinancialMrid)
                .ValueGeneratedNever()
                .HasColumnName("FinancialMRId");
            entity.Property(e => e.Month)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MtnprpQty).HasColumnName("MTNPrpQty");
        });

        modelBuilder.Entity<FinancialSuperMarketMonthlyReport>(entity =>
        {
            entity.HasKey(e => e.SuperMrid);

            entity.ToTable("Financial SuperMarket Monthly Report");

            entity.Property(e => e.SuperMrid)
                .ValueGeneratedNever()
                .HasColumnName("SuperMRId");
            entity.Property(e => e.CardIssuanceQty).HasColumnName("cardIssuanceQty");
            entity.Property(e => e.IbshoppRegisterQty).HasColumnName("IBshoppRegisterQty");
            entity.Property(e => e.Month)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<FixIncomeProperty>(entity =>
        {
            entity.HasKey(e => e.FixIncomeId);

            entity.Property(e => e.FixIncomeId)
                .ValueGeneratedNever()
                .HasColumnName("FixIncomeID");
            entity.Property(e => e.AndookhtehIssue).HasColumnType("money");
            entity.Property(e => e.AndookhtehRev)
                .HasColumnType("money")
                .HasColumnName("AndookhtehREv");
            entity.Property(e => e.GanjinehIssue).HasColumnType("money");
            entity.Property(e => e.GanjinehRev).HasColumnType("money");
            entity.Property(e => e.InComeCenterId).HasColumnName("InComeCenterID");
            entity.Property(e => e.MonthName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MonthNumber)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TotalIssue).HasColumnType("money");
            entity.Property(e => e.TotalRev).HasColumnType("money");
            entity.Property(e => e.VirIssueBillVol).HasColumnType("money");

            entity.HasOne(d => d.BrancheCodeNavigation).WithMany(p => p.FixIncomeProperties)
                .HasForeignKey(d => d.BrancheCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FixIncomeProperties_Branches Info");

            entity.HasOne(d => d.InComeCenter).WithMany(p => p.FixIncomeProperties)
                .HasForeignKey(d => d.InComeCenterId)
                .HasConstraintName("FK_FixIncomeProperties_IncomeCenter");
        });

        modelBuilder.Entity<HrMonthlyReport>(entity =>
        {
            entity.ToTable("HR Monthly Report");

            entity.Property(e => e.HrmonthlyreportId)
                .ValueGeneratedNever()
                .HasColumnName("HRMonthlyreportID");
            entity.Property(e => e.Gcissu).HasColumnName("GCIssu");
            entity.Property(e => e.HrmhiredQty).HasColumnName("HRMHiredQty");
            entity.Property(e => e.HrpersonnelQty).HasColumnName("HRpersonnelQty");
            entity.Property(e => e.IntQty).HasColumnName("IntQTy");
            entity.Property(e => e.MngRfailQty).HasColumnName("MngRFailQty");
            entity.Property(e => e.Month)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Obqty).HasColumnName("OBQty");
            entity.Property(e => e.PreFailQty).HasColumnName("PreFailQTy");
            entity.Property(e => e.Reqqty).HasColumnName("REQQty");
            entity.Property(e => e.RrfacFail).HasColumnName("RRFAcFail");
            entity.Property(e => e.Rrfail).HasColumnName("RRFail");
            entity.Property(e => e.SentCvtoDep).HasColumnName("SentCVToDep");
        });

        modelBuilder.Entity<IncomeCenter>(entity =>
        {
            entity.ToTable("IncomeCenter");

            entity.Property(e => e.IncomecenterId)
                .ValueGeneratedNever()
                .HasColumnName("IncomecenterID");
            entity.Property(e => e.IncomeCenterName).HasMaxLength(50);
        });

        modelBuilder.Entity<Kpicrm>(entity =>
        {
            entity.HasKey(e => e.Kpicrmcode);

            entity.ToTable("KPICRM");

            entity.Property(e => e.Kpicrmcode)
                .ValueGeneratedNever()
                .HasColumnName("KPICRMCode");
            entity.Property(e => e.AutAnsPercent)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CallAnsSat)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CallAnsSpd)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CallDuration)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Crmiss)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CRMIss");
            entity.Property(e => e.Csat)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CSAT");
            entity.Property(e => e.CusReqMetPer)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CusSat)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.DelAvr)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Fcsp)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("FCSP");
            entity.Property(e => e.HocallQty)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("HOCallQty");
            entity.Property(e => e.IdeCusNeed)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.LeftCallPercent)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MissedCallPercent)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MrkOutcall)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.NegFb)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("NegFB");
            entity.Property(e => e.NewtooldSat)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("newtooldSat");
            entity.Property(e => e.OutcallCostAvg)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.PerImpPrdSur)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.PrdAwaPer)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SrvPrdSatPer)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TicQty)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UsersComImpSer)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Wtunder3)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("WTUnder3");
        });

        modelBuilder.Entity<Kpidevelopment>(entity =>
        {
            entity.HasKey(e => e.KpidevelomentCode);

            entity.ToTable("KPIDevelopment");

            entity.Property(e => e.KpidevelomentCode)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("KPIDevelomentCode");
            entity.Property(e => e.AccsugRate)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ACCSugRate");
            entity.Property(e => e.ColRate)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdeCusNeed)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.InvSugAvgTime)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.NewCusinSrvPrd)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.NewTooldsat)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.PerImpPrdSur)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.PrdAwaPer)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.RdinPrdImp)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("RDinPrdImp");
            entity.Property(e => e.SolutionAvgTime)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SugCap)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SugInc)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Kpifinancial>(entity =>
        {
            entity.ToTable("KPIFinancial");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcrFinRepPer)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.BillIssueAvgTime)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CnrctrInvoicesMatch)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Cnt)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CtrTimeDuration)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.DemistakeFin)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("DEMistakeFin");
            entity.Property(e => e.DevPlnBudPer)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.FixedAssetConflict)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("fixedAssetConflict");
            entity.Property(e => e.IncBudMeetPer)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.KpifinCode)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("KPIFinCode");
            entity.Property(e => e.OdrecintotalRec)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ODRecintotalRec");
            entity.Property(e => e.OtdecLegRe)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("OTDecLegRe");
            entity.Property(e => e.RvwAccConflicts)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.RvwInvConflicts)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Kpihr>(entity =>
        {
            entity.ToTable("KPIHR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ColLoyPer)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ColSat)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.EduCap)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.EduEfc)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.GenEduCap)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.HrRecDelRat)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IctsrvSat)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ICTSrvSat");
            entity.Property(e => e.IntColCam)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Kpihrcode).HasColumnName("KPIHRCode");
            entity.Property(e => e.MgmEduCap)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MistakeinPersonalInfo)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.OutcallCostAvg)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.PapConCap)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ProEduCap)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.RecDelRat)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.RecEff)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ReqToNeed)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Sal)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SalMistakePerc)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SurveyFeedback)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TrnColeagPer)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Kpimarket>(entity =>
        {
            entity.ToTable("KPIMarket");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BrcMrkRti)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.KpimarketingCode)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("KPIMarketingCode");
            entity.Property(e => e.LegMrk)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MrkStgDsg)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.NewCusAsset)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.NewUser)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.RegistertoIssue)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SalePlanDsg)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Kpiplanning>(entity =>
        {
            entity.ToTable("KPIPlanning");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ArchivePer)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.DelonPrConf)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.EffImpAct)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.KmsavePercent)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("KMSavePercent");
            entity.Property(e => e.KpiplanCode)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("KPIPlanCode");
            entity.Property(e => e.Nps)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("NPS");
            entity.Property(e => e.OtimpPercentage)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("OTImpPercentage");
            entity.Property(e => e.PrImPercent)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<MarketingMonthlyReport>(entity =>
        {
            entity.HasKey(e => e.Mrkmrid);

            entity.ToTable("Marketing Monthly Report");

            entity.Property(e => e.Mrkmrid)
                .ValueGeneratedNever()
                .HasColumnName("MRKMRId");
            entity.Property(e => e.KeywordsRank).HasColumnName("keywordsRank");
            entity.Property(e => e.Month)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SmedEntQty).HasColumnName("SMedEntQty");
        });

        modelBuilder.Entity<MixProperty>(entity =>
        {
            entity.HasKey(e => e.MixIncomeId);

            entity.Property(e => e.MixIncomeId).ValueGeneratedNever();
            entity.Property(e => e.GoharIssue).HasColumnType("money");
            entity.Property(e => e.GoharRev).HasColumnType("money");
            entity.Property(e => e.MonthName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ServatIssue).HasColumnType("money");
            entity.Property(e => e.ServatRev).HasColumnType("money");
            entity.Property(e => e.TotalIssue).HasColumnType("money");
            entity.Property(e => e.TotalRev).HasColumnType("money");

            entity.HasOne(d => d.BrancheCodeNavigation).WithMany(p => p.MixProperties)
                .HasForeignKey(d => d.BrancheCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MixProperties_Branches Info");

            entity.HasOne(d => d.IncomeCenter).WithMany(p => p.MixProperties)
                .HasForeignKey(d => d.IncomeCenterId)
                .HasConstraintName("FK_MixProperties_MixProperties");
        });

        modelBuilder.Entity<OperationKpi>(entity =>
        {
            entity.ToTable("OperationKpi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Answeringspeed)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.AppDev)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Cus)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CusAutAsset)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ErrApp)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IbCardAutAvgTime)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.OperationKpicode)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("OperationKPICode");
            entity.Property(e => e.PayToCusAvgTime)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("payToCusAvgTime");
            entity.Property(e => e.Piapp)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("PIApp");
            entity.Property(e => e.SejAutAvgTime)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SucOprRate)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<OperationMonthlyReport>(entity =>
        {
            entity.ToTable("Operation Monthly Report");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AbCandookhtehBranch)
                .HasColumnType("money")
                .HasColumnName("AbCAndookhtehBranch");
            entity.Property(e => e.AbCandookhtehBranchRe)
                .HasColumnType("money")
                .HasColumnName("AbCAndookhtehBranchRE");
            entity.Property(e => e.AbCandookhtehOtherBanks)
                .HasColumnType("money")
                .HasColumnName("AbCAndookhtehOtherBanks");
            entity.Property(e => e.AbCandookhtehOtherBanksRe)
                .HasColumnType("money")
                .HasColumnName("AbCAndookhtehOtherBanksRE");
            entity.Property(e => e.AbCandookhtehSamaneh)
                .HasColumnType("money")
                .HasColumnName("AbCAndookhtehSamaneh");
            entity.Property(e => e.AbCandookhtehSamanehRe)
                .HasColumnType("money")
                .HasColumnName("AbCAndookhtehSamanehRE");
            entity.Property(e => e.AbCandookhtehSandogh)
                .HasColumnType("money")
                .HasColumnName("AbCAndookhtehSandogh");
            entity.Property(e => e.AbCandookhtehSandoghRe)
                .HasColumnType("money")
                .HasColumnName("AbCAndookhtehSandoghRE");
            entity.Property(e => e.AbCandookhtehShahr)
                .HasColumnType("money")
                .HasColumnName("AbCAndookhtehShahr");
            entity.Property(e => e.AbCandookhtehShahrRe)
                .HasColumnType("money")
                .HasColumnName("AbCAndookhtehShahrRE");
            entity.Property(e => e.AbCandookhtehShahrnet)
                .HasColumnType("money")
                .HasColumnName("AbCAndookhtehShahrnet");
            entity.Property(e => e.AbCandookhtehShahrnetRe)
                .HasColumnType("money")
                .HasColumnName("AbCAndookhtehShahrnetRE");
            entity.Property(e => e.AbCandookhtehTamaddon)
                .HasColumnType("money")
                .HasColumnName("AbCAndookhtehTamaddon");
            entity.Property(e => e.AbCandookhtehTamaddonRe)
                .HasColumnType("money")
                .HasColumnName("AbCAndookhtehTamaddonRE");
            entity.Property(e => e.AbCandookhtehTotal)
                .HasColumnType("money")
                .HasColumnName("AbCAndookhtehTotal");
            entity.Property(e => e.AbCandookhtehTotalRe)
                .HasColumnType("money")
                .HasColumnName("AbCAndookhtehTotalRE");
            entity.Property(e => e.AbCganjinehBranches).HasColumnType("money");
            entity.Property(e => e.AbCganjinehBranchesRe)
                .HasColumnType("money")
                .HasColumnName("AbCganjinehBranchesRE");
            entity.Property(e => e.AbCganjinehSamaneh).HasColumnType("money");
            entity.Property(e => e.AbCganjinehSamanehRe)
                .HasColumnType("money")
                .HasColumnName("AbCganjinehSamanehRE");
            entity.Property(e => e.AbCganjinehSandogh).HasColumnType("money");
            entity.Property(e => e.AbCganjinehSandoghRe)
                .HasColumnType("money")
                .HasColumnName("AbCganjinehSandoghRE");
            entity.Property(e => e.AbCganjinehShahr).HasColumnType("money");
            entity.Property(e => e.AbCganjinehShahrRe)
                .HasColumnType("money")
                .HasColumnName("AbCganjinehShahrRE");
            entity.Property(e => e.AbCganjinehShahrnet).HasColumnType("money");
            entity.Property(e => e.AbCganjinehShahrnetRe)
                .HasColumnType("money")
                .HasColumnName("AbCganjinehShahrnetRE");
            entity.Property(e => e.AbCganjinehTamaddon)
                .HasColumnType("money")
                .HasColumnName("AbCGanjinehTamaddon");
            entity.Property(e => e.AbCganjinehTamaddonRe)
                .HasColumnType("money")
                .HasColumnName("AbCGanjinehTamaddonRE");
            entity.Property(e => e.AbCganjinehTotal).HasColumnType("money");
            entity.Property(e => e.AbCganjinehTotalRe)
                .HasColumnType("money")
                .HasColumnName("AbCganjinehTotalRE");
            entity.Property(e => e.AbCgoharBranch)
                .HasColumnType("money")
                .HasColumnName("AbCGoharBranch");
            entity.Property(e => e.AbCgoharBranchRe)
                .HasColumnType("money")
                .HasColumnName("AbCGoharBranchRE");
            entity.Property(e => e.AbCgoharSamaneh)
                .HasColumnType("money")
                .HasColumnName("AbCGoharSamaneh");
            entity.Property(e => e.AbCgoharSamanehRe)
                .HasColumnType("money")
                .HasColumnName("AbCGoharSamanehRE");
            entity.Property(e => e.AbCgoharSandogh)
                .HasColumnType("money")
                .HasColumnName("AbCGoharSandogh");
            entity.Property(e => e.AbCgoharSandoghRe)
                .HasColumnType("money")
                .HasColumnName("AbCGoharSandoghRE");
            entity.Property(e => e.AbCgoharTamaddon)
                .HasColumnType("money")
                .HasColumnName("AbCGoharTamaddon");
            entity.Property(e => e.AbCgoharTamaddonRe)
                .HasColumnType("money")
                .HasColumnName("AbCGoharTamaddonRE");
            entity.Property(e => e.AbCgoharTotal)
                .HasColumnType("money")
                .HasColumnName("AbCGoharTotal");
            entity.Property(e => e.AbCgoharTotalRe)
                .HasColumnType("money")
                .HasColumnName("AbCGoharTotalRE");
            entity.Property(e => e.AbCservatBranch)
                .HasColumnType("money")
                .HasColumnName("AbCServatBranch");
            entity.Property(e => e.AbCservatBranchRe)
                .HasColumnType("money")
                .HasColumnName("AbCServatBranchRE");
            entity.Property(e => e.AbCservatSamaneh)
                .HasColumnType("money")
                .HasColumnName("AbCServatSamaneh");
            entity.Property(e => e.AbCservatSamanehRe)
                .HasColumnType("money")
                .HasColumnName("AbCServatSamanehRE");
            entity.Property(e => e.AbCservatSandogh)
                .HasColumnType("money")
                .HasColumnName("AbCServatSandogh");
            entity.Property(e => e.AbCservatSandoghRe)
                .HasColumnType("money")
                .HasColumnName("AbCServatSandoghRE");
            entity.Property(e => e.AbCservatTamaddon)
                .HasColumnType("money")
                .HasColumnName("AbCServatTamaddon");
            entity.Property(e => e.AbCservatTamaddonRe)
                .HasColumnType("money")
                .HasColumnName("AbCServatTamaddonRE");
            entity.Property(e => e.AbCservatTotal)
                .HasColumnType("money")
                .HasColumnName("AbCServatTotal");
            entity.Property(e => e.AbCservatTotalRe)
                .HasColumnType("money")
                .HasColumnName("AbCServatTotalRE");
            entity.Property(e => e.BkgReqCnfqty).HasColumnName("BkgReqCNFQty");
            entity.Property(e => e.Month)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MonthNumber).HasColumnName("Month Number");
            entity.Property(e => e.Oprmrid).HasColumnName("OPRMRId");
        });

        modelBuilder.Entity<ProcessDesignMonthlyReport>(entity =>
        {
            entity.HasKey(e => e.ProcessDesignMrid);

            entity.ToTable("ProcessDesignMonthlyReport");

            entity.Property(e => e.ProcessDesignMrid)
                .ValueGeneratedNever()
                .HasColumnName("ProcessDesignMRId");
            entity.Property(e => e.CrmcommHold).HasColumnName("CRMCommHold");
            entity.Property(e => e.CrmdoneCmm).HasColumnName("CRMDoneCmm");
            entity.Property(e => e.CrmfailCmm).HasColumnName("CRMFailCmm");
            entity.Property(e => e.KpimonitoringQty).HasColumnName("KPIMonitoringQty");
            entity.Property(e => e.Month)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MrkDoneCmm).HasColumnName("MRkDoneCmm");
            entity.Property(e => e.MrkFailCmm).HasColumnName("MRkFailCmm");
            entity.Property(e => e.MrkcommHold).HasColumnName("MRKCommHold");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductsId);

            entity.Property(e => e.ProductsId)
                .ValueGeneratedNever()
                .HasColumnName("ProductsID");
            entity.Property(e => e.DealValue).HasColumnType("money");
            entity.Property(e => e.IbcrowdVol).HasColumnType("money");
            entity.Property(e => e.Income).HasColumnType("money");
            entity.Property(e => e.MonthName)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.BrancheCodeNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.BrancheCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Products_Branches Info");

            entity.HasOne(d => d.IncomeCenter).WithMany(p => p.Products)
                .HasForeignKey(d => d.IncomeCenterId)
                .HasConstraintName("FK_Products_Products");
        });

        modelBuilder.Entity<ProductDevelopmentMontylyReport>(entity =>
        {
            entity.HasKey(e => e.DevMrid);

            entity.ToTable("Product Development Montyly Report");

            entity.Property(e => e.DevMrid)
                .ValueGeneratedNever()
                .HasColumnName("DevMRId");
            entity.Property(e => e.Month)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<QaMonthlyReport>(entity =>
        {
            entity.HasKey(e => e.Qamrid);

            entity.ToTable("QA Monthly Report");

            entity.Property(e => e.Qamrid)
                .ValueGeneratedNever()
                .HasColumnName("QAMRId");
            entity.Property(e => e.AgradeQty).HasColumnName("AGradeQty");
            entity.Property(e => e.ApgradeQty).HasColumnName("APGradeQty");
            entity.Property(e => e.BgradeQty).HasColumnName("BGradeQty");
            entity.Property(e => e.CgradeQty).HasColumnName("CGradeQty");
            entity.Property(e => e.DgradeQty).HasColumnName("DGradeQty");
            entity.Property(e => e.EgradeQty).HasColumnName("EGradeQty");
            entity.Property(e => e.FgradeQty).HasColumnName("FGradeQty");
            entity.Property(e => e.GgradeQty).HasColumnName("GGradeQty");
            entity.Property(e => e.HgradeQty).HasColumnName("HGradeQty");
            entity.Property(e => e.Month)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MonthNumber).HasColumnName("Month_Number");
            entity.Property(e => e.SurFailPerChatQty).HasColumnName("SurFailPerCHAtQty");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.Property(e => e.ReportId)
                .ValueGeneratedNever()
                .HasColumnName("ReportID");
            entity.Property(e => e.ReportName).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.NationalCode).HasMaxLength(10);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
