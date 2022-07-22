using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.Common.Enums;
using Buyfilet.Entities.Interfaces;

namespace Buyfilet.DAL.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllAsync(Expression<Func<T,bool>> filter);
        Task<List<T>> GetAllAsync(Expression<Func<T,bool>> selector, OrderByType OrderByType= OrderByType.DESC);
        Task<List<T>> GetAllAsync(Expression<Func<T,bool>> filter, Expression<Func<T, bool>> selector, OrderByType orderByType= OrderByType.DESC);
        Task<T?> FindAsync(object id);
        Task<T?> GetByFilterAsycn(Expression<Func<T, bool>> filter, bool asNoTracking = false);
        Task<IQueryable<T>> GetQuery();
        void Remove(T entity);
        Task CreateAsync(T entity);
        void Update(T entity,T unchanged);

    }
}
