using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOP_LooseTightlyCoupling.TightlyCoupling
{
    public class FileReader
    {
        private readonly string _filename;
        private string _contents;

        public FileReader(string filename)
        {
            _filename = filename;
        }

        public void StartReading()
        {
            _contents = File.ReadAllText(_filename);
        }

        public void SaveData()
        { 
            var saver = new FileSaver(_filename, _contents);
            saver.SaveData();
        }
    }
}
