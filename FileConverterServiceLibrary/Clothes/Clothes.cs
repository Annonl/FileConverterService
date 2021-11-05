using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace FileConverterServiceLibrary.Clothes
{
    [Serializable]
    [XmlInclude(typeof(Polo))]
    [XmlInclude(typeof(T_Shirt))]
    [XmlInclude(typeof(Pant))]
    [XmlInclude(typeof(Sweatshirt))]
    [XmlInclude(typeof(Short))]
    [XmlInclude(typeof(Shirt))]
    public abstract class Clothes
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute] public int ProductId { get; set; }
        public int Cost { get; set; }

        public int Density { get; set; }
        public List<Size> AvalibleSize { get; set; }
    }
}
