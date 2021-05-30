using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab3.Save
{
    class SaveCreator
    {
        public static ISave Create(string fileName)
        {
            if (Path.GetExtension(fileName) == ".txt")
                return new SaveTxt();
            else if (Path.GetExtension(fileName) == ".xml")
                return new SerializeXml();
            else if (Path.GetExtension(fileName) == ".dat")
                return new SerializeBin();
            else
                return new SerializeJson();
        }
    }
}
