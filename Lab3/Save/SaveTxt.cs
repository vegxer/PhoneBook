using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Lab3.Save
{
    class SaveTxt : ISave
    {
        public void Save(List<Note> notes, string fileName)
        {
            try
            {
                // используя sw (экземпляр класса StreamWriter),
                // создаем файл с заданным в диалоговом окне именем
                using (StreamWriter sw = new StreamWriter(@fileName))
                {
                    // проходим по всем элементам списка
                    foreach (Note MyRecord in notes)
                    {
                        // записываем каждое поле в отдельной строке
                        sw.WriteLine(MyRecord.Surname);
                        sw.WriteLine(MyRecord.Name);
                        sw.WriteLine(MyRecord.Patronymic);
                        sw.WriteLine(MyRecord.Street);
                        sw.WriteLine(MyRecord.Building);
                        sw.WriteLine(MyRecord.Flat);
                        sw.WriteLine(MyRecord.Phone);
                    }
                }
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
