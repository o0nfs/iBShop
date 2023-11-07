using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class BranchesMonthlyReportMetaData
    {
        
        public int BranchMonthlyReportId { get; set; }

        [Display(Name ="سال")]
       
        public int Year { get; set; }

        [Display(Name = "ماه")]
     
        public string Month { get; set; } = null!;

        [Display(Name = "شماره ماه")]
    
        public int MonthNumber { get; set; }

        [Display(Name = "تعداد شعب دارای مغایرت های iBcard ")]
      
        public int IbcardConflictBranchQty { get; set; }

        [Display(Name = "تعداد مغایرت های iBcrowd در شعب سوپر مارکت مالی")]
      
        public int IbcrowdConflictBranchQty { get; set; }

        [Display(Name = "تعداد شعب دارای عدم رعایت حداقل تامین مالی در طرح iBcrowd")]
       
        public int IBcrowdKpiconflictQty { get; set; }

        [Display(Name = "تعداد دوره های آموزشی برگزار شده ")]
       
        public int CoursesQty { get; set; }

        [Display(Name = "تعداد برگزاری آزمون های آنلاین")]
       
        public int OnlineExamsQty { get; set; }

        [Display(Name = "تعداد نیازهای آموزشی شناسایی شده  در شعب سوپرمارکت مالی")]
       

        public int CoursesNeedQty { get; set; }

        [Display(Name = "تعداد خدمات ارائه شده به کارگزاری شعب سوپر مارکت مالی")]
    
        public int ServicesToBranchQty { get; set; }

        [Display(Name = "تعداد انتقادات و پیشنهادات ارسال شده به توسعه محصول")]
        
        public int CandstoDevelopmentQty { get; set; }

        [Display(Name = "تعداد مغایرت های گزارش ارسالی شعب سوپرمارکت مالی")]
    
        public int ReportsConflictsToBranchQty { get; set; }

        [Display(Name = "تعداد مغایرت های صندوق سرمایه گذاری انجام شده (ارسالی از عملیات) ")]
        
        public int InvestmentCapitalConflicts { get; set; }

        [Display(Name = "تعداد درخواست های  زیر ساخت تجهیزات")]
       
        public int FacilityReqQty { get; set; }

        [Display(Name = "تعداد اقدامات مشکلات نرم افزاری انجام شده")]
       
        public int SwsolvedQty { get; set; }

        [Display(Name = "تعداد درخواست های تسویه تنخواه")]
       
        public int FundSettlementQty { get; set; }


        [Display(Name = "تعداد مغایرت گیری تنخواه های ارسالی")]
     
        public int FundsConflictsQty { get; set; }


        [Display(Name = "تعداد مرسولات ارسال شده به شعب سوپرمارکت مالی")]
       
        public int SendtoBranch { get; set; }


        [Display(Name = "تعداد اقلام بازایابی نیازمند ارسال به شعب سوپر مارکت مالی")]
       
        public int MrkpacTobranchQty { get; set; }


        [Display(Name = "تعدادگواهی ارسال شده به مشتریان")]
      
        public int CrttoCusQty { get; set; }


        [Display(Name = "تعداد مشتریان مراجعه کننده به شعب سوپر مارکت مالی")]
      
        public int InpersonBranchQty { get; set; }


        [Display(Name = "تعداد تیکت های ثبت شده توسط شعب سوپر مارکت مالی")]
       
        public int BranchTickects { get; set; }


        [Display(Name = "تعداد مغایرت های تیکت های ثبت شده")]
      
        public int TicketConflictsQty { get; set; }


        [Display(Name = "تعداد تخلفات صورت گرفته توسط شعب سوپرمارکت مالی")]
     
        public int BranchInfractionQty { get; set; }


        [Display(Name = "تعداد نظارت شعب سوپر مارکت مالی")]
     
        public int BranchReformQty { get; set; }


        [Display(Name = "تعداد نظارت شعب سوپر مارکت مالی")]
     
        public int BranchMonQty { get; set; }

        [Display(Name = "تعداد شکایات بررسی شده شعب سوپر مارکت مالی")]
       
        public int BranchCompCheckedQty { get; set; }

        [Display(Name = "تعداد شعب دارای امتیاز نظر سنجی قابل قبول")]
       
        public int AccBranchQty { get; set; }

        [Display(Name = "تعداد شکایات ثبت شده شعب سوپر مارکت مالی")]
       
        public int BranchCompQty { get; set; }

        [Display(Name = "تعداد پرسنل مستقر در شعب سوپر مارکت مالی")]
      
        public int BranchpersonnelQty { get; set; }

        [Display(Name = "تعداد درخواست خسارت بیمه تکمیلی پرسنل")]
    
        public int PersonnelAssuranceReqQty { get; set; }

        [Display(Name = "تعداد درخواست های اداری پرسنل شعب به منابع انسانی")]
       
        public int PersonnelAdReqQty { get; set; }
    }
    [ModelMetadataType(typeof(BranchesMonthlyReportMetaData))]
    public partial class BranchesMonthlyReport
    {

    }
}
