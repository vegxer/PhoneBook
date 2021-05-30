using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Text.Json.Serialization;

namespace Lab3.Open
{
    class DeserializeJson : IOpen
    {
        public List<Note> CreateOpen(string fileName)
        {
            List<Note> notes = new List<Note>();
            try
            {
                string json = File.ReadAllText(fileName);
                notes = JsonSerializer.Deserialize<List<Note>>(json);
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
            try
            {
                string json = File.ReadAllText(fileName);
                notes = JsonSerializer.Deserialize<List<Note>>(json);
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
