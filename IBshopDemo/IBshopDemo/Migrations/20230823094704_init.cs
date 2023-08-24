using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IBshopDemo.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Art Monthly Report",
                columns: table => new
                {
                    ArtMonthlyReportId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    MrkReq = table.Column<int>(type: "int", nullable: false),
                    CompStudy = table.Column<int>(type: "int", nullable: false),
                    ArchiveDesignQty = table.Column<int>(type: "int", nullable: false),
                    MediaFailureQty = table.Column<int>(type: "int", nullable: false),
                    SiteBannerAvgTime = table.Column<int>(type: "int", nullable: false),
                    brochureDesignAvgTime = table.Column<int>(type: "int", nullable: false),
                    StoryDesignAvgTime = table.Column<int>(type: "int", nullable: false),
                    GifDesignAvgTime = table.Column<int>(type: "int", nullable: false),
                    StandDesignAvgTime = table.Column<int>(type: "int", nullable: false),
                    BannerDesignQTY = table.Column<int>(type: "int", nullable: false),
                    BrochureDesignQty = table.Column<int>(type: "int", nullable: false),
                    StoryDesignQty = table.Column<int>(type: "int", nullable: false),
                    GifDesignQty = table.Column<int>(type: "int", nullable: false),
                    StandDesigQty = table.Column<int>(type: "int", nullable: false),
                    MotionQTY = table.Column<int>(type: "int", nullable: false),
                    ArchivedmotionQty = table.Column<int>(type: "int", nullable: false),
                    AppliedMotionAVgTime = table.Column<int>(type: "int", nullable: false),
                    RecordedvideoQty = table.Column<int>(type: "int", nullable: false),
                    RecordedQty = table.Column<int>(type: "int", nullable: false),
                    NarrationEditQty = table.Column<int>(type: "int", nullable: false),
                    VideoArchiveQty = table.Column<int>(type: "int", nullable: false),
                    VideoProduceAvgTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Art Monthly Report", x => x.ArtMonthlyReportId);
                });

            migrationBuilder.CreateTable(
                name: "Branch Manager Monthly Report",
                columns: table => new
                {
                    BranchManagerMonthlyReportIdBranchManagerMonthlyReportId = table.Column<int>(name: "BranchManagerMonthlyReportId]\r\nBranchManagerMonthlyReportId", type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    BranchCode = table.Column<int>(type: "int", nullable: false),
                    BranchLocation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    iBcardMRKMTGQty = table.Column<int>(type: "int", nullable: false),
                    iBcardSuccessMTGQty = table.Column<int>(type: "int", nullable: false),
                    iBcrowdMRKMTGQty = table.Column<int>(type: "int", nullable: false),
                    iBcrowdSuccessMTGQty = table.Column<int>(type: "int", nullable: false),
                    AssuranceMRKMTGQty = table.Column<int>(type: "int", nullable: false),
                    AssuranceSuccessMTGQty = table.Column<int>(type: "int", nullable: false),
                    DebtSharesMRKMTGQty = table.Column<int>(type: "int", nullable: false),
                    DebtSharesSuccessMTGQty = table.Column<int>(type: "int", nullable: false),
                    InvestmentMRKMTGQty = table.Column<int>(type: "int", nullable: false),
                    InvesmentSuccessMTGQty = table.Column<int>(type: "int", nullable: false),
                    CoursesReq = table.Column<int>(type: "int", nullable: false),
                    CoursesMRKMTGQty = table.Column<int>(type: "int", nullable: false),
                    CoursesMRKMTGFirstAgreementQty = table.Column<int>(type: "int", nullable: false),
                    ComplainantQty = table.Column<int>(type: "int", nullable: false),
                    Conciliation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch Manager Monthly Report", x => x.BranchManagerMonthlyReportIdBranchManagerMonthlyReportId);
                });

            migrationBuilder.CreateTable(
                name: "Branches Info",
                columns: table => new
                {
                    BranchCode = table.Column<int>(type: "int", nullable: false),
                    BranchLocation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BranchManager = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches Info", x => x.BranchCode);
                });

            migrationBuilder.CreateTable(
                name: "Branches Monthly Report",
                columns: table => new
                {
                    BranchMonthlyReportId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    IbcardConflictBranchQty = table.Column<int>(type: "int", nullable: false),
                    ibcrowdConflictBranchQty = table.Column<int>(type: "int", nullable: false),
                    iBcrowdKPIconflictQty = table.Column<int>(type: "int", nullable: false),
                    CoursesQty = table.Column<int>(type: "int", nullable: false),
                    OnlineExamsQty = table.Column<int>(type: "int", nullable: false),
                    CoursesNeedQty = table.Column<int>(type: "int", nullable: false),
                    ServicesToBranchQty = table.Column<int>(type: "int", nullable: false),
                    CandstoDevelopmentQty = table.Column<int>(type: "int", nullable: false),
                    ReportsConflictsToBranchQty = table.Column<int>(type: "int", nullable: false),
                    InvestmentCapitalConflicts = table.Column<int>(type: "int", nullable: false),
                    FacilityReqQty = table.Column<int>(type: "int", nullable: false),
                    SWSolvedQty = table.Column<int>(type: "int", nullable: false),
                    FundSettlementQty = table.Column<int>(type: "int", nullable: false),
                    FundsConflictsQty = table.Column<int>(type: "int", nullable: false),
                    SendtoBranch = table.Column<int>(type: "int", nullable: false),
                    MRKPacTOBranchQty = table.Column<int>(type: "int", nullable: false),
                    CRTToCusQty = table.Column<int>(type: "int", nullable: false),
                    InpersonBranchQty = table.Column<int>(type: "int", nullable: false),
                    BranchTickects = table.Column<int>(type: "int", nullable: false),
                    TicketConflictsQty = table.Column<int>(type: "int", nullable: false),
                    BranchInfractionQty = table.Column<int>(type: "int", nullable: false),
                    BranchReformQty = table.Column<int>(type: "int", nullable: false),
                    BranchMonQty = table.Column<int>(type: "int", nullable: false),
                    BranchCompCheckedQty = table.Column<int>(type: "int", nullable: false),
                    AccBranchQty = table.Column<int>(type: "int", nullable: false),
                    BranchCompQty = table.Column<int>(type: "int", nullable: false),
                    BranchpersonnelQty = table.Column<int>(type: "int", nullable: false),
                    PersonnelAssuranceReqQty = table.Column<int>(type: "int", nullable: false),
                    PersonnelAdReqQty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CRM Monthly Report", x => x.BranchMonthlyReportId);
                });

            migrationBuilder.CreateTable(
                name: "BranchKPI",
                columns: table => new
                {
                    KPIBranchCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    WRSupReq = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    WrongIssue = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    BrcCnf = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    WrongQty = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    BrnReqQty = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    branchCap = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    PurchaseAvgTime = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Kllevel = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ConIntMonPercentage = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ClienttoIssue = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    BrcClient = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    MrkSpv = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    NewUser = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchKPI", x => x.KPIBranchCode);
                });

            migrationBuilder.CreateTable(
                name: "BranchRanking",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchRankingID = table.Column<int>(type: "int", nullable: true),
                    BranchID = table.Column<int>(type: "int", nullable: true),
                    GanjinehRank = table.Column<int>(type: "int", nullable: true),
                    Andokhtehrank = table.Column<int>(type: "int", nullable: true),
                    ServatRank = table.Column<int>(type: "int", nullable: true),
                    Bimehrank = table.Column<int>(type: "int", nullable: true),
                    iBcrowdrank = table.Column<int>(type: "int", nullable: true),
                    Productrank = table.Column<int>(type: "int", nullable: true),
                    Sandoghrank = table.Column<int>(type: "int", nullable: true),
                    SatisfactionRank = table.Column<int>(type: "int", nullable: true),
                    servicerank = table.Column<int>(type: "int", nullable: true),
                    TotalRank = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BranchRa__3213E83F7329D2F5", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CRM Monthly Reports",
                columns: table => new
                {
                    CRMMRId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    InChatQty = table.Column<int>(type: "int", nullable: false),
                    InCompCallQty = table.Column<int>(type: "int", nullable: false),
                    InVmQty = table.Column<int>(type: "int", nullable: false),
                    InCallQty = table.Column<int>(type: "int", nullable: false),
                    OutAccNumEditQty = table.Column<int>(type: "int", nullable: false),
                    OutsurveyQty = table.Column<int>(type: "int", nullable: false),
                    OutComTrtQty = table.Column<int>(type: "int", nullable: false),
                    OutVmQty = table.Column<int>(type: "int", nullable: false),
                    SejamQty = table.Column<int>(type: "int", nullable: false),
                    AvgCallDuration = table.Column<double>(type: "float", nullable: false),
                    AvgCallWaitingDuration = table.Column<double>(type: "float", nullable: false),
                    ToalCallDuration = table.Column<double>(type: "float", nullable: false),
                    GanjinehIssuesQty = table.Column<int>(type: "int", nullable: false),
                    GanjinehIssuesVol = table.Column<double>(type: "float", nullable: false),
                    AndookhtehIssuesQty = table.Column<int>(type: "int", nullable: false),
                    AndookhtehIssuesVol = table.Column<double>(type: "float", nullable: false),
                    GoharandServatIssuesQty = table.Column<int>(type: "int", nullable: false),
                    GoharandServatIssuesVol = table.Column<double>(type: "float", nullable: false),
                    TotalIssuesQty = table.Column<int>(type: "int", nullable: false),
                    TotalIssuesVol = table.Column<double>(type: "float", nullable: false),
                    CRMcoursesQty = table.Column<int>(type: "int", nullable: false),
                    TicketOnlineQty = table.Column<int>(type: "int", nullable: false),
                    INTicket = table.Column<int>(type: "int", nullable: false),
                    ComplaintTicketQty = table.Column<int>(type: "int", nullable: false),
                    SurveyTicketQty = table.Column<int>(type: "int", nullable: false),
                    InSurveyCallQty = table.Column<int>(type: "int", nullable: false),
                    OutSurveyCallQty = table.Column<int>(type: "int", nullable: false),
                    OnlineChatsurveyQty = table.Column<int>(type: "int", nullable: false),
                    GanjinehTicketQty = table.Column<int>(type: "int", nullable: false),
                    AndookhtehicketQty = table.Column<int>(type: "int", nullable: false),
                    ServatafarinanTicketQty = table.Column<int>(type: "int", nullable: false),
                    GoharTicketQty = table.Column<int>(type: "int", nullable: false),
                    ibCardTicketQty = table.Column<int>(type: "int", nullable: false),
                    ibCrowdTicketQty = table.Column<int>(type: "int", nullable: false),
                    BranchComplTicketQty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CRM Monthly Reports", x => x.CRMMRId);
                });

            migrationBuilder.CreateTable(
                name: "Financial Monthly Report",
                columns: table => new
                {
                    FinancialMRId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    PersonnelSetQty = table.Column<int>(type: "int", nullable: false),
                    CheckedfundQty = table.Column<int>(type: "int", nullable: false),
                    ContQty = table.Column<int>(type: "int", nullable: false),
                    TreasuryBillsQty = table.Column<int>(type: "int", nullable: false),
                    Recivedgaurantee = table.Column<int>(type: "int", nullable: false),
                    RestaxinstallmentQty = table.Column<int>(type: "int", nullable: false),
                    ResFundInstallmenQty = table.Column<int>(type: "int", nullable: false),
                    TaminInstallmentQty = table.Column<int>(type: "int", nullable: false),
                    TaminPenaltyVol = table.Column<int>(type: "int", nullable: false),
                    TranCommissionQty = table.Column<int>(type: "int", nullable: false),
                    TaminInstallmentDelay = table.Column<int>(type: "int", nullable: false),
                    TaxInstallmentDelay = table.Column<int>(type: "int", nullable: false),
                    PrpReqQty = table.Column<int>(type: "int", nullable: false),
                    MTNPrpQty = table.Column<int>(type: "int", nullable: false),
                    ColPrpQty = table.Column<int>(type: "int", nullable: false),
                    LblPrpQty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Financial Monthly Report", x => x.FinancialMRId);
                });

            migrationBuilder.CreateTable(
                name: "Financial SuperMarket Monthly Report",
                columns: table => new
                {
                    SuperMRId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    CustomersReplyQty = table.Column<int>(type: "int", nullable: false),
                    IBshoppRegisterQty = table.Column<int>(type: "int", nullable: false),
                    AuthenticationQty = table.Column<int>(type: "int", nullable: false),
                    ActivationQty = table.Column<int>(type: "int", nullable: false),
                    ReportForCustomerC = table.Column<int>(type: "int", nullable: false),
                    ReportForCustomerF = table.Column<int>(type: "int", nullable: false),
                    GanjinehIssueReqQty = table.Column<int>(type: "int", nullable: false),
                    GanjinehIssuesVol = table.Column<int>(type: "int", nullable: false),
                    AndookhtehIssueReqQty = table.Column<int>(type: "int", nullable: false),
                    AndookhtehIssuesVol = table.Column<int>(type: "int", nullable: false),
                    GoharandServatIssueReqQty = table.Column<int>(type: "int", nullable: false),
                    GohrandServatIssuesVol = table.Column<int>(type: "int", nullable: false),
                    GanjinehRevokeReqQty = table.Column<int>(type: "int", nullable: false),
                    GanjinehRevokeVol = table.Column<int>(type: "int", nullable: false),
                    AndookhtehRevokeReqQty = table.Column<int>(type: "int", nullable: false),
                    AndookhtehRevokeVol = table.Column<int>(type: "int", nullable: false),
                    GoharandServatRevokeReqQty = table.Column<int>(type: "int", nullable: false),
                    GohrandServatRevokeVol = table.Column<int>(type: "int", nullable: false),
                    TotIsuuVol = table.Column<int>(type: "int", nullable: false),
                    TotRevVol = table.Column<int>(type: "int", nullable: false),
                    EditQty = table.Column<int>(type: "int", nullable: false),
                    LegalServQty = table.Column<int>(type: "int", nullable: false),
                    cardIssuanceQty = table.Column<int>(type: "int", nullable: false),
                    TotalIbcardVol = table.Column<int>(type: "int", nullable: false),
                    InvestorsQty = table.Column<int>(type: "int", nullable: false),
                    TotalIbcrowdVol = table.Column<int>(type: "int", nullable: false),
                    InsuranceIssued = table.Column<int>(type: "int", nullable: false),
                    CreaditQty = table.Column<int>(type: "int", nullable: false),
                    CreaditVol = table.Column<int>(type: "int", nullable: false),
                    OnlineCodeQty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Financial SuperMarket Monthly Report", x => x.SuperMRId);
                });

            migrationBuilder.CreateTable(
                name: "HR Monthly Report",
                columns: table => new
                {
                    HRMonthlyreportID = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    HRpersonnelQty = table.Column<int>(type: "int", nullable: false),
                    LeftQty = table.Column<int>(type: "int", nullable: false),
                    HRMHiredQty = table.Column<int>(type: "int", nullable: false),
                    OBQty = table.Column<int>(type: "int", nullable: false),
                    REQQty = table.Column<int>(type: "int", nullable: false),
                    SentCVToDep = table.Column<int>(type: "int", nullable: false),
                    CoursQty = table.Column<int>(type: "int", nullable: false),
                    IntQTy = table.Column<int>(type: "int", nullable: false),
                    RsgReq = table.Column<int>(type: "int", nullable: false),
                    UsedImp = table.Column<int>(type: "int", nullable: false),
                    GCIssu = table.Column<int>(type: "int", nullable: false),
                    SrvAsgNewPer = table.Column<int>(type: "int", nullable: false),
                    AsuAsgNewPer = table.Column<int>(type: "int", nullable: false),
                    GurReqFun = table.Column<int>(type: "int", nullable: false),
                    GurReqLtt = table.Column<int>(type: "int", nullable: false),
                    PyrDedReqLtt = table.Column<int>(type: "int", nullable: false),
                    SendOutLtt = table.Column<int>(type: "int", nullable: false),
                    SendIntLtt = table.Column<int>(type: "int", nullable: false),
                    RecLtt = table.Column<int>(type: "int", nullable: false),
                    PerEntCnfQty = table.Column<int>(type: "int", nullable: false),
                    PreFailQTy = table.Column<int>(type: "int", nullable: false),
                    ReplacemntQty = table.Column<int>(type: "int", nullable: false),
                    RRFail = table.Column<int>(type: "int", nullable: false),
                    RRFAcFail = table.Column<int>(type: "int", nullable: false),
                    LobFailQty = table.Column<int>(type: "int", nullable: false),
                    FloFailQty = table.Column<int>(type: "int", nullable: false),
                    TblFailQty = table.Column<int>(type: "int", nullable: false),
                    StrFailQty = table.Column<int>(type: "int", nullable: false),
                    MngRFailQty = table.Column<int>(type: "int", nullable: false),
                    BrkFailQty = table.Column<int>(type: "int", nullable: false),
                    PntFailQty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HR Monthly Report", x => x.HRMonthlyreportID);
                });

            migrationBuilder.CreateTable(
                name: "IncomeCenter",
                columns: table => new
                {
                    IncomecenterID = table.Column<int>(type: "int", nullable: false),
                    IncomeCenterName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeCenter", x => x.IncomecenterID);
                });

            migrationBuilder.CreateTable(
                name: "KPICRM",
                columns: table => new
                {
                    KPICRMCode = table.Column<int>(type: "int", nullable: false),
                    NegFB = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    HOCallQty = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    FCSP = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    CusReqMetPer = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    CusSat = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    MissedCallPercent = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    AutAnsPercent = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    LeftCallPercent = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    SrvPrdSatPer = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    DelAvr = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    CallAnsSpd = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    WTUnder3 = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    CallDuration = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    OutcallCostAvg = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    CallAnsSat = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    UsersComImpSer = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TicQty = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IdeCusNeed = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    PrdAwaPer = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    PerImpPrdSur = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    newtooldSat = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    CSAT = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    MrkOutcall = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    CRMIss = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KPICRM", x => x.KPICRMCode);
                });

            migrationBuilder.CreateTable(
                name: "KPIDevelopment",
                columns: table => new
                {
                    KPIDevelomentCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    RDinPrdImp = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IdeCusNeed = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    NewTooldsat = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    PerImpPrdSur = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    PrdAwaPer = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    NewCusinSrvPrd = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    SugCap = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    SugInc = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    InvSugAvgTime = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    SolutionAvgTime = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ColRate = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ACCSugRate = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KPIDevelopment", x => x.KPIDevelomentCode);
                });

            migrationBuilder.CreateTable(
                name: "KPIFinancial",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KPIFinCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    OTDecLegRe = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    RvwAccConflicts = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    RvwInvConflicts = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    DevPlnBudPer = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IncBudMeetPer = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    DEMistakeFin = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    AcrFinRepPer = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Cnt = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    CtrTimeDuration = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    fixedAssetConflict = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    BillIssueAvgTime = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    CnrctrInvoicesMatch = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ODRecintotalRec = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KPIFinancial", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KPIHR",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KPIHRCode = table.Column<int>(type: "int", nullable: false),
                    RecEff = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    EduEfc = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    SurveyFeedback = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TrnColeagPer = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    MistakeinPersonalInfo = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    SalMistakePerc = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ColLoyPer = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    EduCap = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ProEduCap = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    MgmEduCap = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    GenEduCap = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    PapConCap = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IntColCam = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ReqToNeed = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ICTSrvSat = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ColSat = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    OutcallCostAvg = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    RecDelRat = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    HrRecDelRat = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Sal = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KPIHR", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KPIMarket",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KPIMarketingCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    NewUser = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    RegistertoIssue = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    NewCusAsset = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    LegMrk = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    BrcMrkRti = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    SalePlanDsg = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    MrkStgDsg = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KPIMarket", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KPIPlanning",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KPIPlanCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    DelonPrConf = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    EffImpAct = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    OTImpPercentage = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    PrImPercent = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    KMSavePercent = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ArchivePer = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    NPS = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KPIPlanning", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Marketing Monthly Report",
                columns: table => new
                {
                    MRKMRId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    SentSmsQty = table.Column<int>(type: "int", nullable: false),
                    ReportAdvQty = table.Column<int>(type: "int", nullable: false),
                    NotifPushQty = table.Column<int>(type: "int", nullable: false),
                    PostMediaQty = table.Column<int>(type: "int", nullable: false),
                    StateMedAdvQty = table.Column<int>(type: "int", nullable: false),
                    BilboardQty = table.Column<int>(type: "int", nullable: false),
                    SrchEntQty = table.Column<int>(type: "int", nullable: false),
                    RefEntQty = table.Column<int>(type: "int", nullable: false),
                    SMedEntQty = table.Column<int>(type: "int", nullable: false),
                    SiteEntMonthlyAvg = table.Column<int>(type: "int", nullable: false),
                    InstFlwQty = table.Column<int>(type: "int", nullable: false),
                    EngQty = table.Column<int>(type: "int", nullable: false),
                    TlgPostContentQty = table.Column<int>(type: "int", nullable: false),
                    LinkdinContentQty = table.Column<int>(type: "int", nullable: false),
                    DesignQty = table.Column<int>(type: "int", nullable: false),
                    VideoQty = table.Column<int>(type: "int", nullable: false),
                    HoldQty = table.Column<int>(type: "int", nullable: false),
                    HoldComptQty = table.Column<int>(type: "int", nullable: false),
                    RecVidPostQty = table.Column<int>(type: "int", nullable: false),
                    TrainPostQty = table.Column<int>(type: "int", nullable: false),
                    InsFlwQty = table.Column<int>(type: "int", nullable: false),
                    NewsQty = table.Column<int>(type: "int", nullable: false),
                    TrainingCntrctQty = table.Column<int>(type: "int", nullable: false),
                    IbcrowdCalllegalCusQty = table.Column<int>(type: "int", nullable: false),
                    PrdSrvAdvCallQty = table.Column<int>(type: "int", nullable: false),
                    SucCallQty = table.Column<int>(type: "int", nullable: false),
                    ToalInvestVol = table.Column<int>(type: "int", nullable: false),
                    ConversationRate = table.Column<int>(type: "int", nullable: false),
                    BounceRate = table.Column<int>(type: "int", nullable: true),
                    keywordsRank = table.Column<int>(type: "int", nullable: false),
                    GoogleEntTerRate = table.Column<int>(type: "int", nullable: false),
                    LinkEntTerRate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marketing Monthly Report", x => x.MRKMRId);
                });

            migrationBuilder.CreateTable(
                name: "Operation Monthly Report",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OPRMRId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    MonthNumber = table.Column<int>(name: "Month Number", type: "int", nullable: true),
                    Month = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    BillConflictReqQty = table.Column<int>(type: "int", nullable: false),
                    PoseConflictReqQty = table.Column<int>(type: "int", nullable: false),
                    SmsinternetConflictReqQty = table.Column<int>(type: "int", nullable: false),
                    BranchInternetConflictReqQty = table.Column<int>(type: "int", nullable: false),
                    IntternetEntranceConflictReq = table.Column<int>(type: "int", nullable: false),
                    FixedConflictQty = table.Column<int>(type: "int", nullable: false),
                    TotalConflictsProcess = table.Column<int>(type: "int", nullable: false),
                    BkgNewCustomer = table.Column<int>(type: "int", nullable: false),
                    BkgReqCNFQty = table.Column<int>(type: "int", nullable: false),
                    BkgCrdVol = table.Column<int>(type: "int", nullable: false),
                    BkgCrdQty = table.Column<int>(type: "int", nullable: false),
                    TotalIbcardIssuesVol = table.Column<int>(type: "int", nullable: false),
                    TotalIbcardIssuesQty = table.Column<int>(type: "int", nullable: false),
                    TotalTransferVol = table.Column<int>(type: "int", nullable: false),
                    TotalmsgQty = table.Column<int>(type: "int", nullable: false),
                    RemotChcAut = table.Column<int>(type: "int", nullable: false),
                    TotalEditAcc = table.Column<int>(type: "int", nullable: false),
                    TotalIdeEdit = table.Column<int>(type: "int", nullable: false),
                    TotalLegAut = table.Column<int>(type: "int", nullable: false),
                    TotalChcSejam = table.Column<int>(type: "int", nullable: false),
                    TotalIssuCrt = table.Column<int>(type: "int", nullable: false),
                    AbCGanjinehTamaddon = table.Column<decimal>(type: "money", nullable: true),
                    AbCGanjinehTamaddonRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCganjinehShahr = table.Column<decimal>(type: "money", nullable: true),
                    AbCganjinehShahrRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCganjinehSandogh = table.Column<decimal>(type: "money", nullable: true),
                    AbCganjinehSandoghRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCganjinehSamaneh = table.Column<decimal>(type: "money", nullable: true),
                    AbCganjinehSamanehRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCganjinehBranches = table.Column<decimal>(type: "money", nullable: true),
                    AbCganjinehBranchesRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCganjinehShahrnet = table.Column<decimal>(type: "money", nullable: true),
                    AbCganjinehShahrnetRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCganjinehTotal = table.Column<decimal>(type: "money", nullable: true),
                    AbCganjinehTotalRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCAndookhtehTamaddon = table.Column<decimal>(type: "money", nullable: true),
                    AbCAndookhtehTamaddonRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCAndookhtehShahr = table.Column<decimal>(type: "money", nullable: true),
                    AbCAndookhtehShahrRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCAndookhtehOtherBanks = table.Column<decimal>(type: "money", nullable: true),
                    AbCAndookhtehOtherBanksRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCAndookhtehSandogh = table.Column<decimal>(type: "money", nullable: true),
                    AbCAndookhtehSandoghRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCAndookhtehSamaneh = table.Column<decimal>(type: "money", nullable: true),
                    AbCAndookhtehSamanehRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCAndookhtehBranch = table.Column<decimal>(type: "money", nullable: true),
                    AbCAndookhtehBranchRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCAndookhtehShahrnet = table.Column<decimal>(type: "money", nullable: true),
                    AbCAndookhtehShahrnetRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCAndookhtehTotal = table.Column<decimal>(type: "money", nullable: true),
                    AbCAndookhtehTotalRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCServatTamaddon = table.Column<decimal>(type: "money", nullable: true),
                    AbCServatTamaddonRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCServatSamaneh = table.Column<decimal>(type: "money", nullable: true),
                    AbCServatSamanehRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCServatBranch = table.Column<decimal>(type: "money", nullable: true),
                    AbCServatBranchRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCServatSandogh = table.Column<decimal>(type: "money", nullable: true),
                    AbCServatSandoghRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCServatTotal = table.Column<decimal>(type: "money", nullable: true),
                    AbCServatTotalRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCGoharTamaddon = table.Column<decimal>(type: "money", nullable: true),
                    AbCGoharTamaddonRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCGoharSamaneh = table.Column<decimal>(type: "money", nullable: true),
                    AbCGoharSamanehRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCGoharBranch = table.Column<decimal>(type: "money", nullable: true),
                    AbCGoharBranchRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCGoharSandogh = table.Column<decimal>(type: "money", nullable: true),
                    AbCGoharSandoghRE = table.Column<decimal>(type: "money", nullable: true),
                    AbCGoharTotal = table.Column<decimal>(type: "money", nullable: true),
                    AbCGoharTotalRE = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operation Monthly Report", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OperationKpi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationKPICode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    PIApp = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ErrApp = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    AppDev = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Answeringspeed = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IbCardAutAvgTime = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    SejAutAvgTime = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    payToCusAvgTime = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    CusAutAsset = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Cus = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    SucOprRate = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationKpi", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProcessDesignMonthlyReport",
                columns: table => new
                {
                    ProcessDesignMRId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: true),
                    Month = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    PrcdQty = table.Column<int>(type: "int", nullable: false),
                    RelPrcdQty = table.Column<int>(type: "int", nullable: false),
                    InsQty = table.Column<int>(type: "int", nullable: false),
                    RelInsQty = table.Column<int>(type: "int", nullable: false),
                    RegQty = table.Column<int>(type: "int", nullable: false),
                    RelReqQty = table.Column<int>(type: "int", nullable: false),
                    FormQty = table.Column<int>(type: "int", nullable: false),
                    PrcDesign = table.Column<int>(type: "int", nullable: false),
                    ReviewPrc = table.Column<int>(type: "int", nullable: false),
                    AsmPrc = table.Column<int>(type: "int", nullable: false),
                    DlgQty = table.Column<int>(type: "int", nullable: false),
                    IndexQty = table.Column<int>(type: "int", nullable: false),
                    ReviwIndxQty = table.Column<int>(type: "int", nullable: false),
                    KPIMonitoringQty = table.Column<int>(type: "int", nullable: false),
                    MRKCommHold = table.Column<int>(type: "int", nullable: false),
                    MRkDoneCmm = table.Column<int>(type: "int", nullable: false),
                    MRkFailCmm = table.Column<int>(type: "int", nullable: false),
                    DevCommHold = table.Column<int>(type: "int", nullable: false),
                    DevDoneCmm = table.Column<int>(type: "int", nullable: false),
                    DevFailCmm = table.Column<int>(type: "int", nullable: false),
                    CRMCommHold = table.Column<int>(type: "int", nullable: false),
                    CRMDoneCmm = table.Column<int>(type: "int", nullable: false),
                    CRMFailCmm = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessDesignMonthlyReport", x => x.ProcessDesignMRId);
                });

            migrationBuilder.CreateTable(
                name: "Product Development Montyly Report",
                columns: table => new
                {
                    DevMRId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    MonthNumber = table.Column<int>(type: "int", nullable: false),
                    CheckedSuggestQty = table.Column<int>(type: "int", nullable: false),
                    AcceptedSuggestQty = table.Column<int>(type: "int", nullable: false),
                    SuggestPersonnelQty = table.Column<int>(type: "int", nullable: false),
                    EconomicalSuggestQty = table.Column<int>(type: "int", nullable: false),
                    IbcCreaditCardCustQty = table.Column<int>(type: "int", nullable: false),
                    IbcComplQty = table.Column<int>(type: "int", nullable: false),
                    IbcCreadiCardReqQty = table.Column<int>(type: "int", nullable: false),
                    IbcCreaditCardProcessAvgTime = table.Column<int>(type: "int", nullable: false),
                    IbwDesignQty = table.Column<int>(type: "int", nullable: false),
                    IbwDesignVol = table.Column<int>(type: "int", nullable: false),
                    IbwDesignTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product Development Montyly Report", x => x.DevMRId);
                });

            migrationBuilder.CreateTable(
                name: "QA Monthly Report",
                columns: table => new
                {
                    QAMRId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Month_Number = table.Column<int>(type: "int", nullable: false),
                    TotalPersonnelIncCallQty = table.Column<int>(type: "int", nullable: false),
                    TotalChcIncCallQty = table.Column<int>(type: "int", nullable: false),
                    WelFailPerIncQty = table.Column<int>(type: "int", nullable: false),
                    WelFailIncQty = table.Column<int>(type: "int", nullable: false),
                    SurFailPerIncQty = table.Column<int>(type: "int", nullable: false),
                    SurFailIncQty = table.Column<int>(type: "int", nullable: false),
                    KnwFailPerIncQty = table.Column<int>(type: "int", nullable: false),
                    KnwFailIncQty = table.Column<int>(type: "int", nullable: false),
                    ProFailPerIncQty = table.Column<int>(type: "int", nullable: false),
                    ProFailIncQty = table.Column<int>(type: "int", nullable: false),
                    TicFailPerIncQty = table.Column<int>(type: "int", nullable: false),
                    TicFailIncQty = table.Column<int>(type: "int", nullable: false),
                    CalMgtPerIncQty = table.Column<int>(type: "int", nullable: false),
                    CalMgtIncQty = table.Column<int>(type: "int", nullable: false),
                    SysFailPerIncQty = table.Column<int>(type: "int", nullable: false),
                    SysFailIncQty = table.Column<int>(type: "int", nullable: false),
                    TotalPersonnelOutCallQty = table.Column<int>(type: "int", nullable: false),
                    TotalChcOutCallQty = table.Column<int>(type: "int", nullable: false),
                    SurFailPerOutQty = table.Column<int>(type: "int", nullable: false),
                    SurFailOutQty = table.Column<int>(type: "int", nullable: false),
                    ProFailPerOutQty = table.Column<int>(type: "int", nullable: false),
                    ProFailOutQty = table.Column<int>(type: "int", nullable: false),
                    TicFailPerOutQty = table.Column<int>(type: "int", nullable: false),
                    TicFailOutQty = table.Column<int>(type: "int", nullable: false),
                    CalMgtPerOutQty = table.Column<int>(type: "int", nullable: false),
                    CalMgtOutQty = table.Column<int>(type: "int", nullable: false),
                    ToalOnlineChat = table.Column<int>(type: "int", nullable: false),
                    TotalCheckedOnlineChat = table.Column<int>(type: "int", nullable: false),
                    SurFailPerCHAtQty = table.Column<int>(type: "int", nullable: false),
                    SurFailChatQty = table.Column<int>(type: "int", nullable: false),
                    ProFailPerChatQty = table.Column<int>(type: "int", nullable: false),
                    ProFailChatQty = table.Column<int>(type: "int", nullable: false),
                    TicFailPerChatQty = table.Column<int>(type: "int", nullable: false),
                    TicFailChatQty = table.Column<int>(type: "int", nullable: false),
                    TimFailPerChatQty = table.Column<int>(type: "int", nullable: false),
                    TimFailChatQty = table.Column<int>(type: "int", nullable: false),
                    SurveyChatOnline = table.Column<int>(type: "int", nullable: true),
                    HGradeQty = table.Column<int>(type: "int", nullable: false),
                    GGradeQty = table.Column<int>(type: "int", nullable: false),
                    FGradeQty = table.Column<int>(type: "int", nullable: false),
                    EGradeQty = table.Column<int>(type: "int", nullable: false),
                    DGradeQty = table.Column<int>(type: "int", nullable: false),
                    CGradeQty = table.Column<int>(type: "int", nullable: false),
                    BGradeQty = table.Column<int>(type: "int", nullable: false),
                    AGradeQty = table.Column<int>(type: "int", nullable: false),
                    APGradeQty = table.Column<int>(type: "int", nullable: false),
                    RepFail = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QA Monthly Report", x => x.QAMRId);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    ReportID = table.Column<int>(type: "int", nullable: false),
                    ReportName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.ReportID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "FixIncomeProperties",
                columns: table => new
                {
                    FixIncomeID = table.Column<int>(type: "int", nullable: false),
                    BrancheCode = table.Column<int>(type: "int", nullable: false),
                    InComeCenterID = table.Column<int>(type: "int", nullable: true),
                    MonthNumber = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    MonthName = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    CustomerQty = table.Column<int>(type: "int", nullable: true),
                    GanjinehIssue = table.Column<decimal>(type: "money", nullable: false),
                    GanjinehRev = table.Column<decimal>(type: "money", nullable: false),
                    AndookhtehIssue = table.Column<decimal>(type: "money", nullable: false),
                    AndookhtehREv = table.Column<decimal>(type: "money", nullable: false),
                    VirIssueBillQty = table.Column<int>(type: "int", nullable: false),
                    VirIssueBillVol = table.Column<decimal>(type: "money", nullable: false),
                    TotalIssue = table.Column<decimal>(type: "money", nullable: false),
                    TotalRev = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixIncomeProperties", x => x.FixIncomeID);
                    table.ForeignKey(
                        name: "FK_FixIncomeProperties_Branches Info",
                        column: x => x.BrancheCode,
                        principalTable: "Branches Info",
                        principalColumn: "BranchCode");
                    table.ForeignKey(
                        name: "FK_FixIncomeProperties_IncomeCenter",
                        column: x => x.InComeCenterID,
                        principalTable: "IncomeCenter",
                        principalColumn: "IncomecenterID");
                });

            migrationBuilder.CreateTable(
                name: "MixProperties",
                columns: table => new
                {
                    MixIncomeId = table.Column<int>(type: "int", nullable: false),
                    BrancheCode = table.Column<int>(type: "int", nullable: false),
                    IncomeCenterId = table.Column<int>(type: "int", nullable: true),
                    MonthNumber = table.Column<int>(type: "int", nullable: true),
                    MonthName = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ServatIssue = table.Column<decimal>(type: "money", nullable: false),
                    ServatRev = table.Column<decimal>(type: "money", nullable: false),
                    GoharIssue = table.Column<decimal>(type: "money", nullable: false),
                    GoharRev = table.Column<decimal>(type: "money", nullable: false),
                    TotalIssue = table.Column<decimal>(type: "money", nullable: false),
                    TotalRev = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixProperties", x => x.MixIncomeId);
                    table.ForeignKey(
                        name: "FK_MixProperties_Branches Info",
                        column: x => x.BrancheCode,
                        principalTable: "Branches Info",
                        principalColumn: "BranchCode");
                    table.ForeignKey(
                        name: "FK_MixProperties_MixProperties",
                        column: x => x.IncomeCenterId,
                        principalTable: "IncomeCenter",
                        principalColumn: "IncomecenterID");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductsID = table.Column<int>(type: "int", nullable: false),
                    BrancheCode = table.Column<int>(type: "int", nullable: false),
                    IncomeCenterId = table.Column<int>(type: "int", nullable: true),
                    MonthNumber = table.Column<int>(type: "int", nullable: true),
                    MonthName = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    IbcrowdVol = table.Column<decimal>(type: "money", nullable: false),
                    IbcardIssueQty = table.Column<int>(type: "int", nullable: false),
                    CardQty = table.Column<int>(type: "int", nullable: false),
                    KargozariBoursCode = table.Column<int>(type: "int", nullable: false),
                    DealValue = table.Column<decimal>(type: "money", nullable: false),
                    Income = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductsID);
                    table.ForeignKey(
                        name: "FK_Products_Branches Info",
                        column: x => x.BrancheCode,
                        principalTable: "Branches Info",
                        principalColumn: "BranchCode");
                    table.ForeignKey(
                        name: "FK_Products_Products",
                        column: x => x.IncomeCenterId,
                        principalTable: "IncomeCenter",
                        principalColumn: "IncomecenterID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FixIncomeProperties_BrancheCode",
                table: "FixIncomeProperties",
                column: "BrancheCode");

            migrationBuilder.CreateIndex(
                name: "IX_FixIncomeProperties_InComeCenterID",
                table: "FixIncomeProperties",
                column: "InComeCenterID");

            migrationBuilder.CreateIndex(
                name: "IX_MixProperties_BrancheCode",
                table: "MixProperties",
                column: "BrancheCode");

            migrationBuilder.CreateIndex(
                name: "IX_MixProperties_IncomeCenterId",
                table: "MixProperties",
                column: "IncomeCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrancheCode",
                table: "Products",
                column: "BrancheCode");

            migrationBuilder.CreateIndex(
                name: "IX_Products_IncomeCenterId",
                table: "Products",
                column: "IncomeCenterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Art Monthly Report");

            migrationBuilder.DropTable(
                name: "Branch Manager Monthly Report");

            migrationBuilder.DropTable(
                name: "Branches Monthly Report");

            migrationBuilder.DropTable(
                name: "BranchKPI");

            migrationBuilder.DropTable(
                name: "BranchRanking");

            migrationBuilder.DropTable(
                name: "CRM Monthly Reports");

            migrationBuilder.DropTable(
                name: "Financial Monthly Report");

            migrationBuilder.DropTable(
                name: "Financial SuperMarket Monthly Report");

            migrationBuilder.DropTable(
                name: "FixIncomeProperties");

            migrationBuilder.DropTable(
                name: "HR Monthly Report");

            migrationBuilder.DropTable(
                name: "KPICRM");

            migrationBuilder.DropTable(
                name: "KPIDevelopment");

            migrationBuilder.DropTable(
                name: "KPIFinancial");

            migrationBuilder.DropTable(
                name: "KPIHR");

            migrationBuilder.DropTable(
                name: "KPIMarket");

            migrationBuilder.DropTable(
                name: "KPIPlanning");

            migrationBuilder.DropTable(
                name: "Marketing Monthly Report");

            migrationBuilder.DropTable(
                name: "MixProperties");

            migrationBuilder.DropTable(
                name: "Operation Monthly Report");

            migrationBuilder.DropTable(
                name: "OperationKpi");

            migrationBuilder.DropTable(
                name: "ProcessDesignMonthlyReport");

            migrationBuilder.DropTable(
                name: "Product Development Montyly Report");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "QA Monthly Report");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Branches Info");

            migrationBuilder.DropTable(
                name: "IncomeCenter");
        }
    }
}
