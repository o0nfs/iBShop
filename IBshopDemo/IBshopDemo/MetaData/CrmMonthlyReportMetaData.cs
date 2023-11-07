using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace IBshopDemo.Models
{
    public class CrmMonthlyReportMetaData
    {
        public int Crmmrid { get; set; }

        [Display(Name = "سال")]
      
        public int Year { get; set; }

        [Display(Name = "ماه")]
      
        public string Month { get; set; } = null!;

        [Display(Name = "شماره‌ی ماه")]
     
        public int MonthNumber { get; set; }

        [Display(Name = "تعداد چت ورودی")]
        
        public int InChatQty { get; set; }

        [Display(Name = "تعداد تماس شکایت")]
     
        public int InCompCallQty { get; set; }

        [Display(Name = "تعداد پیغام گیر صوتی  ")]
    
        public int InVmQty { get; set; }

        [Display(Name = "تعداد تماس ورودی")]
       
        public int InCallQty { get; set; }

        [Display(Name = "تعداد شماره حساب اصلاحی")]
      
        public int OutAccNumEditQty { get; set; }
        [Display(Name = "تعداد تماس نظر سنجی")]
       

        public int OutsurveyQty { get; set; }

        [Display(Name = "تعدا بازخورد رسیدگی به شکایات")]
       
        public int OutComTrtQty { get; set; }

        [Display(Name = "تعداد پیغام گیر صوتی خروجی")]
       
        public int OutVmQty { get; set; }

        [Display(Name = "تعداد تماس سجام")]
      
        public int SejamQty { get; set; }

        [Display(Name = "میانگین مدت زمان مکالمه میانگین مدت زمان مکالمه ")]
        
        public double AvgCallDuration { get; set; }

        [Display(Name = "میانگین مدت زمان انتظار ")]
        
        public double AvgCallWaitingDuration { get; set; }

        [Display(Name = "مجموع کل زمان مکالمه")]
      
        public double ToalCallDuration { get; set; }

        [Display(Name = "تعداد صدور گنجینه")]
     
        public int GanjinehIssuesQty { get; set; }

        [Display(Name = "مبلغ صدور گنجینه(میلیاردريال)")]
       
        public double GanjinehIssuesVol { get; set; }

        [Display(Name = "تعداد صدور اندوخته")]
      
        public int AndookhtehIssuesQty { get; set; }

        [Display(Name = "مبلغ صدور اندوخته(میلیاردريال)")]
       
        public double AndookhtehIssuesVol { get; set; }

        [Display(Name = "مجموع تعداد صدور گوهر و ثروت")]
        
        public int GoharandServatIssuesQty { get; set; }

        [Display(Name = " مجموع مبلغ صدور گوهر و ثروت(میلیاردريال)")]
      
        public double GoharandServatIssuesVol { get; set; }

        [Display(Name = "مجموع کل تعداد صدور(میلیاردريال)")]
        
        public int TotalIssuesQty { get; set; }

        [Display(Name = "مجموع کل مبلغ صدور  (میلیاردريال)")]
     
        public double TotalIssuesVol { get; set; }

        [Display(Name = "تعداد دوره آموزشی مخصوص پرسنل CRM")]
        
        public int CrmcoursesQty { get; set; }

        [Display(Name = "تعداد تیکت ثبت شده چت انلاین")]
       
        public int TicketOnlineQty { get; set; }

        [Display(Name = "تعداد تیکت ثبت شده تماس ورودی")]
       
        public int Inticket { get; set; }

        [Display(Name = "تعداد تیکت ثبت شده شکایات")]
      
        public int ComplaintTicketQty { get; set; }

        [Display(Name = "تعداد تیکت ثبت شده نظر سنجی")]
       
        public int SurveyTicketQty { get; set; }

        [Display(Name = "تعداد نظر سنجی ثبت شده تماس ورودی")]
       
        public int InSurveyCallQty { get; set; }

        [Display(Name = "تعداد نظر سنجی ثبت شده تماس خروجی")]
     
        public int OutSurveyCallQty { get; set; }

        [Display(Name = "تعداد نظر سنجی چت انلاین")]
      
        public int OnlineChatsurveyQty { get; set; }

        [Display(Name = "تعداد تیکت مرتبط به صندوق گنجینه زرین شهر")]
       
        public int GanjinehTicketQty { get; set; }

        [Display(Name = "تعداد تیکت مرتبط به صندوق اندوخته توسعه صادرات")]
      
        public int AndookhtehicketQty { get; set; }

        [Display(Name = "تعداد تیکت مرتبط به صندوق ثروت افرینان")]
    
        public int ServatafarinanTicketQty { get; set; }

        [Display(Name = "تعداد تیکت مرتبط به صندوق گوهر ")]
      
        public int GoharTicketQty { get; set; }

        [Display(Name = "تعداد تیکت مرتبط به iBcard")]
      
        public int IbCardTicketQty { get; set; }

        [Display(Name = "تعداد تیکت مرتبط به iBcrowd")]
     
        public int IbCrowdTicketQty { get; set; }

        [Display(Name = "تعداد تیکت شکایات شعب سوپر مارکت مالی")]
        
        public int BranchComplTicketQty { get; set; }
    }
    [ModelMetadataType(typeof(CrmMonthlyReportMetaData))]
    public partial class CrmMonthlyReport
    {

    }
}
