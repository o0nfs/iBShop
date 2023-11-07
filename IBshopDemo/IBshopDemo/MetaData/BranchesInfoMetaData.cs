using IBshopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class BranchesInfoMetaData
    {
        [Display(Name = "کد شعبه")]
    
        public int BranchCode { get; set; }

        [Display(Name = "آدرس شعبه")]
    
        public string BranchLocation { get; set; } = null!;

        [Display(Name = "سرپرست شعبه")]
      
        public string? BranchManager { get; set; }
    }
    [ModelMetadataType(typeof(BranchesInfoMetaData))]
    public partial class BranchesInfo
    {

    }

}
