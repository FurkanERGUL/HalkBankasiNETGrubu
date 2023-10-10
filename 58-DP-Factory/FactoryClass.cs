using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58_DP_Factory
{
    public class FactoryClass
    {
        public static ComputerCreater FactoryMethod(ModelPC model, string ram, string hdd, string cpu)
        {
            if (model==ModelPC.DeveloperPC)
            {
                return new ConcreteCreaterDeveloperPC(ram, hdd, cpu);
            }
            else if (model==ModelPC.GamerPC)
            {
                return new ConcreteCreateGamerPC(ram, hdd, cpu);
            }
            else
            {
                return null;
            }
        }
    }
}
