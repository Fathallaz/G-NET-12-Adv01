using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentadv
{
    internal class Factory<T> where T : new()
    {
        public T Create()
            => new T();
    }
}
