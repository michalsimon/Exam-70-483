namespace Serialization
{
    using System.IO;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Xml.Serialization;

    internal class Program
    {
        private static void Main(string[] args)
        {
            BinarySerializationSample();

            BinarySeserializationSample();

            XmlSerializationSample();

            BinaryDeserializationSample();

            // JSONSerializationSample();

            // JSONDeserializationSample();
        }

        // private static void JSONDeserializationSample()
        // {
        // Stream stream3 = new FileStream("Person.json", FileMode.Open);
        // DataContractJsonSerializer ser2 = new DataContractJsonSerializer(typeof(Person));
        // person = (Person)ser2.ReadObject(stream3);
        // stream.Close();
        // }

        // private static void JSONSerializationSample()
        // {
        // Person person5 = new Person();
        // person5.SetId(1);
        // person5.FirstName = "Joe";
        // person5.LastName = "Smith";

        // Stream stream2 = new FileStream("Person.json", FileMode.Create);
        // DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person));
        // ser.WriteObject(stream2, person);
        // stream2.Close();
        // }
        private static void BinaryDeserializationSample()
        {
            XmlSerializer xmlSerializer2 = new XmlSerializer(typeof(Person));
            FileStream fs = new FileStream("Person.xml", FileMode.Open);
            Person person4 = (Person)xmlSerializer2.Deserialize(fs);
        }

        private static void XmlSerializationSample()
        {
            Person person3 = new Person();
            person3.SetId(1);
            person3.FirstName = "Joe";
            person3.LastName = "Smith";

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            StreamWriter streamWriter = new StreamWriter("Person.xml");
            xmlSerializer.Serialize(streamWriter, person3);
        }

        private static void BinarySeserializationSample()
        {
            FileStream stream = new FileStream("Person.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            IFormatter formatter = new BinaryFormatter();
            Person person2 = (Person)formatter.Deserialize(stream);
            stream.Close();
        }

        private static void BinarySerializationSample()
        {
            Person person = new Person();
            person.SetId(1);
            person.FirstName = "Joe";
            person.LastName = "Smith";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Person.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, person);
            stream.Close();
        }
    }
}