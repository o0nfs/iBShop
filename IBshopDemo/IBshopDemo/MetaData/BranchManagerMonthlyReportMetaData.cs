using IBshopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


namespace IBshopDemo.Models
{
    public class BranchManagerMonthlyReportMetaData
    {

        public int BranchManagerMonthlyReportIdBranchManagerMonthlyReportId { get; set; }

        [Display(Name = "سال")]
      
        public int Year { get; set; }

        [Display(Name = "ماه")]
     
        public string Month { get; set; } = null!;

        [Display(Name = "شماره‌ی ماه")]
      
        public int MonthNumber { get; set; }

        [Display(Name = "کد شعبه")]
      
        public int BranchCode { get; set; }

        [Display(Name = "آدرس شعبه")]
       
        public string BranchLocation { get; set; } = null!;

        [Display(Name = "تعداد جلسات بازاریابی iBcard")]
       
        public int IBcardMrkmtgqty { get; set; }

        [Display(Name = "اد خروجی موفق  جلسات  iBcard")]
      
        public int IBcardSuccessMtgqty { get; set; }

        [Display(Name = "تعداد جلسات بازاریابی iBcrowd")]
      
        public int IBcrowdMrkmtgqty { get; set; }

        [Display(Name = "تعداد خروجی موفق  جلسات iBcrowd")]
      
        public int IBcrowdSuccessMtgqty { get; set; }

        [Display(Name = "تعداد جلسات بازاریابی محصولات بیمه")]
       
        public int AssuranceMrkmtgqty { get; set; }

        [Display(Name = "تعداد خروجی موفق  جلسات بیمه")]
      
        public int AssuranceSuccessMtgqty { get; set; }

        [Display(Name = "تعداد جلسات بازاریابی اوراق مشارکت بدهی")]
      
        public int DebtSharesMrkmtgqty { get; set; }

        [Display(Name = "تعداد خروجی موفق اوراق بدهی")]
       
        public int DebtSharesSuccessMtgqty { get; set; }

        [Display(Name = "تعداد جلسات بازاریابی صندوق های سرمایه گذاری")]
      
        public int InvestmentMrkmtgqty { get; set; }

        [Display(Name = "تعداد خروجی موفق بازاریابی صندوق های سرمایه گذاری")]
      
        public int InvesmentSuccessMtgqty { get; set; }

        [Display(Name = "تعداد دوره آموزشی درخواست برای پرسنل")]
      
        public int CoursesReq { get; set; }

        [Display(Name = "تعداد جلسات بازاریابی برگزاری دوره آموزشی در شرکت ها")]
       
        public int CoursesMrkmtgqty { get; set; }

        [Display(Name = "تعداد موافقت اولیه برگزاری دوره آموزشی شرکت ها")]
       
        public int CoursesMrkmtgfirstAgreementQty { get; set; }

        [Display(Name = "تعداد مشتریان شاکی مراجعه کننده")]
      
        public int ComplainantQty { get; set; }

        [Display(Name = "تعداد جلب رضایت مشتریان  شاکی")]
      
        public int Conciliation { get; set; }
    }

    [ModelMetadataType(typeof(BranchManagerMonthlyReportMetaData))]
    public partial class BranchManagerMonthlyReport
    {

    }
}
