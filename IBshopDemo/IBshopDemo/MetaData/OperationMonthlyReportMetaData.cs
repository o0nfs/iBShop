using IBshopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class OperationMonthlyReportMetaData
    {
        public int Id { get; set; }

        public int Oprmrid { get; set; }

        [Display(Name = "سال")]
        public int Year { get; set; }


        [Display(Name = "شماره ماه")]
        public int? MonthNumber { get; set; }


        [Display(Name = "ماه")]
        public string Month { get; set; } = null!;


        [Display(Name = "تعداد درخواست های مغایرت فیش")]
        public int BillConflictReqQty { get; set; }


        [Display(Name = "تعداد درخواست های مغایرت پوز")]
        public int PoseConflictReqQty { get; set; }


        [Display(Name = "تعداد درخواست‌های مغایرت پیامکی")]
        public int SmsinternetConflictReqQty { get; set; }


        [Display(Name = "تعداد درخواستهای مغایرت اینترنت شعبه")]
        public int BranchInternetConflictReqQty { get; set; }


        [Display(Name = "تعداد درخواست های مغایرت درگاه اینترنتی")]
        public int IntternetEntranceConflictReq { get; set; }


        [Display(Name = "مغایرت رفع شده")]
        public int FixedConflictQty { get; set; }


        [Display(Name = "مجموع کل فرایند مغایرت")]
        public int TotalConflictsProcess { get; set; }


        [Display(Name = "تعداد مشتریان جدید کارگزاری")]
        public int BkgNewCustomer { get; set; }


        [Display(Name = "تعداد تایید درخواست وجه کارگزاری")]
        public int BkgReqCnfqty { get; set; }


        [Display(Name = "مبلغ اعتبار تخصیص داده شده(میلیاردريال) کارگزاری")]
        public int BkgCrdVol { get; set; }


        [Display(Name = "تعداد اعتبار کارگزاری")]
        public int BkgCrdQty { get; set; }

        [Display(Name = "کل مبلغ(میلیاردريال) صدور آی بی کارت ها")]
        public int TotalIbcardIssuesVol { get; set; }


        [Display(Name = "تعداد آی بی کارت")]
        public int TotalIbcardIssuesQty { get; set; }


        [Display(Name = "مجموع کل تایید و انتقال مشتری و انتقال درخواستها صندوق")]
        public int TotalTransferVol { get; set; }


        [Display(Name = "کل پیام های تلگرام،واتساپ،شعب و CRM")]
        public int TotalmsgQty { get; set; }


        [Display(Name = "مجموع کل بررسی احراز غیرحضوری")]
        public int RemotChcAut { get; set; }


        [Display(Name = "مجموع کل اصلاحات حساب")]
        public int TotalEditAcc { get; set; }



        [Display(Name = "مجموع کل اصلاحات مشخصات")]
        public int TotalIdeEdit { get; set; }


        [Display(Name = "مجموع کل احراز حقوقی")]
        public int TotalLegAut { get; set; }


        [Display(Name = "مجموع کل سجام بررسی شده")]
        public int TotalChcSejam { get; set; }


        [Display(Name = "مجموع کل گواهی صادر شده و ارسال شده")]
        public int TotalIssuCrt { get; set; }


        [Display(Name = "صدور تامین سرمایه تمدن")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        public decimal? AbCganjinehTamaddon { get; set; }


        [Display(Name = "ابطال تامین سرمایه تمدن")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCganjinehTamaddonRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCganjinehShahr { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCganjinehShahrRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCganjinehSandogh { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCganjinehSandoghRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCganjinehSamaneh { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCganjinehSamanehRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCganjinehBranches { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCganjinehBranchesRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCganjinehShahrnet { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCganjinehShahrnetRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCganjinehTotal { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCganjinehTotalRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCandookhtehTamaddon { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCandookhtehTamaddonRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCandookhtehShahr { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCandookhtehShahrRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCandookhtehOtherBanks { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCandookhtehOtherBanksRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCandookhtehSandogh { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCandookhtehSandoghRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCandookhtehSamaneh { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCandookhtehSamanehRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCandookhtehBranch { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCandookhtehBranchRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCandookhtehShahrnet { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCandookhtehShahrnetRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCandookhtehTotal { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCandookhtehTotalRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCservatTamaddon { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCservatTamaddonRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCservatSamaneh { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCservatSamanehRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCservatBranch { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCservatBranchRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCservatSandogh { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCservatSandoghRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCservatTotal { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCservatTotalRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCgoharTamaddon { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCgoharTamaddonRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCgoharSamaneh { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCgoharSamanehRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCgoharBranch { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCgoharBranchRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCgoharSandogh { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCgoharSandoghRe { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCgoharTotal { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal? AbCgoharTotalRe { get; set; }
    }
    [ModelMetadataType(typeof(OperationMonthlyReportMetaData))]
    public partial class OperationMonthlyReport
    {

    }
}
