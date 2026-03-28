using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentadv
{
    internal class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{Name} barks!");
        }
    }
}
