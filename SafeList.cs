using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentadv
{
    internal class SafeList<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T Get(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                return items[index];
            }
            else
            {
                return default(T); 
            }
        }

        public int Count => items.Count;
    
}
}
