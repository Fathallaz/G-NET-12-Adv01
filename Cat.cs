using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentadv
{
    internal class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine($"{Name} meows!");
        }
    }
}
