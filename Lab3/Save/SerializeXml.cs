using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Lab3.Save
{
    class SerializeXml : ISave
    {
        public void Save(List<Note> notes, string fileName)
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<Note>));
            try
            {
                using (FileStream file = File.Create(fileName))
                    writer.Serialize(file, notes);
            }
            catch (Exception ex) // если произошла ошибка
            {
                // выводим сообщение об ошибке
                MessageBox.Show("При открытии файла произошла ошибка: " +
                ex.Message);
            }
        }
    }
}
