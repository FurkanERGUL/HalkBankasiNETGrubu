using _29_EF_CodeFirstModelDbContextApplication.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_EF_CodeFirstModelDbContextApplication.Entities
{
    public class ProductDetails : BaseEntity
    {
        //public int ProductDetailsID { get; set; }
        public string? Color { get; set; } //Boş geçilebilir.
        public int Width { get; set; }
        public int Height { get; set; }
        //private Status ProductDetailStatu = Status.Active;
        public int ProductRefID { get; set; }
        public virtual Product Product { get; set; }
    }
}
