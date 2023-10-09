using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_OOP_Sealed
{
    public class BaseBook
    {
        public DateTime CreateDate { get; set; }
        public DateTime ModifedDate { get; set; }

        public virtual void GetLog()
        {
            //do something for get log
        }
        public virtual void GetUser() 
        { 
            //
        }
    }
}
