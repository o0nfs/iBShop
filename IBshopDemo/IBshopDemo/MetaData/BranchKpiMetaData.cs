using IBshopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Model

{
    public class BranchKpiMetaData
    {
        [Display(Name = "کد")]
      
        public string KpibranchCode { get; set; } = null!;

        [Display(Name = "درخواست پشتیبانی اشتباه")]
       
        public string? WrsupReq { get; set; }

        [Display(Name = "صدور حذفی ")]
      
        public string? WrongIssue { get; set; }

        [Display(Name = "مغایرت شعب ")]
        
        public string? BrcCnf { get; set; }

        [Display(Name = "تعداد خطا در مستندات کارشناس شعب")]
       
        public string? WrongQty { get; set; }

        [Display(Name = "تعداد درخواست های ثبت شده (اقلام و ملزومات مورد نیاز شعب)")]
       
        public string? BrnReqQty { get; set; }

        [Display(Name = "تنخواه شعب")]
      
        public string? BranchCap { get; set; }

        [Display(Name = "زمان خرید اقلام (اقلام و ملزومات مورد نیاز شعب)")]
      
        public string? PurchaseAvgTime { get; set; }

        [Display(Name = "نیاز سنجی و ارزیابی دانش پرسنل")]
      
        public string? Kllevel { get; set; }

        [Display(Name = "درصد عدم انطباق های برطرف شده نظارت داخلی")]
       
        public string? ConIntMonPercentage { get; set; }

        [Display(Name = "کنترل شاخص ورود مشتری به صدور")]
       
        public string? ClienttoIssue { get; set; }

        [Display(Name = "افزایش تعداد مراجعه کنندگان شعب")]
      
        public string? BrcClient { get; set; }

        [Display(Name = "بازاریابی مدیر شعبه برای آوردن  مشتری حقوقی")]
    
        public string? MrkSpv { get; set; }

        [Display(Name = "افزایش کاربر جدید (ثبت نام)")]
      
        public string? NewUser { get; set; }
    }
    [ModelMetadataType(typeof(BranchKpiMetaData))]
    public partial class BranchKpi
    {

    }
}
