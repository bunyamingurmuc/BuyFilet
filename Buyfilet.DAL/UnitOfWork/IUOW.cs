using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.DAL.Interfaces;
using Buyfilet.Entities.Interfaces;

namespace Buyfilet.DAL.UnitOfWork
{
    public interface IUOW
    {
        IRepository<T> GetRepository<T>() where T : BaseEntity;
        Task SaveChangesAsycn();
    }
}
