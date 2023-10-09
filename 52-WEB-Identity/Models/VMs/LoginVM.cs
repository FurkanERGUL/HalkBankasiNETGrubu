using System.ComponentModel.DataAnnotations;

namespace _52_WEB_Identity.Models.VMs
{
    public class LoginVM
    {
        [Required]
        [Display(Name ="Kullanıcı adı")]
        public string UserName { get; set; }


        [Required]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
