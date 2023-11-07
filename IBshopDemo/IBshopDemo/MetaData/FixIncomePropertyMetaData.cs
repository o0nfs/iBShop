using IBshopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class FixIncomePropertyMetaData
    {
        public int FixIncomeId { get; set; }

        [Display(Name = "سال")]
       
        public int BrancheCode { get; set; }


        [Display(Name = "سال")]
     
        public int? InComeCenterId { get; set; }

        [Display(Name = "سال")]
      
        public string? MonthNumber { get; set; }

        [Display(Name = "سال")]
       
        public string? MonthName { get; set; }

        [Display(Name = "سال")]
       
        public int? CustomerQty { get; set; }

        [Display(Name = "سال")]
       
        public decimal GanjinehIssue { get; set; }

        [Display(Name = "سال")]
      
        public decimal GanjinehRev { get; set; }

        [Display(Name = "سال")]
       
        public decimal AndookhtehIssue { get; set; }

        [Display(Name = "سال")]
       
        public decimal AndookhtehRev { get; set; }

        [Display(Name = "سال")]
    
        public int VirIssueBillQty { get; set; }
        [Display(Name = "سال")]
       

        public decimal VirIssueBillVol { get; set; }
        [Display(Name = "سال")]
      
        public decimal TotalIssue { get; set; }

        [Display(Name = "سال")]
      
        public decimal TotalRev { get; set; }

    }
    [ModelMetadataType(typeof(FixIncomePropertyMetaData))]
    public partial class FixIncomeProperty
    {

    }
}
