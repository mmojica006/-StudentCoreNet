using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Persistencia.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetAsyncTask(int id);
        Task<IEnumerable<T>> GetAllAsyTask(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null
        );

        Task<T> GetFirstOrDefaultAsyncTask(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
        );

        Task AddAsyncTask(T entity);
        Task RemoveAsyncTask(int id);
        void Remove(T entity);
    }
}