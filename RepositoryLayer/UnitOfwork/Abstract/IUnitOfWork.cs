using CoreLayer.BaseEntities;
using RepositoryLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.UnitOfwork.Abstract
{
    public interface IUnitOfWork
    {
        void Commit();
        Task<bool> CommitAsync();
        IGenericRepositories<T> GetGenericRepository<T>() where T : class, IBaseEntity, new();
        ValueTask DisposeAsync();
    }
}
