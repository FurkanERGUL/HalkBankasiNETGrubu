namespace _21_OOP_Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\halkbank\Desktop\";

            Person person= new Person();
            person.Name = "Bilge";
            person.SurName = "Kadın";
            person.Age = 30;

            //Binary Serialize
            BinarySerialize.SerializeToBinary(person, path+"Person.dat");
            Console.WriteLine("Binary Serialize Gerçekleşti");

            Person person1= new Person();
            BinarySerialize.DeserializeToBinary(out person1, path + "Person.dat");
            Console.WriteLine($"ID: {person1.Id} Name: {person1.Name} Surname: {person1.SurName} Age: {person1.Age}");

            //XML Serialize
            XMLSerialize.SerializeToXML(person, path + "Person.xml");
            Console.WriteLine("XML Serialize Gerçekleşti");

            Person person2 = new Person();
            XMLSerialize.DeserializeFromXml(out person2, path + "Person.xml");
            Console.WriteLine($"ID: {person2.Id} Name: {person2.Name} Surname: {person2.SurName} Age: {person2.Age}");

            //JSON Serialize
            JSONSerialize.SerializeToJSON(person, path + "Person.json");
            Console.WriteLine("JSON Serialize Gerçekleşti");

            Person person3 = new Person();
            JSONSerialize.DeserializeToJSON(out person3, path + "Person.json");
            Console.WriteLine($"ID: {person3.Id} Name: {person3.Name} Surname: {person3.SurName} Age: {person3.Age}");
        }
    }
}