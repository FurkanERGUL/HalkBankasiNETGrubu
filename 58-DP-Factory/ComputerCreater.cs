using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58_DP_Factory
{
    public abstract class ComputerCreater
    {
        public abstract string getRam();
        public abstract string getHDD();
        public abstract string getCPU();

        public override string ToString()
        {
            return "RAM:"+getRam()+ " HDD:"+getHDD()+" CPU:"+getCPU();
        }
    }
}
