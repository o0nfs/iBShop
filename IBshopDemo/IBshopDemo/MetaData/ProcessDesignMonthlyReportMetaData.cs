using IBshopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class ProcessDesignMonthlyReportMetaData
    {
        public int ProcessDesignMrid { get; set; }


        [Display(Name = "سال")]
        public int? Year { get; set; }


        [Display(Name = "ماه")]
        public string Month { get; set; } = null!;


        [Display(Name = "شماره ماه")]
        public int MonthNumber { get; set; }


        [Display(Name = "تعداد روش های اجرائی تدوین و یا بازنگری شده")]
        public int PrcdQty { get; set; }


        [Display(Name = "تعداد روش های اجرائی ابلاغ شده")]
        public int RelPrcdQty { get; set; }


        [Display(Name = "تعداد دستورالعمل  تدوین و یا بازنگری شده")]
        public int InsQty { get; set; }


        [Display(Name = "تعداد دستورالعمل ابلاغ شده")]
        public int RelInsQty { get; set; }


        [Display(Name = "تعداد آئین نامه تدوین و یا بازنگری شده")]
        public int RegQty { get; set; }


        [Display(Name = "تعداد آئین نامه ابلاغ شده")]
        public int RelReqQty { get; set; }


        [Display(Name = "تعداد فرم های تدوین و یا بازنگری شده")]
        public int FormQty { get; set; }


        [Display(Name = "تعداد فرآیندهای ایجاد شده (طراحی)")]
        public int PrcDesign { get; set; }


        [Display(Name = "تعداد فرآیندهای بازنگری شده")]
        public int ReviewPrc { get; set; }


        [Display(Name = "تعداد تجریه و تحلیل فرآیندها")]
        public int AsmPrc { get; set; }


        [Display(Name = "تعداد تفویض اختیار انجام شده")]
        public int DlgQty { get; set; }


        [Display(Name = "تعداد شاخص های تدوین شده")]
        public int IndexQty { get; set; }


        [Display(Name = "تعداد شاخص های بازنگری شده")]
        public int ReviwIndxQty { get; set; }


        [Display(Name = "تعدادپایش شاخص های فرآیندی")]
        public int KpimonitoringQty { get; set; }


        [Display(Name = "تعداد کمیته بازاریابی برگزار شده")]
        public int MrkcommHold { get; set; }


        [Display(Name = "تعداد مصوبات کمیته بازاریابی انجام شده")]
        public int MrkDoneCmm { get; set; }


        [Display(Name = "تعداد مصوبات کمیته بازاریابی معوقه")]
        public int MrkFailCmm { get; set; }


        [Display(Name = "تعداد کمیته توسعه برگزار شده")]
        public int DevCommHold { get; set; }


        [Display(Name = "تعداد مصوبات کمیته توسعه انجام شده")]
        public int DevDoneCmm { get; set; }


        [Display(Name = "تعداد مصوبات کمیته توسعه معوقه")]
        public int DevFailCmm { get; set; }


        [Display(Name = "تعداد کمیته امور شعب برگزار شده")]
        public int CrmcommHold { get; set; }


        [Display(Name = "تعداد مصوبات کمیته امور شعب انجام شده")]
        public int CrmdoneCmm { get; set; }


        [Display(Name = "تعداد مصوبات کمیته امور شعب معوقه")]
        public int CrmfailCmm { get; set; }
    }
    [ModelMetadataType(typeof(ProcessDesignMonthlyReportMetaData))]
    public partial class ProcessDesignMonthlyReport
    {

    }
}
