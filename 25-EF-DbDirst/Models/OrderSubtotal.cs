using System;
using System.Collections.Generic;

namespace _25_EF_DbDirst.Models
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
