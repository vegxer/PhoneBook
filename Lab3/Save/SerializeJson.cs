using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace Lab3.Save
{
    class SerializeJson : ISave
    {
        public void Save(List<Note> notes, string fileName)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            try
            {
                string json = JsonSerializer.Serialize(notes, options);
                File.WriteAllText(fileName, json);
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
