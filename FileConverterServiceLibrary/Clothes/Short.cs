using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace FileConverterServiceLibrary.Clothes
{
    [Serializable]
    [XmlRoot(ElementName = "Short")]
    public class Short : Clothes
    {
    }
}
