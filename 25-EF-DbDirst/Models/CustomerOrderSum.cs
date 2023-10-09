using System;
using System.Collections.Generic;

namespace _25_EF_DbDirst.Models
{
    public partial class CustomerOrderSum
    {
        public string CustomerId { get; set; } = null!;
        public string? ContactName { get; set; }
        public int? OrderCount { get; set; }
    }
}
