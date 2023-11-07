using IBshopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class KpimarketMetaData
    {

        public int Id { get; set; }

        public string KpimarketingCode { get; set; } = null!;
        [Display(Name = "افزایش کاربر جدید")]
        public string? NewUser { get; set; }

        [Display(Name = "تبدیل کاربر ثبت نامی به صدور")]
        public string? RegistertoIssue { get; set; }


        [Display(Name = "کنترل شاخص آورده هر کاربر جدید ")]
        public string? NewCusAsset { get; set; }


        [Display(Name = "بازاریابی حقوقی  ")]
        public string? LegMrk { get; set; }


        [Display(Name = "بازاریابی شعب جهت حفظ و صدور مشتری ")]
        public string? BrcMrkRti { get; set; }


        [Display(Name = "طراحی پلن فروش  ")]
        public string? SalePlanDsg { get; set; }


        [Display(Name = "طراحی استراتژی بازاریابی")]
        public string? MrkStgDsg { get; set; }
    }

    [ModelMetadataType(typeof(KpimarketMetaData))]
    public partial class Kpimarket
    {

    }
}
