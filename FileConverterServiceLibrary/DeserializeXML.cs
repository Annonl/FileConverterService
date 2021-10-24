using System.IO;
using System.Xml.Serialization;

namespace FileConverterServiceLibrary
{
    public class DeserializeXml
    {
        public Shop DeserializeObject(string filename)
        {
            Shop shop = null;
            var serializer = new XmlSerializer(typeof(Shop));
            using Stream reader = new FileStream(filename, FileMode.Open);
            if (serializer.Deserialize(reader) is Shop s)
                shop = s;
            return shop;
        }
    }
}
