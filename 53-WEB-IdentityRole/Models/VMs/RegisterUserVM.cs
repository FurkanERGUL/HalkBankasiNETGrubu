using System.ComponentModel.DataAnnotations;

namespace _53_WEB_IdentityRole.Models.VMs
{
    public class RegisterUserVM
    {
        [Required(ErrorMessage ="Bu alanın girişi zorunludur.")]
        [Display(Name ="Kullanıcı adı")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Bu alanın girişi zorunludur.")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bu alanın girişi zorunludur.")]
        [Display(Name = "Telefon numarası")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Bu alanın girişi zorunludur.")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Bu alanın girişi zorunludur.")]
        [Display(Name = "Şifre tekrar")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string PasswordConfirm { get; set; }
        
    }
}
