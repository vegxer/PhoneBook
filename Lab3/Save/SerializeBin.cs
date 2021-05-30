using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace Lab3.Save
{
    class SerializeBin : ISave
    {
        public void Save(List<Note> notes, string fileName)
        {
            IFormatter formatter = new BinaryFormatter();
            try
            {
                using (Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
                    formatter.Serialize(stream, notes);
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
