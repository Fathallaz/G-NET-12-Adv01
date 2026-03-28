using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentadv
{
    internal class Container<T>
    {
        private T Item;

            public void Add(T item)
        {
              Item = item;

        }
        public T Get()
        {
            return Item; 
        }
    }
}
