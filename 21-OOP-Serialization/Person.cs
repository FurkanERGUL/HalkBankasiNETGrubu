using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _21_OOP_Serialization
{
    [Serializable]
    public class Person
    {
        public string Id { get; set; } = Guid.NewGuid().ToString().Substring(1, 4);
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }

        //[XmlIgnore]
        //public string Hakkinda { get; set; }
    }
}
