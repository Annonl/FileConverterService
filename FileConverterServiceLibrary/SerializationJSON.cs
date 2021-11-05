using System.IO;
using Newtonsoft.Json;

namespace FileConverterServiceLibrary
{
    public class SerializationJSON
    {
        public static void SerializeObject(string fileName, Shop shop)
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented
            };
            var jsonString = JsonConvert.SerializeObject(shop, settings);
            File.WriteAllText(fileName, jsonString);
        }

        public static Shop DeserializeObject(string fileName)
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented
            };
            var jsonString = File.ReadAllText(fileName);
            var shop = JsonConvert.DeserializeObject<Shop>(jsonString, settings);
            return shop;
        }
    }
}
