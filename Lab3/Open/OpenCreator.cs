using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab3.Open
{
    class OpenCreator
    {
        public static IOpen Create(string fileName)
        {
            if (Path.GetExtension(fileName) == ".txt")
                return new OpenTxt();
            else if (Path.GetExtension(fileName) == ".xml")
                return new DeserializeXml();
            else if (Path.GetExtension(fileName) == ".dat")
                return new DeserializeBin();
            else
                return new DeserializeJson();
        }
    }
}
