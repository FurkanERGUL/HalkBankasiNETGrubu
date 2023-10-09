using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_SOLIDPrensipleri._04_InterfaceSegretation.BadImplementation
{
    public class Bus : IVehicle
    {
        public void Acceleration()
        {
            //............................
        }

        public void Break()
        {
            //............................
        }


        //Nasıl uçsun bu adam
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
