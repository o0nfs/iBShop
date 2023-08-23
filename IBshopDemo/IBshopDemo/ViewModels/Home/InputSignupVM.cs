using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IBshopDemo.ViewModels.Home
{
    public class InputSignupVM
    {
        [Required(ErrorMessage = " وارد کردن شماره ملی الزامی می باشد")]
        [MinLength(10, ErrorMessage = "کدملی 10 رقم می باشد.")]
        [MaxLength(10, ErrorMessage = "کدملی 10 رقم می باشد.")]
        public string? NationalCode { get; set; }
        [Required(ErrorMessage = " وارد کردن نام خانوادگی الزامی می باشد")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = " وارد کردن نام الزامی می باشد")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = " وارد کردن شماره موبایل الزامی می باشد")]
        [MinLength(11, ErrorMessage = "شماره‌ی موبایل 11 رقم می باشد")]
        [MaxLength(11, ErrorMessage = "شماره‌ی موبایل 11 رقم می باشد")]
        public string? PhoneNumber { get; set; }


        [MinLength(8, ErrorMessage = "رمز عبور باید شامل حرف بزرگ، حرف کوچک، نماد، 8 کاراکتر.")]
        [MaxLength(12, ErrorMessage = "رمز عبور باید شامل حرف بزرگ، حرف کوچک، نماد، 8 کاراکتر.")]
        [Required(ErrorMessage = "وارد کردن رمز عبور الزامی می باشد")]
        public string? Password { get; set; }

        [MinLength(8, ErrorMessage = "رمز عبور باید شامل حرف بزرگ، حرف کوچک، نماد، 8 کاراکتر.")]
        [MaxLength(12, ErrorMessage = "رمز عبور باید شامل حرف بزرگ، حرف کوچک، نماد، 8 کاراکتر.")]
        [Required(ErrorMessage = " تکرار رمز عبور الزامی می باشد.")]
        [DataType(DataType.Password)] 
        [Compare("Password", ErrorMessage = "رمزعبور و تکرار آن تطابق ندارند.")]
        [NotMapped]
        public string rePassword { get; set; }
    }
}
