using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_OOP_Generic
{
    public class AnahtarDegerIkilisi<TKey, TValue>
    {
        public TKey Id { get; set; }
        public TValue Name { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}
