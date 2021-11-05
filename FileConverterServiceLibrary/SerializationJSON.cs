using System.IO;
using Newtonsoft.Json;

namespace FileConverterServiceLibrary
{
    public class SerializationJSON
    {
        public void SerializeObject(string fileName, Shop shop)
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented
            };
            string jsonString = JsonConvert.SerializeObject(shop, settings);
            File.WriteAllText(fileName, jsonString);
        }

        public Shop DeserializeObject(string fileName)
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented
            };
            string jsonString = File.ReadAllText(fileName);
            Shop shop = JsonConvert.DeserializeObject<Shop>(jsonString, settings);
            return shop;
        }
    }
}
