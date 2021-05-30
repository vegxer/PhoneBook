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
    public partial class AddForm : Form
    {
        public Note MyRecord;
        public bool addClicked;
        public AddForm(Note MyRecord, AddOrEdit State)
        {
            InitializeComponent();
            this.MyRecord = MyRecord;
            // если форма открыта для добавления
            if (State == AddOrEdit.Add)
            {
                Text = "Добавление абонента";
                buttonAdd.Text = "Добавить";
            }
            else // если форма открыта для изменения записи
            {
                Text = "Изменение абонента";
                buttonAdd.Text = "Изменить";
                // определяем значение компонентов на форме
                textBoxSurname.Text = MyRecord.Surname;
                textBoxName.Text = MyRecord.Name;
                textBoxPatronymic.Text = MyRecord.Patronymic;
                maskedTextBoxPhone.Text = MyRecord.Phone;
                textBoxStreet.Text = MyRecord.Street;
                numericUpDownBuilding.Value = MyRecord.Building;
                numericUpDownFlat.Value = MyRecord.Flat;
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addClicked = true;
            // определяем поля записи -
            // берем значения из соответствующих компонентов на форме
            MyRecord.Surname = textBoxSurname.Text;
            MyRecord.Name = textBoxName.Text;
            MyRecord.Patronymic = textBoxPatronymic.Text;
            MyRecord.Phone = maskedTextBoxPhone.Text;
            MyRecord.Street = textBoxStreet.Text;
            MyRecord.Building = (ushort)numericUpDownBuilding.Value;
            MyRecord.Flat = (ushort)numericUpDownFlat.Value;
            Close();
        }

        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!addClicked && IsSmthEntered() && MessageBox.Show("Изменения не будут сохранены!\nСохранить изменения?", "Сохранить изменения?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                buttonAdd_Click(sender, e);
        }

        private bool IsSmthEntered()
        {
            return !string.IsNullOrWhiteSpace(textBoxName.Text) || !string.IsNullOrWhiteSpace(textBoxPatronymic.Text)
                || !string.IsNullOrWhiteSpace(textBoxSurname.Text) || maskedTextBoxPhone.Text != "(   )    -"
                || !string.IsNullOrWhiteSpace(textBoxStreet.Text)
                || numericUpDownBuilding.Value != 1 || numericUpDownFlat.Value != 1;
        }
    }
}
