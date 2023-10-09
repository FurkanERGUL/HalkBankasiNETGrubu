using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_OOP_Event
{
    //C# event kullanımında yeni bir delegate türü tanımlamamıza gerek kalmaması için standart EventHandler delegate türünü sağlar.

    //1-Delegate Tanımlama
    public delegate void EventHandler(object sender, EventArgs e);
    //1) sender: eventi başlatan nesneye bir referans tutar.
    //2) EventArgs: uygulama için geçerli olan durum bilgisini tutar.
    public class OrderEH
    {
        //2-Event Tanımlama
        //public event EventHandler OnCreated;

        //2.1-Event Data Gönderme Tanımlama
        public event EventHandler<OrderEventArgs> OnCreated;
        public void Create()
        {
            Console.WriteLine("Order Created Event Handler...");
            if (OnCreated != null)
            {
                OnCreated(this, new OrderEventArgs { EmailAdress="alkanfatih@mail.com.tr", PhoneNumber="5547746909" });
            }
        }

    }
}
