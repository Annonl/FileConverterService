using FileConverterServiceLibrary;
using System;
using System.IO;
using System.Linq;

namespace FileConvertService
{
    class Program
    {
        public static void Main(string[] args)
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
                    var shop = SerializationXML.DeserializeObject(firstFile);
                    shop = ChangeStructureShop.ChangeForJson(shop);
                    SerializationJSON.SerializeObject(secondFile,shop);
                }
                else if (firstFile.Split('.').Last() == "json")
                {
                    var shop = SerializationJSON.DeserializeObject(firstFile);
                    shop = ChangeStructureShop.ChangeForXml(shop);
                    SerializationXML.SerializeObject(secondFile, shop);
                }
                else
                {
                    Console.WriteLine("You must enter files with xml or json extension. Please, try again.");
                }
            }
            else
            {
                Console.WriteLine("The entered files were not found. Try to enter absolute file paths.");
            }
        }
    }
}
