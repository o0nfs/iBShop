using IBshopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class ProductMetaData
    {
        public int ProductsId { get; set; }

        public int BrancheCode { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int? IncomeCenterId { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int? MonthNumber { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public string? MonthName { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal IbcrowdVol { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int IbcardIssueQty { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int CardQty { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public int KargozariBoursCode { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal DealValue { get; set; }


        [Display(Name = "")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        [MaxLength(4, ErrorMessage = "حداکثر طول مجاز 4 کارکتر است")]
        public decimal Income { get; set; }



    }
    [ModelMetadataType(typeof(ProductMetaData))]
    public partial class Product
    {

    }
}
