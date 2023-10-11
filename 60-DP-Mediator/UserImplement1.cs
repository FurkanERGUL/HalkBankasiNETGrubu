using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_DP_Mediator
{
    public class UserImplement1 : User
    {
        public UserImplement1(IChatMediator mediator, string name) : base(mediator, name)
        {
        }

        public override void Receive(string msg)
        {
            Console.WriteLine(this.name+": mesaj alındı "+msg);
        }

        public override void Send(string msg)
        {
            Console.WriteLine("Mesaj gönderildi "+msg);
            mediator.SendMessage(msg, this);
        }
    }
}
