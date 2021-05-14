using System;
using System.Collections.Generic;

namespace DAL.Repositories.Interfaces
{
    interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        IEnumerable<T> Fine(Func<T, Boolean> predicate);
        void Create(T item);
        void Update(T item);
        void Delete(int id);

    }
}
