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
using System.Xml;
using System.Xml.Serialization;
using Lab3.Save;
using Lab3.Open;

namespace Lab3
{
    public partial class MainForm : Form
    {
        [XmlElement("Notes")]
        List<Note> PhoneNote;
        int current, addedDocs;
        bool saved;
        string pathToOpenedFile;
        ISave saveBehavior;
        IOpen openBehavior;

        public MainForm()
        {
            InitializeComponent();
            PhoneNote = new List<Note>();
            current = -1;
            addedDocs = 0;
            saved = true;
            openFileDialog.Filter = "(*.txt)|*.txt|(*.xml)|*.xml|(Бинарный файл *.dat)|*.dat|(*.json)|*.json";
            saveFileDialog.Filter = "(*.txt)|*.txt|(*.xml)|*.xml|(Бинарный файл *.dat)|*.dat|(*.json)|*.json";
        }

        private void PrintElement()
        {
            if ((current >= 0) && (current < PhoneNote.Count))
            {   // если есть что выводить
                // MyRecord - запись списка PhoneNote номер current
                Note MyRecord = PhoneNote[current];
                // записываем в соответствующие элементы на форме 
                // поля из записи MyRecord 
                textBoxSurname.Text = MyRecord.Surname;
                textBoxName.Text = MyRecord.Name;
                textBoxPatronymic.Text = MyRecord.Patronymic;
                maskedTextBoxPhone.Text = MyRecord.Phone;
                textBoxStreet.Text = MyRecord.Street;
                numericUpDownBuilding.Value = MyRecord.Building;
                numericUpDownFlat.Value = MyRecord.Flat;
            }
            else // если current равно -1, т. е. список пуст
            {   // очистить поля формы 
                textBoxSurname.Clear();
                textBoxName.Clear();
                textBoxPatronymic.Clear();
                maskedTextBoxPhone.Clear();
                textBoxStreet.Clear();
                numericUpDownBuilding.Value = 1;
                numericUpDownFlat.Value = 1;
            }
            // обновление строки состояния
            toolStripStatusLabel_Number.Text = (current + 1).ToString();
            toolStripStatusLabel_Quantity.Text = PhoneNote.Count.ToString();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // создаем запись - экземпляр класса Note
            Note MyRecord = new Note();
            // создаем экземпляр формы AddForm
            AddForm _AddForm = new AddForm(MyRecord, AddOrEdit.Add);
            // открываем форму для добавления записи
            _AddForm.ShowDialog();            
            if (_AddForm.addClicked)
            {
                if (!_AddForm.MyRecord.In(PhoneNote))
                {
                    // текущей записью становится последняя
                    current = PhoneNote.Count;
                    // добавляем к списку PhoneNote новый элемент - запись MyRecord,
                    // взятую из формы AddForm
                    PhoneNote.Add(_AddForm.MyRecord);
                    ChangeButtonsState();
                    saved = false;
                    // выводим текущий элемент
                    PrintElement();  
                }
                else
                    MessageBox.Show("Такая запись уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            --current;      // уменьшаем номер текущей записи на 1
            PrintElement();
            ChangeButtonsState();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            ++current;      // уменьшаем номер текущей записи на 1
            PrintElement();
            ChangeButtonsState();
        }

        private void ChangeButtonsState()
        {
            if (current == -1)
            {
                buttonNext.Enabled = false;
                buttonPrevious.Enabled = false;
            }
            else
            {
                if (current == PhoneNote.Count - 1)
                    buttonNext.Enabled = false;
                else if (!buttonNext.Enabled)
                    buttonNext.Enabled = true;
                if (current == 0)
                    buttonPrevious.Enabled = false;
                else if (!buttonPrevious.Enabled)
                    buttonPrevious.Enabled = true;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addedDocs > 1 || addedDocs == 0)
                сохранитьКакToolStripMenuItem_Click(sender, e);
            else
                SaveAbonentsList(pathToOpenedFile);
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                SaveAbonentsList(saveFileDialog.FileName);
        }

        private void SaveAbonentsList(string pathToFile)
        {
            try // обработчик исключительных ситуаций
            {
                saveBehavior = SaveCreator.Create(pathToFile);
                saveBehavior.Save(PhoneNote, pathToFile);
                saved = true;
            }
            catch (Exception ex) // перехватываем ошибку
            {
                // выводим информацию об ошибке
                MessageBox.Show("Не удалось сохранить данные! Ошибка: " + ex.Message);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved || addedDocs > 1)
            {
                DialogResult result = MessageBox.Show("Изменения не были сохранены!\nСохранить изменения?", "Сохранить изменения?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    сохранитьToolStripMenuItem_Click(sender, e);
                else if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void поискПоФИОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchNameForm _Search = new SearchNameForm(PhoneNote);
            _Search.ShowDialog();
        }

        private void поискПоАдресуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchAdressForm _Search = new SearchAdressForm(PhoneNote);
            _Search.ShowDialog();
        }

        private void поискПоТелефонуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPhoneForm _Search = new SearchPhoneForm(PhoneNote);
            _Search.ShowDialog();
        }

        private void ShowChanges()
        {
            current = 0;
            ChangeButtonsState();
            PrintElement();
        }

        private void поВозрастаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Any())
            {
                PhoneNote.Sort(new CompareBySurname());
                ShowChanges();
            }
        }

