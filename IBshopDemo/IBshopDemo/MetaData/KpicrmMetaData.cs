using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class KpicrmMetaData
    {
        [Display(Name = "سال")]
      
        public int Kpicrmcode { get; set; }

        [Display(Name = "بازخورد منفی از مشتریان در پاسخگویی")]
    
        public string? NegFb { get; set; }



        [Display(Name = "تعداد تماس های متوقف شده")]
      
        public string? HocallQty { get; set; }



        [Display(Name = "درصد تماس هایی که در اولین ارتباط حل می‌شوند")]
     
        public string? Fcsp { get; set; }


        [Display(Name = "درصد درخواست‌های مشتری که در بازه زمانی معین پاسخ داده شده است")]
        public string? CusReqMetPer { get; set; }


        [Display(Name = "درصد بهبود رضایت مشتری در نظرسنجی شکایات")]
        public string? CusSat { get; set; }


        [Display(Name = "درصد تماس های از دست رفته")]
        public string? MissedCallPercent { get; set; }


        [Display(Name = "درصد تماس های پاسخ داده شده در سیستم توزیع خودکار تماس")]
        public string? AutAnsPercent { get; set; }


        [Display(Name = "درصد تماس های رها شده")]
        public string? LeftCallPercent { get; set; }


        [Display(Name = "درصد رضایت کاربران از خدمات و محصولات ")]
        public string? SrvPrdSatPer { get; set; }


        [Display(Name = "میانگین تاخیر در صف قبل از اتصال به یک نماینده")]
        public string? DelAvr { get; set; }


        [Display(Name = "سرعت متوسط ​​پاسخ به تماس")]
        public string? CallAnsSpd { get; set; }


        [Display(Name = "شکایات برطرف شده ظرف 3 روز")]
        public string? Wtunder3 { get; set; }


        [Display(Name = "میانگین طول مکالمه")]
        public string? CallDuration { get; set; }


        [Display(Name = "میانگین هزینه هر تماس خروجی")]
        public string? OutcallCostAvg { get; set; }



        [Display(Name = "میزان رضایت مشتریان از نحوه پاسخگویی")]
        public string? CallAnsSat { get; set; }

        [Display(Name = "نظرات کاربران برای بهبود خدمات")]
        public string? UsersComImpSer { get; set; }



        [Display(Name = "تعداد تیکت ثبت شده ")]
        public string? TicQty { get; set; }


        [Display(Name = "تعداد نیازهای شناسایی شده مشتری")]
        public string? IdeCusNeed { get; set; }


        [Display(Name = "درصد آگاهی از محصول")]
        public string? PrdAwaPer { get; set; }


        [Display(Name = "درصد بهبود در نظرسنجی ها محصولات")]
        public string? PerImpPrdSur { get; set; }




        [Display(Name = "رضایت مشتری از محصولات/خدمات جدید نسبت به محصولات/خدمات قدیمی")]
        public string? NewtooldSat { get; set; }


        [Display(Name = "افزایش شاخص CSAT")]
        public string? Csat { get; set; }


        [Display(Name = "تماس‌های خروجی جهت بازاریابی تلفنی ")]
        public string? MrkOutcall { get; set; }


        [Display(Name = "میزان صدور CRM")]
        public string? Crmiss { get; set; }
    }

    [ModelMetadataType(typeof(KpicrmMetaData))]
    public partial class Kpicrm
    {

    }

}
