using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentadv
{
    internal class Container2<T> where T : class
    {
        private T item; 
        
        public void Add(T newItem)
        {
            item = newItem;
        }

        public T Get()
        {
            return item;
        }


    }
}
