using _23_OOP_LABBankLib.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_LABBankLib.Concrete
{
    public delegate int GetNumberEventHandler();
    public class Bank : IBank
    {
        public string BankName { get; set; }
        public string BankAdress { get; set; }
        public List<IDesk> Desks { get; set; }

        public void StartWork()
        {
            Console.WriteLine("Banka Çalışmaya Başladı");

            CreateDesk(3);

            foreach (var desk in Desks)
            {
                Console.WriteLine($"Gişe No: {desk.Name} Sır No: {desk.ProcessNumber}");
            }

            CustomerWaiting.waitingCustomersVIP = new List<CustomerVIP>();
            CustomerWaiting.waitingCustomersDesk = new List<CustomerDesk>();
            CustomerWaiting.waitingCustomersStandart =  new List<CustomerStandart>();
        }

        private void CreateDesk(int deskCount)
        {
            if (deskCount<=3)
            {
                Desks = new List<IDesk>();
                for (int i = 0; i < deskCount; i++)
                {
                    Desk desk = new Desk() { Name = "BA-" + i, Status = false, ProcessNumber = 0 };
                    Desks.Add(desk);
                    desk.OnNumbered += Control.SendNumberToDesk;
                }
            }
            else
            {
                throw new Exception("En Fazla 3 Gişe Olabilir.");
            }
        }
    }
}
