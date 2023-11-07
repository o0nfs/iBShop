using IBshopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class MarketingMonthlyReportMetaData
    {
        public int Mrkmrid { get; set; }

        [Display(Name = "سال")]
        public int Year { get; set; }


        [Display(Name = "ماه")]
        public string Month { get; set; } = null!;


        [Display(Name = "شماره ماه")]
        public int MonthNumber { get; set; }


        [Display(Name = "تعداد پیامک تبلیغاتی ارسال‌شده")]
        public int SentSmsQty { get; set; }

        [Display(Name = "تعداد رپورتاژ آگهی")]
        public int ReportAdvQty { get; set; }


        [Display(Name = "تعداد پوش نوتیفیکیشن")]
        public int NotifPushQty { get; set; }


        [Display(Name = "تعداد پست شعب در شبکه‌های اجتماعی ")]
        public int PostMediaQty { get; set; }

        [Display(Name = "تعداد تبلیغات در شبکه‌های اجتماعی استانی")]
        public int StateMedAdvQty { get; set; }

        [Display(Name = "تعداد تبلیغات محیطی فضاهای اجاره‌ای و بیلبورد")]
        public int BilboardQty { get; set; }


        [Display(Name = "ورودی از طریق سرچ")]
        public int SrchEntQty { get; set; }


        [Display(Name = "ورودی از طریق رفرال")]
        public int RefEntQty { get; set; }


        [Display(Name = "ورودی از طریق شبکه‌های اجتماعی")]
        public int SmedEntQty { get; set; }

        [Display(Name = "میانگین ورودی ماهیانه وب‌سایت")]
        public int SiteEntMonthlyAvg { get; set; }

        [Display(Name = " تعداد فالورهای اینستاگرام")]
        public int InstFlwQty { get; set; }

        [Display(Name = "اینگیجمنت")]
        public int EngQty { get; set; }


        [Display(Name = "تهیه محتوای پست‌های تلگرام")]
        public int TlgPostContentQty { get; set; }


        [Display(Name = "تهیه محتوای لینکدین")]
        public int LinkdinContentQty { get; set; }


        [Display(Name = "طراحی پست-بیلبورد-استند-لایت باکس و ... ")]
        public int DesignQty { get; set; }


        [Display(Name = "تعداد ویدئوی تولید شده")]
        public int VideoQty { get; set; }


        [Display(Name = "تعداد دوره‌های برگزارشده")]
        public int HoldQty { get; set; }


        [Display(Name = "تعداد مسابقات برگزار شده")]
        public int HoldComptQty { get; set; }


        [Display(Name = "تعداد پست‌های ویدئویی ضبط‌شده")]
        public int RecVidPostQty { get; set; }


        [Display(Name = "تعداد پست‌های متنی آموزشی")]
        public int TrainPostQty { get; set; }


        [Display(Name = " تعداد فالور ایستاگرام ")]
        public int InsFlwQty { get; set; }


        [Display(Name = "تعداد مقالات و اخبار سایت")]
        public int NewsQty { get; set; }


        [Display(Name = "تعداد تفاهم نامه همکاری با سایر مراکز یا تعداد مدرسان")]
        public int TrainingCntrctQty { get; set; }


        [Display(Name = "تعداد تماس های برقرار شده با مشتریان حقوقی طرح های iBcrowd")]
        public int IbcrowdCalllegalCusQty { get; set; }


        [Display(Name = "تعداد تماس معرفی محصولات و خدمات ")]
        public int PrdSrvAdvCallQty { get; set; }


        [Display(Name = "تعداد تماس منجر به حصول نتیجه")]
        public int SucCallQty { get; set; }


        [Display(Name = "مجموع مبالغ سرمایه گذاری شده")]
        public int ToalInvestVol { get; set; }


        [Display(Name = "Conversion Rate")]
        public int ConversationRate { get; set; }


        [Display(Name = "Bounce Rate")]
        public int? BounceRate { get; set; }


        [Display(Name = "افزایش یا کاهش رتبه در کلمات کلیدی")]
        public int KeywordsRank { get; set; }


        [Display(Name = "نرخ ترافیک ورودی از گوگل")]
        public int GoogleEntTerRate { get; set; }


        [Display(Name = "نرخ ترافیک از بک لینک‌ها")]
        public int LinkEntTerRate { get; set; }
    }
    [ModelMetadataType(typeof(MarketingMonthlyReportMetaData))]
    public partial class MarketingMonthlyReport
    {

    }
}
