using IBshopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class KpihrMetaData
    {
        public int Id { get; set; }

        public int Kpihrcode { get; set; }


        [Display(Name = "اثربخشی جذب نیروی انسانی")]
        public string? RecEff { get; set; }

        [Display(Name = "ارزیابی اثربخشی آموزش")]
        public string? EduEfc { get; set; }


        [Display(Name = "بازخورد به دست آمده از نظرسنجی رضایت کارکنان")]
        public string? SurveyFeedback { get; set; }


        [Display(Name = "درصد جابجایی پرسنل بین واحدها")]
        public string? TrnColeagPer { get; set; }


        [Display(Name = "درصد خطا در سوابق پرسنلی")]
        public string? MistakeinPersonalInfo { get; set; }


        [Display(Name = "درصد کاهش خطاهای حقوق و دستمزد")]
        public string? SalMistakePerc { get; set; }



        [Display(Name = "درصد وفاداری کارکنان ")]
        public string? ColLoyPer { get; set; }


        [Display(Name = "سرانه آموزش")]
        public string? EduCap { get; set; }



        [Display(Name = "سرانه آموزش تخصصی")]
        public string? ProEduCap { get; set; }



        [Display(Name = "سرانه آموزش مدیریتی")]
        public string? MgmEduCap { get; set; }



        [Display(Name = "سرانه آموزش عمومی")]
        public string? GenEduCap { get; set; }

        [Display(Name = "سرانه مصرف کاغذ")]
        public string? PapConCap { get; set; }


        [Display(Name = "کمپین ارتباطات داخلی کارکنان")]
        public string? IntColCam { get; set; }


        [Display(Name = "میانگین زمان جذب نیروی انسانی از مدیریت درخواست جذب نیرو تا بکار گماری")]
        public string? ReqToNeed { get; set; }

        [Display(Name = "میزان رضایت پرسنل از سرویسهای ICT")]

        public string? IctsrvSat { get; set; }


        [Display(Name = "میزان رضایت کارکنان")]
        public string? ColSat { get; set; }


        [Display(Name = "نرخ خروج کارکنان بین 1 تا 2 سال ")]
        public string? OutcallCostAvg { get; set; }


        [Display(Name = "نرخ ریزش کارکنان")]
        public string? RecDelRat { get; set; }


        [Display(Name = "نسبت تاخیر در جذب نیروی انسانی")]
        public string? HrRecDelRat { get; set; }


        [Display(Name = "نسبت دستمزد استاندارد به حداقل دستمزد پرداختی")]
        public string? Sal { get; set; }
    }


    [ModelMetadataType(typeof(KpihrMetaData))]
    public partial class Kpihr
    {

    }
}
