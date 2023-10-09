using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _21_OOP_Serialization
{
    public class BinarySerialize
    {
        public static void SerializeToBinary(Person person, string path) 
        {
            using (Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, person);

                stream.Close();
            }
        }

        public static void DeserializeToBinary(out Person person, string path)
        {
            using (Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                person = (Person)binaryFormatter.Deserialize(stream);

                stream.Close(); 
            }
        }
    }
}
