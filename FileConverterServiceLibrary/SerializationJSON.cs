using System.IO;
using System.Text.Json;

namespace FileConverterServiceLibrary
{
    public class SerializationJSON
    {
        public void SerializeObject(string fileName, Shop shop)
        {
            string jsonString = JsonSerializer.Serialize(shop);
            File.WriteAllText(fileName, jsonString);
        }
    }
}
