using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class SearchAdressForm : Form
    {
        List<Note> PhoneNote;
        public SearchAdressForm(List<Note> PhoneNote)
        {
            InitializeComponent();
            this.PhoneNote = PhoneNote;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // очищаем окно для вывода результатов
            textBoxResults.Clear();
            // количество найденных результатов
            int i = 0;
            // цикл for для каждого элемента списка - foreach
            foreach (Note MyRecord in PhoneNote)
            {
                // если выполняются условия поиска
                if (MyRecord.Street.Contains(textBoxStreet.Text) &&
                MyRecord.Building == numericUpDownBuilding.Value && MyRecord.Flat == numericUpDownFlat.Value)
                {
                    // увеличиваем счетчик найденных записей
                    ++i;
                    // дописываем элемент и его номер к результату 
                    textBoxResults.Text = textBoxResults.Text + i.ToString() + ". " + MyRecord.Surname + " "
                        + MyRecord.Name + " " + MyRecord.Patronymic + ", ул. " + MyRecord.Street + ", д." +
                        MyRecord.Building + ", кв. " + MyRecord.Flat + ", тел. " + MyRecord.Phone + "\r\n";
                }
            }
            // если не найдено ни одной записи, выводим сообщение
            if (i == 0)
                textBoxResults.Text = "Записей, удовлетворяющих поставленным условиям, в списке абонентов нет! ";
        }
    }
}
