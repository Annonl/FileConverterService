using System;
using System.Xml.Serialization;

namespace FileConverterServiceLibrary.Clothes
{
    [Serializable]
    public class Size
    {
        [XmlAttribute]
        public string SizeName { get; set; }
    }
}