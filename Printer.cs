using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentadv
{
    internal class Printer<T> where T : IPrintable
    {
        public void PrintItem(T item)
        {
            item.Print();
        }
    }
}
