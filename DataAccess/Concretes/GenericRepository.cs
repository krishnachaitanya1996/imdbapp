using DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concretes
{
    public class GenericRepository<T> : IGenericRepository<T> where T:class
    {
        protected readonly IMDBDbContext dbContext;

        protected int Save()
        {
            return dbContext.SaveChanges();
        }

        public GenericRepository(IMDBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public int Add(T entity)
        {
            dbContext.Add(entity);
            return Save();
        }

        public T Get(int id)
        {
            return dbContext.Set<T>().Find(id);
        }
        public IEnumerable<T> GetAll()
        {
            return dbContext.Set<T>().ToList();
        }
        public void Delete(T entity)
        {
            dbContext.Set<T>().Remove(entity);
        }
    }
}
