using System.ComponentModel.DataAnnotations;

namespace _39_MVC_Views.Models
{
    public class MessageSave
    {
        [Required(ErrorMessage ="Adınızı yazmak zorundasınız")]
        [Display(Name ="Adınızı Giriniz")]
        public string FirstName { get; set; }
        
        [Display(Name = "Soyadınızı Giriniz")]
        public string LastName { get; set; }
        
        [Display(Name = "Konuyu Giriniz")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Boş mesaj yazmayınız")]
        [Display(Name = "Mesajı Giriniz")]
        //[DataType(DataType.MultilineText)]
        public string Mesaj1 { get; set; }
        [Required(ErrorMessage = "Boş mesaj yazmayınız")]
        [Display(Name = "Mesajı Giriniz")]
        //[DataType(DataType.MultilineText)]
        public string Mesaj2 { get; set; }
    }
}
