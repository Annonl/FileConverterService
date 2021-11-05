using System.IO;
using System.Xml.Serialization;

namespace FileConverterServiceLibrary
{
    public class SerializationXML
    {
        public static Shop DeserializeObject(string filename)
        {
            Shop shop = null;
            var serializer = new XmlSerializer(typeof(Shop));
            using Stream reader = new FileStream(filename, FileMode.Open);
            if (serializer.Deserialize(reader) is Shop s)
                shop = s;
            return shop;
        }

        public static void SerializeObject(string fileName, Shop shop)
        {
            var formatter = new XmlSerializer(typeof(Shop));
            using var fs = new FileStream(fileName, FileMode.OpenOrCreate);
            formatter.Serialize(fs, shop);
        }
    }
}
