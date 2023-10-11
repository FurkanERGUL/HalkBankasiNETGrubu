using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_DP_Mediator
{
    public interface IChatMediator
    {
        void AddUser(User user);
        void SendMessage(string message, User user);
    }
}
