using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_OOP_Event
{
    //Event deklare edebilmem için delegate yapısına ihtiyacım var.
    //1-Delegate Oluştur 
    public delegate void OrderEventHandler();

    public class Order //Publisher
    {

        //2-Event'e delegate bildir.
        //Syntax Access Modifier - event - delegate name - event name
        public event OrderEventHandler OnCreated;
        public void Create()
        {

            Console.WriteLine("Order Created!");
            
            //Böyle bir yapıyı en iyi şekilde tasarlayabilmek için publisher/subscriber pattern kullanmaz daha doğrudur.

            //SendEmail.Send(); //Subscriber
            //SendSMS.Send(); //Subscriber

            //Event Tetikleme... Eğer delegate null değilse...
            if (OnCreated != null)
            {
                OnCreated();
            }

            //OnCreated?.Invoke();
        }
    }
}
