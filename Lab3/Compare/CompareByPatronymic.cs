using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class CompareByPatronymic : IComparer<Note>
    {
        public int Compare(Note x, Note y)
        {
            return string.Compare(x.Patronymic, y.Patronymic);
        }
    }
}
