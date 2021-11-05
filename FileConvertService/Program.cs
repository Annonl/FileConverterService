using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Linq;
using FileConverterServiceLibrary;

namespace FileConvertService
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstFile, secondFile;
            switch (args.Length)
            {
                case 0:
                    Console.WriteLine("Enter the name of the file where you want to take data from:");
                    firstFile = Console.ReadLine();
                    Console.WriteLine("Enter the name of the file where you want to write the data:");
                    secondFile = Console.ReadLine();
                    break;
                case 1:
                    firstFile = args[0];
                    Console.WriteLine("Enter the name of the file where you want to write the data:");
                    secondFile = Console.ReadLine();
                    break;
                default:
                    firstFile = args[0];
                    secondFile = args[1];
                    break;
            }

            if (File.Exists(firstFile))
            {
                if (firstFile.Split('.').Last() == "xml")
                {
                    DeserializeXml sDeserializeXml = new DeserializeXml();
                    var shop = sDeserializeXml.DeserializeObject(firstFile);
                    shop = ChangeStructureShop.ChangeForJson(shop);
                    SerializationJSON serializationJson = new SerializationJSON();
                    serializationJson.SerializeObject(secondFile,shop);
                }
            }
            else
            {
                Console.WriteLine("The entered files were not found. Try to enter absolute file paths.");
            }
        }
    }
}
