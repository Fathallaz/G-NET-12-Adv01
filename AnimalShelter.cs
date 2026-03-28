using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentadv
{
    internal class AnimalShelter<T> where T : Animal
    {
        private T animal;

        public void Add(T animal)
        {
            this.animal = animal;
        }

        public void MakeItSpeak()
        {
            animal.Speak(); 
        }
    }
}
