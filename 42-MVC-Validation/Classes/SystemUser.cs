using _42_MVC_Validation.ValidationClasses;
using System.ComponentModel.DataAnnotations;

namespace _42_MVC_Validation.Classes
{
    public class SystemUser
    {
        [Required(ErrorMessage ="Kullanıcı adı boş geçilemez.")]
        [StringLength(10,ErrorMessage ="Kullanıcı adı en az 3 en fazla 10 karakter olmalı",MinimumLength =2)]
        public string UserName { get; set; }
        [Required(ErrorMessage ="T.C. kimlik numarası boş geçilemez")]
        [IdentificationNumberValidation(ErrorMessage ="İnsan gibi gir")]
        public long IdentificationNumber { get; set; }

        [Required(ErrorMessage ="Boş olamaz")]
        [Range(0,100, ErrorMessage ="Puan 0-100 arasında olmaz zorundandır")]
        public int Score { get; set; }

        [EmailAddress(ErrorMessage ="Mail adresi girmek zor olamaz")]
        public string EmailAdress { get; set; }

        [Required(ErrorMessage ="Şifre boş geçilir mi cahil?")]
        public string PassWord { get; set; }

        [Required(ErrorMessage = "Şifre tekrarı boş geçilir mi cahil?")]
        [Compare("PassWord", ErrorMessage ="Aynısını yazacaksın ne kadar zor olabilir")]
        public string PassWordConfirm { get; set; }
    }
}
