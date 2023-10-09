using _23_OOP_LABBankLib.Abstract;
using _23_OOP_LABBankLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_LABBankLib.Concrete
{
    public class CustomerDesk : BaseCustomer
    {
        public CustomerDesk(string customerId, string customerName) : base(customerId, customerName)
        {
        }

        public override void GetNumber()
        {
            Numerator numerator = new Numerator();

            Number = numerator.CreateNumber(CustomerType.DeskCustomer, this);
        }
    }
}
