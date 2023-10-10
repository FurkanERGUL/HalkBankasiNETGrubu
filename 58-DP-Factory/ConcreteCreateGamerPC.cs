using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58_DP_Factory
{
    public class ConcreteCreateGamerPC : ComputerCreater
    {
        private string ram;
        private string hdd;
        private string cpu;

        public ConcreteCreateGamerPC(string ram, string hdd, string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }

        public override string getCPU()
        {
            return cpu;
        }

        public override string getHDD()
        {
            return hdd;
        }

        public override string getRam()
        {
            return ram;
        }
    }
}
