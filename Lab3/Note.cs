using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lab3
{
    [Serializable]
    public class Note
    {
        [JsonInclude]
        public string Surname;
        [JsonInclude]
        public string Name;
        [JsonInclude]
        public string Patronymic;
        [JsonInclude]
        public string Street;
        [JsonInclude]
        public ushort Building;
        [JsonInclude]
        public ushort Flat;
        [JsonInclude]
        public string Phone;

        public bool In(List<Note> PhoneNote)
        {
            foreach (Note element in PhoneNote)
                if (element.Equals(this))
                    return true;
            return false;
        }

        public bool IsCorrect()
        {
            return Surname != null && Name != null && Patronymic != null &&
                Street != null && Building != 0 && Flat != 0 && Phone != null;
        }

        public override bool Equals(object obj)
        {
            if (obj is Note)
            {
                return (obj as Note).Surname == Surname && (obj as Note).Name == Name
                    && (obj as Note).Patronymic == Patronymic && (obj as Note).Street == Street
                    && (obj as Note).Building == Building && (obj as Note).Flat == Flat
                    && (obj as Note).Phone == Phone;
            }
            else
                throw new ArgumentException("Неверный тип объекта");
        }

        public override int GetHashCode()
        {
            return Hash(Surname) ^ Hash(Name) ^ Hash(Patronymic) ^ Hash(Street) ^ Hash(Phone) ^ Building ^ Flat;
        }

        public int Hash(string str)
        {
            int x = 63, q = 4813;
            int hash = str[0];
            for (int i = 1; i < str.Length; ++i)
                hash = (hash * x + str[i]) % q;
            return hash;
        }
    }
}
