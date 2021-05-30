using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab3.Open
{
    class OpenTxt : IOpen
    {
        public bool AddOpen(string fileName, List<Note> PhoneNote)
        {
            bool addedSmth = false;
            Note MyRecord;

            try // обработчик исключительных ситуаций
            {

                // считываем из указанного в диалоговом окне файла
                using (StreamReader sr = new StreamReader(@fileName))
                {
                    // пока не дошли до конца файла
                    while (!sr.EndOfStream)
                    {
                        //выделяем место под запись
                        MyRecord = new Note();
                        // считываем значения полей записи из файла
                        MyRecord.Surname = sr.ReadLine();
                        MyRecord.Name = sr.ReadLine();
                        MyRecord.Patronymic = sr.ReadLine();
                        MyRecord.Street = sr.ReadLine();
                        MyRecord.Building = ushort.Parse(sr.ReadLine());
                        MyRecord.Flat = ushort.Parse(sr.ReadLine());
                        MyRecord.Phone = sr.ReadLine();
                        //добавляем запись в список
                        if (!MyRecord.In(PhoneNote))
                        {
                            if (MyRecord.IsCorrect())
                            {
                                PhoneNote.Add(MyRecord);
                                addedSmth = true;
                            }
                        }
                        else
                            MessageBox.Show("Найдена уже существующая запись!\nОна не будет добавлена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex) // если произошла ошибка
            {
                // выводим сообщение об ошибке
                MessageBox.Show("При открытии файла произошла ошибка: " +
                ex.Message);
            }
            return addedSmth;
        }

        public List<Note> CreateOpen(string fileName)
        {
            List<Note> PhoneNote = new List<Note>();
            Note MyRecord;

            try // обработчик исключительных ситуаций
            {
                // считываем из указанного в диалоговом окне файла
                using (StreamReader sr = new StreamReader(@fileName))
                {
                    // пока не дошли до конца файла
                    while (!sr.EndOfStream)
                    {
                        //выделяем место под запись
                        MyRecord = new Note();
                        // считываем значения полей записи из файла
                        MyRecord.Surname = sr.ReadLine();
                        MyRecord.Name = sr.ReadLine();
                        MyRecord.Patronymic = sr.ReadLine();
                        MyRecord.Street = sr.ReadLine();
                        MyRecord.Building = ushort.Parse(sr.ReadLine());
                        MyRecord.Flat = ushort.Parse(sr.ReadLine());
                        MyRecord.Phone = sr.ReadLine();
                        //добавляем запись в список
                        if (!MyRecord.In(PhoneNote))
                        {
                            if (MyRecord.IsCorrect())
                                PhoneNote.Add(MyRecord);
                        }
                        else
                            MessageBox.Show("Найдена уже существующая запись!\nОна не будет добавлена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex) // если произошла ошибка
            {
                // выводим сообщение об ошибке
                MessageBox.Show("При открытии файла произошла ошибка: " +
                ex.Message);
            }
            return PhoneNote;
        }
    }
}
