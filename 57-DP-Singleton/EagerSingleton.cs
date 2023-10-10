using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_DP_Singleton
{
    public class EagerSingleton
    {
        public static EagerSingleton instance;
        private static readonly object lock_obj = new object();

        //Kafasına göre oluşumu engelledi private yapılarak
        private EagerSingleton()
        {

        }
        public static EagerSingleton GetInstance()
        {
            lock (lock_obj)
            {
                if (instance==null)
                {
                    instance = new EagerSingleton();
                }
                return instance;
            }
        }
    }
}