        private void поУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Any())
            {
                PhoneNote.Sort(new CompareBySurname());
                PhoneNote.Reverse();
                ShowChanges();
            }
        }

        private void поВозрастаниюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Any())
            {
                PhoneNote.Sort(new CompareByFlat());
                ShowChanges();
            }
        }

        private void поУбываниюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Any())
            {
                PhoneNote.Sort(new CompareByFlat());
                PhoneNote.Reverse();
                ShowChanges();
            }
        }

        private void поВозрастаниюToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Any())
            {
                PhoneNote.Sort(new CompareByName());
                ShowChanges();
            }
        }

        private void поУбываниюToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Any())
            {
                PhoneNote.Sort(new CompareByName());
                PhoneNote.Reverse();
                ShowChanges();
            }
        }

        private void поВозрастаниюToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Any())
            {
                PhoneNote.Sort(new CompareByPatronymic());
                ShowChanges();
            }
        }

        private void поУбываниюToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Any())
            {
                PhoneNote.Sort(new CompareByPatronymic());
                PhoneNote.Reverse();
                ShowChanges();
            }
        }

        private void поВозрастаниюToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Any())
            {
                PhoneNote.Sort(new CompareByStreet());
                ShowChanges();
            }
        }

        private void поУбываниюToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Any())
            {
                PhoneNote.Sort(new CompareByStreet());
                PhoneNote.Reverse();
                ShowChanges();
            }
        }

        private void поВозрастаниюToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Any())
            {
                PhoneNote.Sort(new CompareByBuilding());
                ShowChanges();
            }
        }

        private void поУбываниюToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Any())
            {
                PhoneNote.Sort(new CompareByBuilding());
                PhoneNote.Reverse();
                ShowChanges();
            }
        }

        private void поВозрастаниюToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Any())
            {
                PhoneNote.Sort(new CompareByPhone());
                ShowChanges();
            }
        }

        private void поУбываниюToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Any())
            {
                PhoneNote.Sort(new CompareByPhone());
                PhoneNote.Reverse();
                ShowChanges();
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Any())
            {
                // создаем запись - экземпляр класса Note
                Note MyRecord = new Note();
                // определяем поля записи
                // (берем значения из соответствующих компонентов на форме)
                MyRecord.Surname = textBoxSurname.Text;
                MyRecord.Name = textBoxName.Text;
                MyRecord.Patronymic = textBoxPatronymic.Text;
                MyRecord.Phone = maskedTextBoxPhone.Text;
                MyRecord.Street = textBoxStreet.Text;
                MyRecord.Building = (ushort)numericUpDownBuilding.Value;
                MyRecord.Flat = (ushort)numericUpDownFlat.Value;
                // создаем экземпляр формы и открываем эту форму
                AddForm _AddForm = new AddForm(MyRecord, AddOrEdit.Edit);
                _AddForm.ShowDialog();
                // изменяем текущую запись
                if (!_AddForm.MyRecord.In(PhoneNote))
                {
                    PhoneNote[current] = _AddForm.MyRecord;
                    saved = false;
                    ChangeButtonsState();
                    PrintElement();
                }
                else
                    MessageBox.Show("Такая запись уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            // если в диалоговом окне нажали ОК
            {
                openBehavior = OpenCreator.Create(openFileDialog.FileName);
                openBehavior.AddOpen(openFileDialog.FileName, PhoneNote);

                if (PhoneNote.Count == 0)
                    current = -1;
                else
                    current = 0;
                saved = true;
                ++addedDocs;
                pathToOpenedFile = openFileDialog.FileName;
                ChangeButtonsState();
                // выводим текущий элемент
                PrintElement();
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!saved || addedDocs > 1)
            {
                DialogResult result = MessageBox.Show("Изменения не были сохранены!\nСохранить изменения?", "Сохранить изменения?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    сохранитьToolStripMenuItem_Click(sender, e);
            }
            addedDocs = 0;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            // если в диалоговом окне нажали ОК
            {
                openBehavior = OpenCreator.Create(openFileDialog.FileName);
                PhoneNote = openBehavior.CreateOpen(openFileDialog.FileName);

                if (PhoneNote.Count == 0)
                    current = -1;
                else
                    current = 0;
                saved = true;
                ++addedDocs;
                pathToOpenedFile = openFileDialog.FileName;
                ChangeButtonsState();
                // выводим текущий элемент
                PrintElement();
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Any())
            {
                PhoneNote.RemoveAt(current);
                if (current == PhoneNote.Count)
                    --current;
                saved = false;
                ChangeButtonsState();
                PrintElement();
            }    
        }
    }

    public enum AddOrEdit
    {
        Add,
        Edit
    }
}
