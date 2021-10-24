using System;
using System.Xml.Serialization;

namespace FileConverterServiceLibrary.Clothes
{
    [Serializable]
    [XmlRoot(ElementName = "Shirt")]
    public class Shirt : Clothes 
    {

    }
}
