using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using XMLBinarySerializationDeserialization.Models;

namespace XMLBinarySerializationDeserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Human human = new Human();
            //human.Name = "Enver";
            //human.Surname = "Zohrabov";
            //human.Age = 65;

            //SerializeHumanToXML(human);

            //SerializeHumanToBinary(human);

            Human human = DeSerializeXMLToHuman();

            Console.WriteLine(human);
        }

        // Binary Serialize
        public static void SerializeHumanToBinary(Human human)
        {
            string path = "C:\\Users\\asus\\Desktop\\Human.dat";
            Stream stream = new FileStream(path,FileMode.Create);

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, human);
        }

        // XML Serialize
        public static void SerializeHumanToXML(Human human)
        {
            string path = "C:\\Users\\asus\\Desktop\\Human.xml";
            Stream stream = new FileStream(path, FileMode.Create);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Human));
            xmlSerializer.Serialize(stream, human);
        }

        // Binary Deserialize
        public static Human DeSerializeBinaryToHuman()
        {
            string path = "C:\\Users\\asus\\Desktop\\Human.dat";
            Stream stream = new FileStream(path, FileMode.Open);

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            var human =  (Human)binaryFormatter.Deserialize(stream);

            return human;
        }

        // XML Deserialize
        public static Human DeSerializeXMLToHuman()
        {
            string path = "C:\\Users\\asus\\Desktop\\Human.xml";
            Stream stream = new FileStream(path, FileMode.Open);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Human));
            Human? human = xmlSerializer.Deserialize(stream) as Human;

            return human;
        }
    }
}