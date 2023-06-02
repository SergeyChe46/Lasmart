using System.Linq.Expressions;

namespace Lasmart.Repository
{
    public interface IRepository<T>
    {
        public IQueryable<T> GetAll();
        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> condition);
        public void CreateAsync(T entity);
        public void UpdateAsync(T entity);
        public void DeleteAsync(T entity);
    }
}