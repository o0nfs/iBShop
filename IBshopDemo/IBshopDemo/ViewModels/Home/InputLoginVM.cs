using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.ViewModels.Home
{
    public class InputLoginVM
    {
        [Required(ErrorMessage ="کد ملی الزامی می باشد.")]
        [MinLength(10,ErrorMessage = "کدملی 10 رقم می باشد.")]
        [MaxLength(10, ErrorMessage = "کدملی 10 رقم می باشد.")]
        public string  NationalCode { get; set; }
        
        [Required(ErrorMessage = "رمز عبور الزامی است.")]
        [MinLength(8, ErrorMessage = "رمز عبور باید شامل حرف بزرگ، حرف کوچک، نماد، 8 کاراکتر.")]
        [MaxLength(12, ErrorMessage = "رمز عبور باید شامل حرف بزرگ، حرف کوچک، نماد، 8 کاراکتر.")]
        public string Password { get; set; }
    }
}
