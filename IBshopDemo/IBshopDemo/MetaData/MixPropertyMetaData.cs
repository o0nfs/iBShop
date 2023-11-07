using IBshopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class MixPropertyMetaData
    {
        public int MixIncomeId { get; set; }

        public int BrancheCode { get; set; }


        [Display(Name = "")]
        public int? IncomeCenterId { get; set; }


        [Display(Name = "")]
        public int? MonthNumber { get; set; }


        [Display(Name = "")]
        public string? MonthName { get; set; }


        [Display(Name = "")]
        public decimal ServatIssue { get; set; }


        [Display(Name = "")]
        public decimal ServatRev { get; set; }


        [Display(Name = "")]
        public decimal GoharIssue { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal GoharRev { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal TotalIssue { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal TotalRev { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public virtual BranchesInfo BrancheCodeNavigation { get; set; } = null!;


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public virtual IncomeCenter? IncomeCenter { get; set; }
    }
    [ModelMetadataType(typeof(MixPropertyMetaData))]
    public partial class MixProperty
    {

    }
}
