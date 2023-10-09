using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _21_OOP_Serialization
{
    public class JSONSerialize
    {
        public static void SerializeToJSON(Person person, string path)
        {
            using (Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                JsonSerializer.Serialize(stream, person);

                stream.Close();
            }
        }

        public static void DeserializeToJSON(out Person person, string path) 
        {
            using (Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                person = JsonSerializer.Deserialize<Person>(stream);

                stream.Close();
            }
        }
    }
}
