using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_DP_Mediator
{
    public class ChatMediatorImplement : IChatMediator
    {
        private List<User> users;

        public ChatMediatorImplement()
        {
            this.users = new List<User>();
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, User user)
        {
            foreach (var item in users)
            {
                if (item!=user)
                {
                    item.Receive(message);
                }
            }
        }
    }
}
