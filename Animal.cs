using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentadv
{
    internal class Animal
    {
        public string Name { get; set; }
        public void Speak()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }
    }
}
