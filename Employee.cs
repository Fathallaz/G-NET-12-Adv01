using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Assignmentadv
{
    internal class Employee : Person, IPrintable
    {
        public void Print()
        {
            Console.WriteLine($"Employee: {Name}");
        }
    }
}
