using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class ArtMonthlyReportMetaData
    {
        [Display(Name ="")]
        [Required]
        public int ArtMonthlyReportId { get; set; }
        [Display(Name = "سال")]
     
        public int Year { get; set; }

        [Display(Name = "ماه")]
       
        public string Month { get; set; } = null!;

        [Display(Name = "شماره‌ی ماه")]
     
        public int MonthNumber { get; set; }

        [Display(Name = "تعداد درخواست های واحد بازاریابی")]
     
        public int MrkReq { get; set; }

        [Display(Name = "بررسی تعداد طرح رقبا")]
      
        public int CompStudy { get; set; }

        [Display(Name = "تعداد آرشیو طراحی")]
     
        public int ArchiveDesignQty { get; set; }

        [Display(Name = "تعداد نواقص در هویت بصری")]
      
        public int MediaFailureQty { get; set; }


        [Display(Name = "متوسط زمان طراحی بنر سایت")]
      
        public int SiteBannerAvgTime { get; set; }

        [Display(Name = "متوسط زمان طراحی بروشور")]
       
        public int BrochureDesignAvgTime { get; set; }

        [Display(Name = "متوسط زمان طراحی استوری")]
     
        public int StoryDesignAvgTime { get; set; }

        [Display(Name = "متوسط زمان طراحی گیف")]
    
        public int GifDesignAvgTime { get; set; }

        [Display(Name = "متوسط زمان طراحی استند")]
        
        public int StandDesignAvgTime { get; set; }

        [Display(Name = "تعداد طرح بنر سایت")]
      
        public int BannerDesignQty { get; set; }

        [Display(Name = "تعداد طرح بروشور (تراکت)")]
   
     
        public int BrochureDesignQty { get; set; }

        [Display(Name = "تعداد طرح استوری")]
      
        public int StoryDesignQty { get; set; }

        [Display(Name = "تعداد طراحی گیف")]
       
        public int GifDesignQty { get; set; }

        [Display(Name = "تعداد طراحی استند")]
       
        public int StandDesigQty { get; set; }

        [Display(Name = "تعداد موشن اجرا شده")]
       
        public int MotionQty { get; set; }

        [Display(Name = "تعداد آرشیو موشن")]
     
        public int ArchivedmotionQty { get; set; }

        [Display(Name = "متوسط زمان اجرای موشن")]
        
        public int AppliedMotionAvgTime { get; set; }

        [Display(Name = "تعداد ویدیو تولید شده")]
       
        public int RecordedvideoQty { get; set; }

        [Display(Name = "تعداد ضبط")]
        
        public int RecordedQty { get; set; }

        [Display(Name = "تعداد ادیت نریشن")]
       
        public int NarrationEditQty { get; set; }

        [Display(Name = "تعداد آرشیو ویدیو")]
        
        public int VideoArchiveQty { get; set; }

        [Display(Name = "متوسط زمان تولید ویدیو")]
     
        public int VideoProduceAvgTime { get; set; }
    }
    [ModelMetadataType(typeof(ArtMonthlyReportMetaData))]
    public partial class ArtMonthlyReport
    {

    }

}