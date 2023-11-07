using IBshopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class QaMonthlyReportMetaData
    {
        public int Qamrid { get; set; }


        [Display(Name = "سال")]
        public int Year { get; set; }


        [Display(Name = "ماه")]
        public string Month { get; set; } = null!;


        [Display(Name = "شماره ماه")]
        public int MonthNumber { get; set; }


        [Display(Name = "تعداد کل تماس های ورودی پرسنل")]
        public int TotalPersonnelIncCallQty { get; set; }


        [Display(Name = "تعداد تماس های بررسی شده")]
        public int TotalChcIncCallQty { get; set; }


        [Display(Name = "تعداد پرسنل عدم رعایت خوش آمد گویی")]
        public int WelFailPerIncQty { get; set; }


        [Display(Name = "تعداد رخداد رعایت نشده خوش آمد گویی")]
        public int WelFailIncQty { get; set; }


        [Display(Name = "تعداد پرسنل عدم رعایت نظرسنجی")]
        public int SurFailPerIncQty { get; set; }


        [Display(Name = "تعداد رخداد رعایت نشده نظرسنجی")]
        public int SurFailIncQty { get; set; }


        [Display(Name = "تعداد پرسنل عدم رعایت ارائه دانش کافی")]
        public int KnwFailPerIncQty { get; set; }


        [Display(Name = "تعداد رخداد رعایت نشده ارائه دانش کافی")]
        public int KnwFailIncQty { get; set; }


        [Display(Name = "تعداد پرسنل عدم رعایت ادب حرفه ای")]
        public int ProFailPerIncQty { get; set; }


        [Display(Name = "تعداد رخداد رعایت نشده ادب حرفه ای")]
        public int ProFailIncQty { get; set; }


        [Display(Name = "تعداد پرسنل دارای عدم تطابق تیکت ثبت شده با شنود")]
        public int TicFailPerIncQty { get; set; }


        [Display(Name = "تعداد رخداد دارای عدم تطابق تیکت ثبت شده با شنود")]
        public int TicFailIncQty { get; set; }


        [Display(Name = "تعداد پرسنل عدم رعایت مدیریت تماس")]
        public int CalMgtPerIncQty { get; set; }


        [Display(Name = "تعداد رخداد عدم رعایت مدیریت تماس")]
        public int CalMgtIncQty { get; set; }


        [Display(Name = "تعداد پرسنل عدم رعایت استفاده از سیستم")]
        public int SysFailPerIncQty { get; set; }


        [Display(Name = "تعداد رخداد عدم رعایت استفاده از سیستم")]
        public int SysFailIncQty { get; set; }


        [Display(Name = "تعداد کل تماس های خروجی پرسنل")]
        public int TotalPersonnelOutCallQty { get; set; }


        [Display(Name = "تعداد تماس های خروجی بررسی شده")]
        public int TotalChcOutCallQty { get; set; }


        [Display(Name = "تعداد پرسنل عدم رعایت نظرسنجی")]
        public int SurFailPerOutQty { get; set; }


        [Display(Name = "تعداد رخداد رعایت نشده نظرسنجی")]
        public int SurFailOutQty { get; set; }


        [Display(Name = "تعداد پرسنل عدم رعایت ادب حرفه ای")]
        public int ProFailPerOutQty { get; set; }


        [Display(Name = "تعداد رخداد رعایت نشده ادب حرفه ای")]
        public int ProFailOutQty { get; set; }


        [Display(Name = "تعداد پرسنل دارای عدم تطابق تیکت ثبت شده با شنود")]
        public int TicFailPerOutQty { get; set; }


        [Display(Name = "تعداد رخداد دارای عدم تطابق تیکت ثبت شده با شنود")]
        public int TicFailOutQty { get; set; }


        [Display(Name = "تعداد پرسنل عدم رعایت مدیریت تماس")]
        public int CalMgtPerOutQty { get; set; }


        [Display(Name = "تعداد رخداد عدم رعایت مدیریت تماس")]
        public int CalMgtOutQty { get; set; }


        [Display(Name = "تعداد کل چت های آنلاین")]
        public int ToalOnlineChat { get; set; }


        [Display(Name = "تعداد چت های بررسی شده ")]
        public int TotalCheckedOnlineChat { get; set; }


        [Display(Name = "تعداد پرسنل عدم رعایت نظرسنجی")]
        public int SurFailPerChatQty { get; set; }


        [Display(Name = "تعداد رخداد رعایت نشده نظرسنجی")]
        public int SurFailChatQty { get; set; }


        [Display(Name = "تعداد پرسنل عدم رعایت ادب حرفه ای")]
        public int ProFailPerChatQty { get; set; }


        [Display(Name = "تعداد رخداد رعایت نشده ادب حرفه ای")]
        public int ProFailChatQty { get; set; }


        [Display(Name = "تعداد پرسنل دارای عدم تطابق تیکت ثبت شده با شنود")]
        public int TicFailPerChatQty { get; set; }


        [Display(Name = "تعداد رخداد دارای عدم تطابق تیکت ثبت شده با شنود")]
        public int TicFailChatQty { get; set; }


        [Display(Name = "تعداد پرسنل دارای عدم تطابق زمان بستن چت مطابق رویه")]
        public int TimFailPerChatQty { get; set; }


        [Display(Name = "تعداد رخداد دارای عدم تطابق زمان بستن چت مطابق رویه")]
        public int TimFailChatQty { get; set; }


        [Display(Name = "تعداد نظرسنجی انجام شده")]
        public int? SurveyChatOnline { get; set; }


        [Display(Name = "تعداد پرسنل دارای گرید H")]
        public int HgradeQty { get; set; }


        [Display(Name = "تعداد پرسنل دارای گرید G")]
        public int GgradeQty { get; set; }


        [Display(Name = "تعداد پرسنل دارای گرید F")]
       
        public int FgradeQty { get; set; }


        [Display(Name = "تعداد پرسنل دارای گرید E")]
        public int EgradeQty { get; set; }


        [Display(Name = "تعداد پرسنل دارای گرید D")]
        public int DgradeQty { get; set; }


        [Display(Name = "تعداد پرسنل دارای گرید C")]
        public int CgradeQty { get; set; }


        [Display(Name = "تعداد پرسنل دارای گرید B")]
        public int BgradeQty { get; set; }


        [Display(Name = "تعداد پرسنل دارای گرید A")]
        public int AgradeQty { get; set; }


        [Display(Name = "تعداد پرسنل دارای گرید A پلاس")]
        public int ApgradeQty { get; set; }


        [Display(Name = "تعداد رخداد ناشی از تکرار")]
        public int? RepFail { get; set; }
    }
    [ModelMetadataType(typeof(QaMonthlyReportMetaData))]
    public partial class QaMonthlyReport
    {

    }
}
