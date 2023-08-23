using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class BranchesMonthlyReportMetaData
    {
        
        public int BranchMonthlyReportId { get; set; }

        [Display(Name ="سال")]
        [Required(ErrorMessage ="وارد کردن سال الزامی است")]
        [MaxLength(4,ErrorMessage ="حداکثر طول مجاز 4 کارکتر است")]
        public int Year { get; set; }

        [Display(Name = "ماه")]
        [Required(ErrorMessage = "وارد کردن نام ماه الزامی است")]
        [MaxLength(2, ErrorMessage = "حداکثر طول مجاز 2 کارکتر است")]
        public string Month { get; set; } = null!;

        [Display(Name = "شماره ماه")]
        [Required(ErrorMessage = "وارد کردن شماره ماه الزامی است")]
        [MaxLength(2, ErrorMessage = "حداکثر طول مجاز 2 کارکتر است")]
        public int MonthNumber { get; set; }

        [Display(Name = "تعداد شعب دارای مغایرت های iBcard ")]
        [Required(ErrorMessage = "وارد کردن تعداد شعب دارای مغایرت های iBcard  الزامی است")]
        [MaxLength(10, ErrorMessage = "حداکثر طول مجاز 10 کارکتر است")]
        public int IbcardConflictBranchQty { get; set; }

        [Display(Name = "تعداد مغایرت های iBcrowd در شعب سوپر مارکت مالی")]
        [Required(ErrorMessage = "وارد کردن تعداد مغایرت های iBcrowd در شعب سوپر مارکت مالی الزامی است")]
        [StringLength(10, ErrorMessage = "حداکثر طول مجاز 10 کارکتر است")]
        public int IbcrowdConflictBranchQty { get; set; }

        [Display(Name = "تعداد شعب دارای عدم رعایت حداقل تامین مالی در طرح iBcrowd")]
        [Required(ErrorMessage = "وارد کردن تعداد شعب دارای عدم رعایت حداقل تامین مالی در طرح iBcrowd الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int IBcrowdKpiconflictQty { get; set; }

        [Display(Name = "تعداد دوره های آموزشی برگزار شده ")]
        [Required(ErrorMessage = "وارد کردن تعداد دوره های آموزشی برگزار شده  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int CoursesQty { get; set; }

        [Display(Name = "تعداد برگزاری آزمون های آنلاین")]
        [Required(ErrorMessage = "وارد کردن تعداد برگزاری آزمون های آنلاین الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int OnlineExamsQty { get; set; }

        [Display(Name = "تعداد نیازهای آموزشی شناسایی شده  در شعب سوپرمارکت مالی")]
        [Required(ErrorMessage = "وارد کردن تعداد نیازهای آموزشی شناسایی شده  در شعب سوپرمارکت مالی الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]

        public int CoursesNeedQty { get; set; }

        [Display(Name = "تعداد خدمات ارائه شده به کارگزاری شعب سوپر مارکت مالی")]
        [Required(ErrorMessage = "وارد کردن تعداد خدمات ارائه شده به کارگزاری شعب سوپر مارکت مالی الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int ServicesToBranchQty { get; set; }

        [Display(Name = "تعداد انتقادات و پیشنهادات ارسال شده به توسعه محصول")]
        [Required(ErrorMessage = "وارد کردن تعداد انتقادات و پیشنهادات ارسال شده به توسعه محصول الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int CandstoDevelopmentQty { get; set; }

        [Display(Name = "تعداد مغایرت های گزارش ارسالی شعب سوپرمارکت مالی")]
        [Required(ErrorMessage = "وارد کردن تعداد مغایرت های گزارش ارسالی شعب سوپرمارکت مالی الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int ReportsConflictsToBranchQty { get; set; }

        [Display(Name = "تعداد مغایرت های صندوق سرمایه گذاری انجام شده (ارسالی از عملیات) ")]
        [Required(ErrorMessage = "وارد کردن تعداد مغایرت های صندوق سرمایه گذاری انجام شده (ارسالی از عملیات)  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int InvestmentCapitalConflicts { get; set; }

        [Display(Name = "تعداد درخواست های  زیر ساخت تجهیزات")]
        [Required(ErrorMessage = "وارد کردن تعداد درخواست های  زیر ساخت تجهیزات الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int FacilityReqQty { get; set; }

        [Display(Name = "تعداد اقدامات مشکلات نرم افزاری انجام شده")]
        [Required(ErrorMessage = "وارد کردن تعداد اقدامات مشکلات نرم افزاری انجام شده الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int SwsolvedQty { get; set; }

        [Display(Name = "تعداد درخواست های تسویه تنخواه")]
        [Required(ErrorMessage = "وارد کردن تعداد درخواست های تسویه تنخواه الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int FundSettlementQty { get; set; }


        [Display(Name = "تعداد مغایرت گیری تنخواه های ارسالی")]
        [Required(ErrorMessage = "وارد کردن تعداد مغایرت گیری تنخواه های ارسالی الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int FundsConflictsQty { get; set; }


        [Display(Name = "تعداد مرسولات ارسال شده به شعب سوپرمارکت مالی")]
        [Required(ErrorMessage = "وارد کردن تعداد مرسولات ارسال شده به شعب سوپرمارکت مالی الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int SendtoBranch { get; set; }


        [Display(Name = "تعداد اقلام بازایابی نیازمند ارسال به شعب سوپر مارکت مالی")]
        [Required(ErrorMessage = "وارد کردن تعداد اقلام بازایابی نیازمند ارسال به شعب سوپر مارکت مالی الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int MrkpacTobranchQty { get; set; }


        [Display(Name = "تعدادگواهی ارسال شده به مشتریان")]
        [Required(ErrorMessage = "وارد کردن تعدادگواهی ارسال شده به مشتریان الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int CrttoCusQty { get; set; }


        [Display(Name = "تعداد مشتریان مراجعه کننده به شعب سوپر مارکت مالی")]
        [Required(ErrorMessage = "وارد کردن تعداد مشتریان مراجعه کننده به شعب سوپر مارکت مالی الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int InpersonBranchQty { get; set; }


        [Display(Name = "تعداد تیکت های ثبت شده توسط شعب سوپر مارکت مالی")]
        [Required(ErrorMessage = "وارد کردن تعداد تیکت های ثبت شده توسط شعب سوپر مارکت مالی الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int BranchTickects { get; set; }


        [Display(Name = "تعداد مغایرت های تیکت های ثبت شده")]
        [Required(ErrorMessage = "وارد کردن تعداد مغایرت های تیکت های ثبت شده الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int TicketConflictsQty { get; set; }


        [Display(Name = "تعداد تخلفات صورت گرفته توسط شعب سوپرمارکت مالی")]
        [Required(ErrorMessage = "وارد کردن تعداد تخلفات صورت گرفته توسط شعب سوپرمارکت مالی الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int BranchInfractionQty { get; set; }


        [Display(Name = "تعداد نظارت شعب سوپر مارکت مالی")]
        [Required(ErrorMessage = "وارد کردن تعداد نظارت شعب سوپر مارکت مالی الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int BranchReformQty { get; set; }


        [Display(Name = "تعداد نظارت شعب سوپر مارکت مالی")]
        [Required(ErrorMessage = "وارد کردن تعداد نظارت شعب سوپر مارکت مالی الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int BranchMonQty { get; set; }

        [Display(Name = "تعداد شکایات بررسی شده شعب سوپر مارکت مالی")]
        [Required(ErrorMessage = "وارد کردن تعداد شکایات بررسی شده شعب سوپر مارکت مالی الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int BranchCompCheckedQty { get; set; }

        [Display(Name = "تعداد شعب دارای امتیاز نظر سنجی قابل قبول")]
        [Required(ErrorMessage = "وارد کردن تعداد شعب دارای امتیاز نظر سنجی قابل قبول الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int AccBranchQty { get; set; }

        [Display(Name = "تعداد شکایات ثبت شده شعب سوپر مارکت مالی")]
        [Required(ErrorMessage = "وارد کردن تعداد شکایات ثبت شده شعب سوپر مارکت مالی الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int BranchCompQty { get; set; }

        [Display(Name = "تعداد پرسنل مستقر در شعب سوپر مارکت مالی")]
        [Required(ErrorMessage = "وارد کردن تعداد پرسنل مستقر در شعب سوپر مارکت مالی الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int BranchpersonnelQty { get; set; }

        [Display(Name = "تعداد درخواست خسارت بیمه تکمیلی پرسنل")]
        [Required(ErrorMessage = "وارد کردن تعداد درخواست خسارت بیمه تکمیلی پرسنل الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int PersonnelAssuranceReqQty { get; set; }

        [Display(Name = "تعداد درخواست های اداری پرسنل شعب به منابع انسانی")]
        [Required(ErrorMessage = "وارد کردن تعداد درخواست های اداری پرسنل شعب به منابع انسانی الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int PersonnelAdReqQty { get; set; }
    }
    [ModelMetadataType(typeof(BranchesMonthlyReportMetaData))]
    public partial class BranchesMonthlyReport
    {

    }
}
