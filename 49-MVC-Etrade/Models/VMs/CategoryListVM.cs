using _49_MVC_Etrade.Models.Entities.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _49_MVC_Etrade.Models.VMs
{
    public class CategoryListVM
    {
        [DisplayName("Kategori Adı")]
        public string Name { get; set; }

        [DisplayName("Ekleme tarihi")]
        public DateTime? CreateDate { get; set; }
        [DisplayName("Güncelleme tarihi")]
        public DateTime? UpdateDate { get; set; }
        [DisplayName("Silme Tarihi")]
        public DateTime? DeleteDate { get; set; }
        [DisplayName("Durumu")]
        public Status Status { get; set; }
    }
}
