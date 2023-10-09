using _23_OOP_LABBankLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_LABBankLib.Concrete
{
    public class DailyProcess
    {
        public static int VipNumber = 0;
        public static int StandartNumber = 0;
        public static int DeskNumber = 0;

        public static void SetNumber(CustomerType customerType)
        {
            switch (customerType)
            {
                case CustomerType.VipCustomer:
                    VipNumber++;
                    break;
                case CustomerType.StandartCustomer:
                    StandartNumber++;
                    break;
                case CustomerType.DeskCustomer:
                    DeskNumber++;
                    break;
                default:
                    break;
            }
        }

    }
}
