using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_LABBankLib.Abstract
{
    public interface IBank
    {
        string BankName { get; set; }
        string BankAdress { get; set; }
        List<IDesk> Desks { get; set; }
        void StartWork();
    }
}
