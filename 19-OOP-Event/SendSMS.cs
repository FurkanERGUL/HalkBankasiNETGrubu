using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_OOP_Event
{
    public class SendSMS
    {
        public static void Send()
        {
            Console.WriteLine("Send a SMS...");
        }

        //For Event Handler
        public static void Send(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"Send a SMS to {e.PhoneNumber}");
        }
    }
}
