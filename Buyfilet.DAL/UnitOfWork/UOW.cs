using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.DAL.Contexts;
using Buyfilet.DAL.Interfaces;
using Buyfilet.DAL.Repositories;
using Buyfilet.Entities.Interfaces;

namespace Buyfilet.DAL.UnitOfWork
{
    public class UOW:IUOW
    {
        private readonly BuyfiletContext _context;

        public UOW(BuyfiletContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);
        }

        public async Task SaveChangesAsycn()
        {
            await _context.SaveChangesAsync();
        }
    }
}
