using System;
using System.Collections.Generic;

namespace _25_EF_DbDirst.Models
{
    public partial class KimdenKime
    {
        public int OrderId { get; set; }
        public string FirstName { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
        public float? Price { get; set; }
        public short Quantity { get; set; }
    }
}
