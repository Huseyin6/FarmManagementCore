using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using FarmManagement.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FarmManagement.Data.Repository
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        protected DbContext _dbContext;
        private DbSet<T> _dbSet;
        public RepositoryBase(DbContext dbContext)// miras alanlar kullanabilmesi için bir context vermeleri gerek
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }
        public void Add(T entity)
        {
             _dbSet.Add(entity);
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public List<T> GetMany(Expression<Func<T, bool>> where = null)
        {
            return (where == null ? _dbSet.ToList() : _dbSet.Where(where).ToList());
        }

        public void Remove(T entity)
        {
           _dbSet.Remove(entity);
        }

        public void RemoveById(int id)
        {
            _dbSet.Remove(GetById(id));
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}