using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace Lab3.Open
{
    class DeserializeXml : IOpen
    {
        public List<Note> CreateOpen(string fileName)
        {
            List<Note> notes = new List<Note>();
            XmlSerializer reader = new XmlSerializer(typeof(List<Note>));
            try
            {
                using (StreamReader file = new StreamReader(fileName))
                    notes = (List<Note>)reader.Deserialize(file);
            }
            catch (Exception ex) // если произошла ошибка
            {
                // выводим сообщение об ошибке
                MessageBox.Show("При открытии файла произошла ошибка: " +
                ex.Message);
            }
            for (int i = 0; i < notes.Count; ++i)
                if (!notes[i].IsCorrect())
                    notes.RemoveAt(i--);
            return notes;
        }

        public bool AddOpen(string fileName, List<Note> PhoneNote)
        {
            List<Note> notes = new List<Note>();
            XmlSerializer reader = new XmlSerializer(typeof(List<Note>));
            try
            {
                using (StreamReader file = new StreamReader(fileName))
                    notes = (List<Note>)reader.Deserialize(file);
            }
            catch (Exception ex) // если произошла ошибка
            {
                // выводим сообщение об ошибке
                MessageBox.Show("При открытии файла произошла ошибка: " +
                ex.Message);
            }

            bool isAddedSmth = false;
            foreach (Note note in notes)
            {
                if (!note.In(PhoneNote))
                {
                    if (note.IsCorrect())
                    {
                        PhoneNote.Add(note);
                        isAddedSmth = true;
                    }
                }
                else
                    MessageBox.Show("Найдена уже существующая запись!\nОна не будет добавлена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isAddedSmth;
        }
    }
}
