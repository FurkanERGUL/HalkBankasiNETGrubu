using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_OOP_Event
{
    public class OrderEventArgs : EventArgs
    {
        public string EmailAdress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
