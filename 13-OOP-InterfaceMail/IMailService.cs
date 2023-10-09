using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOP_InterfaceMail
{
    public interface IMailService
    {
        string From { get; set; }
        string To { get; set; }
        string Header { get; set; }
        string Body { get; set; }

        void Send();

    }
}
