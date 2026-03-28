using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentadv
{
    internal class Manager<T> where T : Person, IPrintable, new()
    {
        public void CreateAndPrint()
        {
            T item = new T(); 
            item.Print();     
            Console.WriteLine(item.Name); 
        }
    }
}
