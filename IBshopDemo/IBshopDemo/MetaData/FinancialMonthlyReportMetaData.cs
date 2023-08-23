using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class FinancialMonthlyReportMetaData
    {
       
        public int FinancialMrid { get; set; }

        [Display(Name = "سال")]
        [Required(ErrorMessage = "وارد کردن سال الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int Year { get; set; }

        [Display(Name = "ماه")]
        [Required(ErrorMessage = "وارد کردن نام ماه الزامی است")]
        [MaxLength(2, ErrorMessage = "حداکثر طول مجاز 2 کارکتر است")]
        public string Month { get; set; } = null!;

        [Display(Name = "شماره ماه")]
        [Required(ErrorMessage = "وارد کردن شماره ماه الزامی است")]
        [MaxLength(2, ErrorMessage = "حداکثر طول مجاز 2 کارکتر است")]
        public int MonthNumber { get; set; }

        [Display(Name = "تعداد تسویه حساب پرسنل")]
        [Required(ErrorMessage = "وارد کردن تعداد تسویه حساب پرسنل الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int PersonnelSetQty { get; set; }

        [Display(Name = "تعداد تنخواه های بررسی شده")]
        [Required(ErrorMessage = "وارد کردن تعداد تنخواه های بررسی شده الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int CheckedfundQty { get; set; }

        [Display(Name = "تعداد قرارداد های منعقد شده")]
        [Required(ErrorMessage = "وارد کردن تعداد قرارداد های منعقد شده الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]

        public int ContQty { get; set; }

        [Display(Name = "تعداد صدور اسناد خزانه")]
        [Required(ErrorMessage = "وارد کردن تعداد صدور اسناد خزانه الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int TreasuryBillsQty { get; set; }

        [Display(Name = "تعداد ضمانت نامه بانکی دریافت شده")]
        [Required(ErrorMessage = "وارد کردن تعداد ضمانت نامه بانکی دریافت شده الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int Recivedgaurantee { get; set; }

        [Display(Name = "مانده تعداد اقساط مالیاتی")]
        [Required(ErrorMessage = "وارد کردن مانده تعداد اقساط مالیاتی الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int RestaxinstallmentQty { get; set; }


        [Display(Name = "مانده تعداد اقساط وام")]
        [Required(ErrorMessage = "وارد کردن مانده تعداد اقساط وام الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int ResFundInstallmenQty { get; set; }


        [Display(Name = "مانده تعداد اقساط تامین اجتماعی")]
        [Required(ErrorMessage = "وارد کردن مانده تعداد اقساط تامین اجتماعی الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int TaminInstallmentQty { get; set; }


        [Display(Name = "میزان جریمه بیمه تامین اجتماعی")]
        [Required(ErrorMessage = "وارد کردن میزان جریمه بیمه تامین اجتماعی الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int TaminPenaltyVol { get; set; }


        [Display(Name = "تعداد کمیسیون معاملات ")]
        [Required(ErrorMessage = "وارد کردن تعداد کمیسیون معاملات  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int TranCommissionQty { get; set; }


        [Display(Name = "مدت زمان تاخیر در پرداخت اقساط تامین اجتماعی ")]
        [Required(ErrorMessage = "وارد کردن مدت زمان تاخیر در پرداخت اقساط تامین اجتماعی  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int TaminInstallmentDelay { get; set; }


        [Display(Name = "مدت زمان تاخیر در پرداخت اقساط مالیات")]
        [Required(ErrorMessage = "وارد کردن مدت زمان تاخیر در پرداخت اقساط مالیات الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int TaxInstallmentDelay { get; set; }

        [Display(Name = "تعداد درخواست اموال")]
        [Required(ErrorMessage = "وارد کردن تعداد درخواست اموال الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int PrpReqQty { get; set; }

        [Display(Name = "تعداد درخواست تعمیر اموال")]
        [Required(ErrorMessage = "وارد کردن تعداد درخواست تعمیر اموال الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int MtnprpQty { get; set; }

        [Display(Name = "تعداد درخواست جمع آوری اموال")]
        [Required(ErrorMessage = "وارد کردن تعداد درخواست جمع آوری اموال الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int ColPrpQty { get; set; }

        [Display(Name = "تعداد برچسب گذاری اموال")]
        [Required(ErrorMessage = "وارد کردن تعداد برچسب گذاری اموال الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int LblPrpQty { get; set; }
    }
    [ModelMetadataType(typeof(FinancialMonthlyReportMetaData))]
    public partial class FinancialMonthlyReport
    {

    }
}
