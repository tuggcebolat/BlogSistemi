using BlogSistemi.Data.Repositories.Abstract;
using BlogSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSistemi.Data.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class, IEntity, new();
        Task<int> SaveAsync();
        int Save();
    }
}
