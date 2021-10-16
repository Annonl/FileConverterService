using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConverterServiceLibrary.Clothes
{
    abstract class Clothes
    {
        int cost;
        List<Size> avalibleSize;
        int productID;
        int density;
        string name;
    }
}
