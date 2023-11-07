using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class FinancialMonthlyReportMetaData
    {

        public int FinancialMrid { get; set; }

        [Display(Name = "سال")]
    
        public int Year { get; set; }

        [Display(Name = "ماه")]
      
        public string Month { get; set; } = null!;

        [Display(Name = "شماره ماه")]
     
        public int MonthNumber { get; set; }

        [Display(Name = "تعداد تسویه حساب پرسنل")]
       
        public int PersonnelSetQty { get; set; }

        [Display(Name = "تعداد تنخواه های بررسی شده")]
        
        public int CheckedfundQty { get; set; }

        [Display(Name = "تعداد قرارداد های منعقد شده")]
     

        public int ContQty { get; set; }

        [Display(Name = "تعداد صدور اسناد خزانه")]
       
        public int TreasuryBillsQty { get; set; }

        [Display(Name = "تعداد ضمانت نامه بانکی دریافت شده")]
        
        public int Recivedgaurantee { get; set; }

        [Display(Name = "مانده تعداد اقساط مالیاتی")]
    
        public int RestaxinstallmentQty { get; set; }


        [Display(Name = "مانده تعداد اقساط وام")]
      
        public int ResFundInstallmenQty { get; set; }


        [Display(Name = "مانده تعداد اقساط تامین اجتماعی")]
     
        public int TaminInstallmentQty { get; set; }


        [Display(Name = "میزان جریمه بیمه تامین اجتماعی")]
       
        public int TaminPenaltyVol { get; set; }


        [Display(Name = "تعداد کمیسیون معاملات ")]
      
        public int TranCommissionQty { get; set; }


        [Display(Name = "مدت زمان تاخیر در پرداخت اقساط تامین اجتماعی ")]
    
        public int TaminInstallmentDelay { get; set; }


        [Display(Name = "مدت زمان تاخیر در پرداخت اقساط مالیات")]
      
        public int TaxInstallmentDelay { get; set; }

        [Display(Name = "تعداد درخواست اموال")]
   
        public int PrpReqQty { get; set; }

        [Display(Name = "تعداد درخواست تعمیر اموال")]
       
        public int MtnprpQty { get; set; }

        [Display(Name = "تعداد درخواست جمع آوری اموال")]
        
        public int ColPrpQty { get; set; }

        [Display(Name = "تعداد برچسب گذاری اموال")]
       
        public int LblPrpQty { get; set; }
    }
    [ModelMetadataType(typeof(FinancialMonthlyReportMetaData))]
    public partial class FinancialMonthlyReport
    {

    }
}
