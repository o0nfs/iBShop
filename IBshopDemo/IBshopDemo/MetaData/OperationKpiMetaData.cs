using IBshopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class OperationKpiMetaData
    {
        public int Id { get; set; }

        public string? OperationKpicode { get; set; }


        [Display(Name = "بهبود رویه در سامانه های ibshop")]
        public string? Piapp { get; set; }


        [Display(Name = "قطعی نرم افرازهای سامانه آی بی شاپ")]
        public string? ErrApp { get; set; }


        [Display(Name = "توسعه سامانه ibshop")]
        public string? AppDev { get; set; }


        [Display(Name = "سرعت پاسخگویی به درخواست­ کارشناسان شعب و CRM")]
        public string? Answeringspeed { get; set; }


        [Display(Name = "مدت زمان احراز آی بی کارت ")]
        public string? IbCardAutAvgTime { get; set; }


        [Display(Name = "مدت زمان احراز هویت غیر حضوری سجام ")]
        public string? SejAutAvgTime { get; set; }


        [Display(Name = "مدت زمان پرداخت وجه به مشتری  (درخواست های دستی عملیات)")]
        public string? PayToCusAvgTime { get; set; }


        [Display(Name = "مدت زمان توثیق دارایی مشتری")]
        public string? CusAutAsset { get; set; }


        [Display(Name = "مدت زمان رفع توثیق دارایی مشتری")]
        public string? Cus { get; set; }


        [Display(Name = "نرخ عملیات موفق")]
        public string? SucOprRate { get; set; }
    }
    [ModelMetadataType(typeof(OperationKpiMetaData))]
    public partial class OperationKpi
    {

    }
}
