using System;
using System.Xml.Serialization;

namespace FileConverterServiceLibrary.Clothes
{
    [Serializable]
    [XmlRoot(ElementName = "Sweatshirt")]
    public class Sweatshirt : Clothes
    {
    }
}
