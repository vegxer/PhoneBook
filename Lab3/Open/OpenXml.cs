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

namespace Lab3.Open
{
    class OpenXml : IOpen
    {
        public bool AddOpen(string fileName, List<Note> PhoneNote)
        {
            bool addedSmth = false;
            XmlDocument xDoc = new XmlDocument();
            try
            {
                xDoc.Load(@fileName);
                XmlElement xRoot = xDoc.DocumentElement;
                foreach (XmlElement xnode in xRoot)
                {
                    Note node = new Note();
                    foreach (XmlNode cnode in xnode.ChildNodes)
                    {
                        if (cnode.Name == "Surname")
                            node.Surname = cnode.InnerText;
                        else if (cnode.Name == "Name")
                            node.Name = cnode.InnerText;
                        else if (cnode.Name == "Patronymic")
                            node.Patronymic = cnode.InnerText;
                        else if (cnode.Name == "Street")
                            node.Street = cnode.InnerText;
                        else if (cnode.Name == "Building")
                            node.Building = ushort.Parse(cnode.InnerText);
                        else if (cnode.Name == "Flat")
                            node.Flat = ushort.Parse(cnode.InnerText);
                        else if (cnode.Name == "Phone")
                            node.Phone = cnode.InnerText;
                    }
                    if (!node.In(PhoneNote))
                    {
                        if (node.IsCorrect())
                        {
                            addedSmth = true;
                            PhoneNote.Add(node);
                        }
                    }
                    else
                        MessageBox.Show("Найдена уже существующая запись!\nОна не будет добавлена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("При открытии файла произошла ошибка: " + error.Message);
            }
            return addedSmth;
        }

        public List<Note> CreateOpen(string fileName)
        {
            List<Note> PhoneNote = new List<Note>();
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(@fileName);
                XmlElement xRoot = xDoc.DocumentElement;
                foreach (XmlElement xnode in xRoot)
                {
                    Note node = new Note();
                    foreach (XmlNode cnode in xnode.ChildNodes)
                    {
                        if (cnode.Name == "Surname")
                            node.Surname = cnode.InnerText;
                        else if (cnode.Name == "Name")
                            node.Name = cnode.InnerText;
                        else if (cnode.Name == "Patronymic")
                            node.Patronymic = cnode.InnerText;
                        else if (cnode.Name == "Street")
                            node.Street = cnode.InnerText;
                        else if (cnode.Name == "Building")
                            node.Building = ushort.Parse(cnode.InnerText);
                        else if (cnode.Name == "Flat")
                            node.Flat = ushort.Parse(cnode.InnerText);
                        else if (cnode.Name == "Phone")
                            node.Phone = cnode.InnerText;
                    }
                    if (!node.In(PhoneNote))
                    {
                        if (node.IsCorrect())
                            PhoneNote.Add(node);
                    }
                    else
                        MessageBox.Show("Найдена уже существующая запись!\nОна не будет добавлена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("При открытии файла произошла ошибка: " + error.Message);
            }
            return PhoneNote;
        }
    }
}
