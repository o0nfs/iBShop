using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class HrMonthlyReportMetaData
    {

        public int HrmonthlyreportId { get; set; }

        [Display(Name = "سال")]
    
        public int Year { get; set; }

        [Display(Name = "ماه")]
     
        public string Month { get; set; } = null!;
        [Display(Name = "شماره‌ی ماه")]
     
        public int MonthNumber { get; set; }

        [Display(Name = "تعداد پرسنل شرکت")]
      
        public int HrpersonnelQty { get; set; }

        [Display(Name = "تعداد پرسنل ترک خدمت ")]
      
        public int LeftQty { get; set; }

        [Display(Name = "تعداد پرسنل استخدام شده")]
     
        public int HrmhiredQty { get; set; }

        [Display(Name = "تعداد پرسنل معرفی شده (انبوردینگ)")]
       
        public int Obqty { get; set; }

        [Display(Name = "تعداد نیروی درخواست شده")]
      
        public int Reqqty { get; set; }

        [Display(Name = "تعداد رزومه های ارسال شده به واحدها")]
      
        public int SentCvtoDep { get; set; }

        [Display(Name = "تعداد دوره آموزشی برگزار شده")]
       
        public int CoursQty { get; set; }

        [Display(Name = "تعداد مصاحبه استخدامی انجام شده")]
     
        public int IntQty { get; set; }
        [Display(Name = "تعداد استعفاء درخواست شده")]
      
        public int RsgReq { get; set; }

        [Display(Name = "تعداد تنخواه استفاده شده")]
     
        public int UsedImp { get; set; }

        [Display(Name = "تعداد صدور کارت هدیه ")]
   
        public int Gcissu { get; set; }
        [Display(Name = "تعداد تخصیص سرویس به پرسنل جدید")]
        

        public int SrvAsgNewPer { get; set; }

        [Display(Name = "تعداد تخصیص بیمه تکمیلی به پرنسل جدید")]
     
        public int AsuAsgNewPer { get; set; }

        [Display(Name = "تعداد نامه درخواست وام")]
     
        public int GurReqFun { get; set; }

        [Display(Name = "تعداد نامه درخواست ضمانت")]
       
        public int GurReqLtt { get; set; }

        [Display(Name = "تعداد نامه درخواست کسر از حقوق")]
      
        public int PyrDedReqLtt { get; set; }

        [Display(Name = "تعداد نامه های ارسال شده به خارج سازمان")]
       
        public int SendOutLtt { get; set; }

        [Display(Name = "تعداد نامه های ارسال شده درون سازمانی")]
       
        public int SendIntLtt { get; set; }

        [Display(Name = "تعداد نامه های دریافت شده خارج از سازمان")]
       
        public int RecLtt { get; set; }

        [Display(Name = "تعداد مغایرت در لیست ورود و خروج پرسنل")]
       
        public int PerEntCnfQty { get; set; }

        [Display(Name = "تعداد عدم حضور مطابق شیفت بندی")]
       
        public int PreFailQty { get; set; }

        [Display(Name = "تعداد جایگزینی صورت گرفته")]
     
        public int ReplacemntQty { get; set; }


        [Display(Name = "تعداد عدم رعایت در نظافت سرویس های بهداشتی")]
       
        public int Rrfail { get; set; }

        [Display(Name = "تعداد عدم رعایت در تخصیص ملزومات به سرویس های بهداشتی")]
      

        public int RrfacFail { get; set; }

        [Display(Name = "تعداد عدم رعایت در نظافت حیاط و لابی شرکت")]
      
        public int LobFailQty { get; set; }

        [Display(Name = "تعداد عدم رعایت در نظافت مشاع طبقات")]
    
        public int FloFailQty { get; set; }

        [Display(Name = "تعداد عدم رعایت در نظافت میز های مستقر در واحد ها")]
       
        public int TblFailQty { get; set; }

        [Display(Name = "تعداد عدم رعایت در نظافت رااه پله")]
       
        public int StrFailQty { get; set; }

        [Display(Name = "تعداد عدم رضایت از پذیرایی اتاق مدیران ")]
       
        public int MngRfailQty { get; set; }

        [Display(Name = "تعداد عدم ارائه خدمات صبحانه به پرسنل")]
       
        public int BrkFailQty { get; set; }

        [Display(Name = "تعداد عدم رعایت نظافت آبدارخانه ")]
       
        public int PntFailQty { get; set; }
    }

    [ModelMetadataType(typeof(HrMonthlyReportMetaData))]
    public partial class HrMonthlyReport
    {

    }
}
