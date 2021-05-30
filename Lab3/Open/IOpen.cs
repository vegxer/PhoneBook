using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Open
{
    interface IOpen
    {
        bool AddOpen(string fileName, List<Note> PhoneNote);

        List<Note> CreateOpen(string fileName);
    }
}
