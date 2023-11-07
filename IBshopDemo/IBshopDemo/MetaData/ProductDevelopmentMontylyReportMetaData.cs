using IBshopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class ProductDevelopmentMontylyReportMetaData
    {
        public int DevMrid { get; set; }


        [Display(Name = "سال")]
        public int Year { get; set; }


        [Display(Name = "ماه")]
        public string Month { get; set; } = null!;


        [Display(Name = "شماره ماه")]
        public int MonthNumber { get; set; }


        [Display(Name = "تعداد پیشنهادات بررسی شده")]
        public int CheckedSuggestQty { get; set; }


        [Display(Name = "تعداد پیشنهادات پذیرفته شده")]
        public int AcceptedSuggestQty { get; set; }


        [Display(Name = "تعداد پرسنل پیشنهاد دهنده")]
        public int SuggestPersonnelQty { get; set; }


        [Display(Name = "تعداد پیشنهاد دارای صرفه اقتصادی")]
        public int EconomicalSuggestQty { get; set; }


        [Display(Name = "تعداد کل مشتریان کارت اعتباری")]
        public int IbcCreaditCardCustQty { get; set; }


        [Display(Name = "تعداد شکایات")]
        public int IbcComplQty { get; set; }


        [Display(Name = "تعداد در خواست کارت اعتباری")]
        public int IbcCreadiCardReqQty { get; set; }


        [Display(Name = "متوسط زمان  فرآیند  کارت اعتباری")]
        public int IbcCreaditCardProcessAvgTime { get; set; }


        [Display(Name = "تعداد طرح های  اجرا شده")]
        public int IbwDesignQty { get; set; }


        [Display(Name = "ارزش طرح های اجرا شده")]
        public int IbwDesignVol { get; set; }


        [Display(Name = "متوسط زمان تکمیل طرح ها")]
        public int IbwDesignTime { get; set; }
    }
    [ModelMetadataType(typeof(ProductDevelopmentMontylyReportMetaData))]
    public partial class ProductDevelopmentMontylyReport
    {

    }
}
