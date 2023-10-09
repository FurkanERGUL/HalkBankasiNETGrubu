using _23_OOP_LABBankLib.Abstract;
using _23_OOP_LABBankLib.Concrete;
using _23_OOP_LABBankLib.Enums;

namespace _24_OOP_LABBankUyg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Banka Çalıştır
            Bank bank = new Bank();
            bank.BankName = "Bilge Adam";
            bank.StartWork();

            //Musteri Oluştur.
            /*CustomerDesk customer1 = new CustomerDesk("111", "Fatih1");
            customer1.GetNumber();

            CustomerDesk customer2 = new CustomerDesk("112", "Fatih2");
            customer2.GetNumber();

            CustomerStandart customer3 = new CustomerStandart("113", "Fatih3");
            customer3.GetNumber();

            CustomerDesk customer4 = new CustomerDesk("114", "Fatih4");
            customer4.GetNumber();

            CustomerDesk customer5 = new CustomerDesk("115", "Fatih5");
            customer5.GetNumber();

            CustomerVIP customer6 = new CustomerVIP("116", "Fatih6");
            customer6.GetNumber();*/

            Console.WriteLine("Gelen Kişiler: ");
            Numerator numerator = new Numerator();
            Console.WriteLine($"VIP: {numerator.VipNumber} Desk: {numerator.DeskNumber} Standar: {numerator.StandartNumber}");

            bank.Desks[0].DoAction();
            bank.Desks[1].DoAction();
            bank.Desks[2].DoAction();
            bank.Desks[2].DoAction();
            bank.Desks[0].DoAction();
            bank.Desks[1].DoAction();
        }
    }
}