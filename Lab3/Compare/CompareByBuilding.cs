using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class CompareByBuilding : IComparer<Note>
    {
        public int Compare(Note x, Note y)
        {
            return x.Building < y.Building ? -1 : x.Building > y.Building ? 1 : 0;
        }
    }
}
