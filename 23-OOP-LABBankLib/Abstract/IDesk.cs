using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_LABBankLib.Abstract
{
    public interface IDesk
    {
        string Name { get; set; }
        int ProcessNumber { get; set; }
        void DoAction();
    }
}
