using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentadv
{
    internal class Document : IPrintable
    {
        public string Title { get; set; } = "aaa";
        public void Print()
        {
            Console.WriteLine(Title);
        }
    }
}
