using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileConverterServiceLibrary
{
    class DeserializeXML
    {
        public Shop DeserializeObject(string filename)
        {
            Shop shop = null;
            XmlSerializer serializer = new XmlSerializer(typeof(Shop));
            using (Stream reader = new FileStream(filename, FileMode.Open) )
            {
                if (serializer.Deserialize(reader) is Shop s)
                    shop = s;
            }
            return shop;
        }
    }
}
