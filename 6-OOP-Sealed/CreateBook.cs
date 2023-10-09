using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_OOP_Sealed
{
    public class CreateBook : Book
    {
        public CreateBook()
        {
            //GetUser(); Kullanılabilir ama ezilemez.
        }
        public override void GetLog()
        {
            base.GetLog();
        }

        //GetUser() metodu Book class'ında sealed olarak işaretlendiğinden dolayı ilgili metoda ulaşılamaz.
    }
}
