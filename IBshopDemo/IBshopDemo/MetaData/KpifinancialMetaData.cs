using IBshopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class KpifinancialMetaData
    {
        public int Id { get; set; }

        public string KpifinCode { get; set; } = null!;

        [Display(Name = "ارائه به موقع اظهارنامه‌ها و الزامات قانونی")]
        public string? OtdecLegRe { get; set; }

        [Display(Name = "درصد حساب‌های دارای عدم انطباق به کل حساب‌های رسیدگی شده")]
        public string? RvwAccConflicts { get; set; }

        [Display(Name = "درصد اسناد دارای عدم انطباق به کل اسناد رسیدگی شده")]
        public string? RvwInvConflicts { get; set; }

        [Display(Name = "درصد انحراف از بودجه برنامه ریزی شده")]
        public string? DevPlnBudPer { get; set; }

        [Display(Name = "درصد تحقق بودجه درآمدی (بودجه اولیه)")]
        public string? IncBudMeetPer { get; set; }

        [Display(Name = "درصد خطای ورود داده‌ها در حساب‌های پرداختنی و دفتر کل")]
        public string? DemistakeFin { get; set; }

        [Display(Name = "درصد دقت گزارش‌های مالی دوره ای")]
        public string? AcrFinRepPer { get; set; }

        [Display(Name = "رقم جرائم بانکی ناشی از تاخیر در پرداخت اقساط")]
        public string? Cnt { get; set; }

        [Display(Name = "مدت زمان انعقاد قرار داد")]
        public string? CtrTimeDuration { get; set; }

        [Display(Name = "میزان مغایرت های فیزیکی و سیستمی دارایی های ثابت")]
        public string? FixedAssetConflict { get; set; }

        [Display(Name = "متوسط زمان صدور صورتحساب و پرداخت پول")]
        public string? BillIssueAvgTime { get; set; }

        [Display(Name = "تطبیق فاکتور های خرید با اطلاعات پیمانکار ")]
        public string? CnrctrInvoicesMatch { get; set; }

        [Display(Name = "حساب‌های دریافتنی عقب افتاده به کل مطالبات")]
        public string? OdrecintotalRec { get; set; }
    }

    [ModelMetadataType(typeof(KpifinancialMetaData))]
    public partial class Kpifinancial
    {

    }
}
