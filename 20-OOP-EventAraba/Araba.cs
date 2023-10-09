using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_OOP_EventAraba
{
    //1.Aşama
    public delegate void HizAsimiEventHandler();
    public class Araba
    {
        //2. Aşama
        public event HizAsimiEventHandler HizAsimi;

        private string _model;
        private int _hiz;
        public string Model 
        {
            get { return _model; }
            set { _model = value; }
        }
        public int Hız 
        {
            get { return _hiz; }
            set
            {
                _hiz = value;
                if (value>120)
                {
                    //4. Aşama Event Tetikle
                    HizAsimi();
                }
            }
        }
    }
}
