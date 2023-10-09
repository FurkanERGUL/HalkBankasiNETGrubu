using System;
using System.Collections.Generic;

namespace _25_EF_DbDirst.Models
{
    public partial class UrunVeDetay
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public short? UnitsInStock { get; set; }
        public int? ToplamSiparişAdedi { get; set; }
    }
}
