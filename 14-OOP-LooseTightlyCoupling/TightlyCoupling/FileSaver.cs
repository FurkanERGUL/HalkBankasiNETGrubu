using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOP_LooseTightlyCoupling.TightlyCoupling
{
    public class FileSaver
    {
        private readonly string _filename;
        private string _contents;

        public FileSaver(string filename, string contents)
        {
            _filename = filename;
            _contents = contents;
        }

        public void SaveData()
        { 
            File.WriteAllText(_filename, _contents);
        }
    }
}
