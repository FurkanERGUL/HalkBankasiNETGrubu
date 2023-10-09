using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_LABBankLib.Abstract
{
    public abstract class BaseCustomer
    {
        public BaseCustomer(string customerId, string customerName)
        {
            CustomerId = customerId;
            CustomerName = customerName;
        }

        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int Number { get; set; }
        public abstract void GetNumber();
    }
}
