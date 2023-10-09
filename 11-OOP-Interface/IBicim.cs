using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP_Interface
{
    public interface IBicim
    {
        //Interfaces yalnızca kalıtım vermek amacıyla kullanılırlar.
        //Yalnızca gövdesi olmayan metotlar ve propertiesler içerebilirler.
        //Static üyelere sahip olamazlar.

        //Abstract ile Interface arasındaki miras alınırken birden interface miras alınabilmesi.
        //Bir class birden fazla interface'den kalıtım alabilir.
        //Tüm propertieler ve metotlar public'tir. Bu nedenle erişim beliryicisini yazmanıza gerek yoktur.
        //İsimlendirme I karakteri ile başlar.

        int Numaram { get; set; }

        void InterfaceMetot();
    }
}
