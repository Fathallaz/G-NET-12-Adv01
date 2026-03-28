using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentadv
{
    internal class Container1<T> where T : struct
    {
        private T item;
        public void Add(T item)
        {
            this.item = item;
        }
        public T Get()
        {
            return item;
        }

    }
}
