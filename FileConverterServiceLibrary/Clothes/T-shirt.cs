using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace FileConverterServiceLibrary.Clothes
{
    [Serializable]
    [XmlRoot(ElementName = "T_shirt")]
    public class T_shirt : Clothes
    {

    }
}
