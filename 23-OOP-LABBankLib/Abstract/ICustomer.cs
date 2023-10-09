using _23_OOP_LABBankLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_LABBankLib.Abstract
{
    public interface ICustomer
    {
        string CustomerId { get; set; }
        string CustomerName { get; set; }
        CustomerType CustomerType { get; set; }
        int Number { get; set; }
        void GetNumber();
    }
}
