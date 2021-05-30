using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace Lab3.Open
{
    class DeserializeBin : IOpen
    {
        public List<Note> CreateOpen(string fileName)
        {
            List<Note> notes = new List<Note>();
            IFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
                    notes = (List<Note>)formatter.Deserialize(fs);
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
            IFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
                    notes = (List<Note>)formatter.Deserialize(fs);
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
