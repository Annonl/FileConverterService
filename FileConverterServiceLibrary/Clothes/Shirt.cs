using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace FileConverterServiceLibrary.Clothes
{
    [Serializable]
    [XmlRoot(ElementName = "Shirt")]
    public class Shirt : Clothes 
    {

    }
}
