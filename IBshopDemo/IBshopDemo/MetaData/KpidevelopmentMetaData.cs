using IBshopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class KpidevelopmentMetaData
    {
        public string KpidevelomentCode { get; set; } = null!;


        public int BranchCode { get; set; }

        [Display(Name = "میزان تحقیقات کاربردی در بهبود محصول")]
        public string? RdinPrdImp { get; set; }

        [Display(Name = "تعداد نیازهای شناسایی شده مشتری ")]
        public string? IdeCusNeed { get; set; }

        [Display(Name = "رضایت مشتری از محصولات/خدمات جدید نسبت به محصولات/خدمات قدیمی")]
        public string? NewTooldsat { get; set; }

        [Display(Name = "درصد بهبود در نظرسنجی ها محصولات")]
        public string? PerImpPrdSur { get; set; }

        [Display(Name = "درصد آگاهی از محصول")]
        public string? PrdAwaPer { get; set; }

        [Display(Name = "درصد مشتریان جدید اضافه شده از محصولات یا خدمات ")]
        public string? NewCusinSrvPrd { get; set; }

        [Display(Name = "سرانه ثبت پیشنهاد ")]
        public string? SugCap { get; set; }

        [Display(Name = "آورده حاصل از نظام پیشنهادها (برآورد)")]
        public string? SugInc { get; set; }

        [Display(Name = "متوسط زمان بررسی پیشنهادها ")]
        public string? InvSugAvgTime { get; set; }

        [Display(Name = "میانگین زمان لازم برای ارائه حل یک مشکل  ")]
        public string? SolutionAvgTime { get; set; }

        [Display(Name = "نرخ مشارکت")]
        public string? ColRate { get; set; }

        [Display(Name = "میزان پیشنهاد‌های پذیرفته شده")]
        public string? AccsugRate { get; set; }
    }
    [ModelMetadataType(typeof(KpidevelopmentMetaData))]
    public partial class Kpidevelopment
    {

    }
}
