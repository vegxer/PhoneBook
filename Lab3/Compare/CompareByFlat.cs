using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class CompareByFlat : IComparer<Note>
    {
        public int Compare(Note x, Note y)
        {
            return x.Flat < y.Flat ? -1 : x.Flat > y.Flat ? 1 : 0;
        }
    }
}
