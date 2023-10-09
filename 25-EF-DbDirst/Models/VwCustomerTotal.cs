using System;
using System.Collections.Generic;

namespace _25_EF_DbDirst.Models
{
    public partial class VwCustomerTotal
    {
        public string CompanyName { get; set; } = null!;
        public double? Tutar { get; set; }
    }
}
