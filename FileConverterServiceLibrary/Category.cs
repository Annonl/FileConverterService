using FileConverterServiceLibrary.Clothes;
using System;
using System.Xml.Serialization;

namespace FileConverterServiceLibrary
{
    [Serializable]
    [XmlRoot("Category")]
    public class Category
    {
        [XmlArrayItem(typeof(Polo))]
        [XmlArrayItem(typeof(T_Shirt))] 
        [XmlArrayItem(typeof(Pant))]
        [XmlArrayItem(typeof(Sweatshirt))]
        [XmlArrayItem(typeof(Short))]
        [XmlArrayItem(typeof(Shirt))]
        public Clothes.Clothes[] Clotheses { get; set; }
        [XmlAttribute]
        public string NameCategory { get; set; }
        [XmlAttribute]
        public int CategoryId { get; set; }

    }
}