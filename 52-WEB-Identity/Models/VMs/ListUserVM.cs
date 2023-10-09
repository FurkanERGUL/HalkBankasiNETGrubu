using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _52_WEB_Identity.Models.VMs
{
    public class ListUserVM
    {
        public string Id { get; set; }
        [DisplayName ("Kullanıcı adı")]
        public string UserName { get; set; }
        [DisplayName ( "AD")]
        public string FirstName { get; set; }
        [DisplayName ("SOYAD")]
        public string LastName { get; set; }
        [DisplayName("EMAIL")]
        public string Email { get; set; }
    }
}
