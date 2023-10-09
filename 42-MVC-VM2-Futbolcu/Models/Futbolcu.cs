using System.ComponentModel.DataAnnotations;

namespace _42_MVC_VM2_Futbolcu.Models
{
    public class Futbolcu
    {
        [Required(ErrorMessage = "Boş geçilemez")]
        public int FutbolcuID { get; set; }
        [Required(ErrorMessage ="Boş geçilemez")]
        [StringLength(10, ErrorMessage ="lütfen 10dan az 0dan büyük yazın")]
        public string FutbolcuAd { get; set; }
        public int FutbolcuYas { get; set; }
        public int MevkiID { get; set; }
        public int TakimID { get; set; }
    }
}
