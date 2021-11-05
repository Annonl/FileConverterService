using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace FileConverterServiceLibrary.Clothes
{
    [Serializable]
    [XmlRoot(ElementName = "Pant")]
    public  class Pant : Clothes
    {
    }
}
