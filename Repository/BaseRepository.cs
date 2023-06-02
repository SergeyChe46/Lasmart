using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lasmart.Repository
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly ApplicationContext _context;
        public BaseRepository(ApplicationContext context)
        {
            _context = context;
        }
        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> condition)
        {
            return _context.Set<T>().Where(condition);
        }
        public void CreateAsync(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public void UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
        }
        public void DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking();
        }
    }
}