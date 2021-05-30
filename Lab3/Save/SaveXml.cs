using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace Lab3.Save
{
    class SaveXml : ISave
    {
        public void Save(List<Note> notes, string fileName)
        {
            try
            {
                //создание xml документа со строкой <?xml version="1.0" encoding="utf-8"?>
                XmlTextWriter textWritter = new XmlTextWriter(@fileName, Encoding.UTF8);
                textWritter.WriteStartDocument();//запись заголовка документа
                textWritter.WriteStartElement("Notes");//создание головы
                textWritter.WriteEndElement();//закрываем голову
                textWritter.Close();//закрываем документ

                XmlDocument document = new XmlDocument();//открываем документ  
                document.Load(@fileName);//загружаем из xml файла

                int i = 0;
                foreach (Note x in notes)
                {
                    //Создаём XML-запись
                    XmlElement element = document.CreateElement("Note");
                    document.DocumentElement.AppendChild(element); // указываем родителя
                    XmlAttribute attribute = document.CreateAttribute("id"); // создаём атрибут
                    attribute.Value = i.ToString(); // устанавливаем значение атрибута
                    element.Attributes.Append(attribute); // добавляем атрибут

                    //Добавляем в запись данные
                    XmlNode lastnameElem = document.CreateElement("Surname"); // даём имя
                    lastnameElem.InnerText = x.Surname; // и значение
                    element.AppendChild(lastnameElem); // и указываем кому принадлежит
                    XmlNode nameElem = document.CreateElement("Name"); // даём имя
                    nameElem.InnerText = x.Name; // и значение
                    element.AppendChild(nameElem); // и указываем кому принадлежит
                    XmlNode patronymicElem = document.CreateElement("Patronymic"); // даём имя
                    patronymicElem.InnerText = x.Patronymic; // и значение
                    element.AppendChild(patronymicElem); // и указываем кому принадлежит
                    XmlNode streetElem = document.CreateElement("Street"); // даём имя
                    streetElem.InnerText = x.Street; // и значение
                    element.AppendChild(streetElem); // и указываем кому принадлежит
                    XmlNode buildingElem = document.CreateElement("Building"); // даём имя
                    buildingElem.InnerText = x.Building.ToString(); // и значение
                    element.AppendChild(buildingElem); // и указываем кому принадлежит
                    XmlNode flatElem = document.CreateElement("Flat"); // даём имя
                    flatElem.InnerText = x.Flat.ToString(); // и значение
                    element.AppendChild(flatElem); // и указываем кому принадлежит
                    XmlNode phoneElem = document.CreateElement("Phone"); // даём имя
                    phoneElem.InnerText = x.Phone; // и значение
                    element.AppendChild(phoneElem); // и указываем кому принадлежит
                    ++i;
                }
                document.Save(@fileName);
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
