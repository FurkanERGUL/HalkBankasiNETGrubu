using _23_OOP_LABBankLib.Abstract;
using _23_OOP_LABBankLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_LABBankLib.Concrete
{
    public class CustomerStandart : BaseCustomer
    {
        public CustomerStandart(string customerId, string customerName) : base(customerId, customerName)
        {
        }

        public override void GetNumber()
        {
            Numerator numerator = new Numerator();

            Number = numerator.CreateNumber(CustomerType.StandartCustomer, this);
        }
    }
}
