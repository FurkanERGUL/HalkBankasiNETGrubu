using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_DP_Singleton
{
    public class SampleSingleton
    {
        private static SampleSingleton sampleSingleton;
        private string data;

        public string Data 
        {
            get { return data; }
            set { data = value; }
        }

        protected SampleSingleton()
        {

        }

        public static SampleSingleton CreateSampleSingleton()
        {
            if (sampleSingleton==null)
            {
                sampleSingleton = new SampleSingleton();
            }
            return sampleSingleton;
        }
    }
}
