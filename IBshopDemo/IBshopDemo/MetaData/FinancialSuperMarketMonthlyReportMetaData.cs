using IBshopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class FinancialSuperMarketMonthlyReportMetaData
    {
        public int SuperMrid { get; set; }

        [Display(Name = "سال")]
     
        public int Year { get; set; }

        [Display(Name = "ماه")]
       
        public string Month { get; set; } = null!;

        [Display(Name = "شماره ماه")]
       
        public int MonthNumber { get; set; }

        [Display(Name = "تعداد پاسخگویی به مشتریان")]
     
        public int CustomersReplyQty { get; set; }


        [Display(Name = "تعداد ثبت نام مشتریان iBshop")]
      
        public int IbshoppRegisterQty { get; set; }


        [Display(Name = "تعداد احراز هویت انجام شده")]
     
        public int AuthenticationQty { get; set; }

        [Display(Name = "فعال سازی‌- غیرفعال کردن صدور از محل سود")]
      
        public int ActivationQty { get; set; }

        [Display(Name = "تعداد گزارشات ارائه شده به مشتری(گواهی و حسابداری)")]
      
        public int ReportForCustomerC { get; set; }

        [Display(Name = "تعداد درخواست صدور ثبت شده گنجینه")]
      
        public int ReportForCustomerF { get; set; }

        [Display(Name = "تعداد درخواست صدور ثبت شده گنجینه")]
       
        public int GanjinehIssueReqQty { get; set; }

        [Display(Name = "مبلغ صدور گنجینه(میلیاردريال)")]
      
        public int GanjinehIssuesVol { get; set; }

        [Display(Name = "تعداد درخواست صدور ثبت شده اندوخته")]
       
        public int AndookhtehIssueReqQty { get; set; }

        [Display(Name = "مبلغ صدور اندوخته(میلیاردريال)")]
      
        public int AndookhtehIssuesVol { get; set; }

        [Display(Name = "مجموع تعداد درخواست صدور ثبت شده گوهر و ثروت")]
      
        public int GoharandServatIssueReqQty { get; set; }

        [Display(Name = "مجموع مبلغ صدور گوهر و ثروت (میلیاردريال)")]
       
        public int GohrandServatIssuesVol { get; set; }

        [Display(Name = "تعداد درخواست ابطال ثبت شده گنجینه")]
      
        public int GanjinehRevokeReqQty { get; set; }

        [Display(Name = "مبلغ  ابطال گنجینه(میلیاردريال)")]
      
        public int GanjinehRevokeVol { get; set; }

        [Display(Name = "تعداد درخواست  ابطال ثبت شده اندوخته")]
       
        public int AndookhtehRevokeReqQty { get; set; }

        [Display(Name = "مبلغ  ابطال اندوخته(میلیاردريال)")]
       
        public int AndookhtehRevokeVol { get; set; }

        [Display(Name = "مجموع تعداد درخواست  ابطال ثبت شده گوهر و ثروت")]
     
        public int GoharandServatRevokeReqQty { get; set; }

        [Display(Name = "مجموع مبلغ  ابطال گوهر و ثروت (میلیاردريال)")]
      
        public int GohrandServatRevokeVol { get; set; }

        [Display(Name = "مجموع مبلغ صدور(میلیاردريال)")]
       
        public int TotIsuuVol { get; set; }

        [Display(Name = "مجموع مبلغ ابطال(میلیاردريال)")]
      
        public int TotRevVol { get; set; }

        [Display(Name = "اصلاح شماره حساب، شماره موبایل، مشخصات")]
    
        public int EditQty { get; set; }

        [Display(Name = "تعداد")]
    
        public int LegalServQty { get; set; }

        [Display(Name = "تعداد کارت صادرشده")]
       
        public int CardIssuanceQty { get; set; }

        [Display(Name = " مبلغ (میلیاردريال) آی بی کارت")]
     
        public int TotalIbcardVol { get; set; }

        [Display(Name = "تعداد سرمایه گذار جذب شده")]
      
        public int InvestorsQty { get; set; }

        [Display(Name = " مبلغ جذب شده(میلیاردريال) آی بیکراد")]
      
        public int TotalIbcrowdVol { get; set; }

        [Display(Name = "تعداد بیمه صادر شده")]
      
        public int InsuranceIssued { get; set; }
        [Display(Name = "تعداد اعتبار")]
      
        public int CreaditQty { get; set; }


        [Display(Name = "مبلغ اعتبار(میلیاردريال) کارگزاری")]
    
        public int CreaditVol { get; set; }

        [Display(Name = "تعداد کد آنلاین کارگزاری")]
      
        public int OnlineCodeQty { get; set; }
    }

    [ModelMetadataType(typeof(FinancialSuperMarketMonthlyReportMetaData))]
    public partial class FinancialSuperMarketMonthlyReport
    {

    }
}
