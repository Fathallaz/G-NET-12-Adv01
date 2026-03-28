using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentadv
{
    internal interface IRepository<T> 
    {
        void Add(T item);
        T GetById(int id);

        IEnumerable<T> GetAll();
        void Delete(int id);
    }
}
