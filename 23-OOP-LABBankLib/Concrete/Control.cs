using _23_OOP_LABBankLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_LABBankLib.Concrete
{
    public static class Control
    {
        static int say = 0;
        static int processNum = 0;
        public static int SendNumberToDesk()
        {
            if (CustomerWaiting.waitingCustomersVIP.Count > 0)
            {
                Console.WriteLine("Sırada ki Numara: " + CustomerWaiting.waitingCustomersVIP[0].Number);
                processNum = CustomerWaiting.waitingCustomersVIP[0].Number;
                CustomerWaiting.waitingCustomersVIP.RemoveAt(0);
                DailyProcess.SetNumber(CustomerType.VipCustomer);
                return processNum;
            }
            else if ((CustomerWaiting.waitingCustomersDesk.Count>0 && say<3) || (CustomerWaiting.waitingCustomersDesk.Count > 0 && CustomerWaiting.waitingCustomersStandart.Count ==0))
            {
                Console.WriteLine("Sırada ki Numara: " + CustomerWaiting.waitingCustomersDesk[0].Number);
                processNum = CustomerWaiting.waitingCustomersDesk[0].Number;
                CustomerWaiting.waitingCustomersDesk.RemoveAt(0);
                DailyProcess.SetNumber(CustomerType.DeskCustomer);
                say++;
                return processNum;
            }
            else if(CustomerWaiting.waitingCustomersStandart.Count>0)
            {
                Console.WriteLine("Sırada ki Numara: " + CustomerWaiting.waitingCustomersStandart[0].Number);
                processNum = CustomerWaiting.waitingCustomersStandart[0].Number;
                CustomerWaiting.waitingCustomersStandart.RemoveAt(0);
                DailyProcess.SetNumber(CustomerType.StandartCustomer);
                say = 0;
                return processNum;
            }
            else
            {
                throw new Exception("Bekleyen Müşteri Kalmadı");
            }
        }
    }
}
