using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstractions
{
    public interface IGenericRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        int Add(T entity);
        void Delete(T entity);
    }
}
