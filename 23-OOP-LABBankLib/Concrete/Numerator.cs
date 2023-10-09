using _23_OOP_LABBankLib.Abstract;
using _23_OOP_LABBankLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_LABBankLib.Concrete
{
    public class Numerator
    {
        private static int _vipNumber=100;
        private static int _standartNumber = 300;
        private static int _deskNumber = 600;
        public int VipNumber { get { return _vipNumber; } 
            set 
            {
                if (value<300)
                {
                    _vipNumber = value;
                }
                else
                {
                    _vipNumber = 0;
                }
            } 
        }
        public int StandartNumber 
        {
            get { return _standartNumber; }
            set
            {
                if (value < 600)
                {
                    _standartNumber= value;
                }
                else
                {
                    _standartNumber = 300;
                }
            }
        }
        public int DeskNumber 
        {
            get { return _deskNumber; }
            set 
            {
                if (value<900)
                {
                    _deskNumber = value; ;
                }
                else
                {
                    _deskNumber = 600;
                }
            }
        }
        public int CreateNumber(CustomerType customerType, BaseCustomer customer)
        {
            switch (customerType)
            {
                case CustomerType.VipCustomer:
                    CustomerWaiting.waitingCustomersVIP.Add((CustomerVIP)customer);
                    return ++VipNumber;
                case CustomerType.StandartCustomer:
                    CustomerWaiting.waitingCustomersStandart.Add((CustomerStandart)customer);
                    return ++StandartNumber;
                case CustomerType.DeskCustomer:
                    CustomerWaiting.waitingCustomersDesk.Add((CustomerDesk)customer);
                    return ++DeskNumber;
                default:
                    throw new Exception("Müşteri Tipi Uygun Değil");
            }
        }
    }
}
