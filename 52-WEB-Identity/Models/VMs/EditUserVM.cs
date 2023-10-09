using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace _52_WEB_Identity.Models.VMs
{
    public class EditUserVM
    {
        public string Id { get; set; }
        [Display(Name = "Kullanıcı adı")]
        [Required]
        public string UserName { get; set; }

        [Display(Name = "Kullanıcı adı")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Kullanıcı soyadı")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Email adresi")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Display(Name = "Telefon")]
        [Required]
        [Phone]
        public string Phone { get; set; }
    }
}
