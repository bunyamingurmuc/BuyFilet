using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.Common.Enums;
using Buyfilet.DAL.Contexts;
using Buyfilet.DAL.Interfaces;
using Buyfilet.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Buyfilet.DAL.Repositories
{
    public class Repository<T>:IRepository<T> where T : BaseEntity
    {
        private readonly BuyfiletContext _context;

        public Repository(BuyfiletContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter)
        {
            return await _context.Set<T>().Where(filter).ToListAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> selector, OrderByType OrderByType = OrderByType.DESC)
        {
            return OrderByType == OrderByType.ASC
                ? await _context.Set<T>().AsNoTracking().OrderBy(selector).ToListAsync()
                : await _context.Set<T>().AsNoTracking().OrderByDescending(selector).ToListAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter, Expression<Func<T, bool>> selector, OrderByType orderByType = OrderByType.DESC)
        {
            return orderByType == OrderByType.ASC
                ? await _context.Set<T>().Where(filter).AsNoTracking().OrderBy(selector).ToListAsync()
                : await _context.Set<T>().Where(filter).AsNoTracking().OrderByDescending(selector).ToListAsync();
        }

        public async Task<T?> FindAsync(object id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T?> GetByFilterAsycn(Expression<Func<T, bool>> filter, bool asNoTracking = false)
        {
            return !asNoTracking
                ? await _context.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter)
                : await _context.Set<T>().SingleOrDefaultAsync(filter);
        }

        public async Task<IQueryable<T>> GetQuery()
        {
            var data =await _context.Set<T>().ToListAsync();
            var quarabled = data.AsQueryable();
            return _context.Set<T>().AsQueryable();
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void Update(T entity, T unchanged)
        {
            _context.Entry(unchanged).CurrentValues.SetValues(entity);
        }
    }
}
