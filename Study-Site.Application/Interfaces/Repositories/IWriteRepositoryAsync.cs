using Study_Site.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Site.Application.Interfaces.Repositories
{
    public interface IWriteRepositoryAsync<TEntity>: IRepositoryAsync<TEntity> where TEntity : BaseEntity
    {
        Task<bool> InsertAsync(TEntity entity);
        Task<bool> InsertRangeAsync(List<TEntity> entityList);
        bool UpdateRange(List<TEntity> entityList);
        bool UpdateAsync(TEntity entity);
        bool Remove(TEntity entity);
        Task<bool> RemoveById(int id);
        bool RemoveRange(List<TEntity> entityList);
        Task<bool> SaveAsync();
    }
}
