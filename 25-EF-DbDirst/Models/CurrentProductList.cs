using System;
using System.Collections.Generic;

namespace _25_EF_DbDirst.Models
{
    public partial class CurrentProductList
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
    }
}
