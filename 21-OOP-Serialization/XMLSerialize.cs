using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _21_OOP_Serialization
{
    public class XMLSerialize
    {
        public static void SerializeToXML(Person person, string path)
        {
            using (Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
                xmlSerializer.Serialize(stream, person);

                stream.Close();
            }
        }

        public static void DeserializeFromXml(out Person person, string path) 
        {
            using (Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
                person = (Person)xmlSerializer.Deserialize(stream);

                stream.Close();
            }
        }
    }
}
