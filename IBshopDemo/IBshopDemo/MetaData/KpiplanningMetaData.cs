using IBshopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class KpiplanningMetaData
    {

        public int Id { get; set; }

        public string? KpiplanCode { get; set; }

        [Display(Name = "تعداد دفعات تأخیر به دلیل اشتباه بودن یا در دسترس نبودن دستورالعمل‌های فرآیند")]
        public string? DelonPrConf { get; set; }


        [Display(Name = "درصد اقدامات اصلاحی اثربخش")]
        public string? EffImpAct { get; set; }


        [Display(Name = "درصد انجام به موقع درخواست های تغییر/ تهیه مدارک")]
        public string? OtimpPercentage { get; set; }


        [Display(Name = "درصد تغییرات مشخصات فرآیند در طول بازنگری طراحی فرآیند")]
        public string? PrImPercent { get; set; }


        [Display(Name = "درصد صرفه جویی ناشی از ابتکارات مدیریت دانش")]
        public string? KmsavePercent { get; set; }


        [Display(Name = "درصد تبدیل بایگانی کاغذی الکترونیکی")]
        public string? ArchivePer { get; set; }


        [Display(Name = "اضافه کردن امکان نظرسنجی برای اندازه‌گیری NPS")]
        public string? Nps { get; set; }
    }
    [ModelMetadataType(typeof(KpiplanningMetaData))]
    public partial class Kpiplanning
    {

    }
}
