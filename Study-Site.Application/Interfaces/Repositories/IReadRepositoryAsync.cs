using Study_Site.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Study_Site.Application.Interfaces.Repositories
{
    public interface IReadRepositoryAsync<TEntity>: IRepositoryAsync<TEntity> where TEntity : BaseEntity
    {
        IReadOnlyList<TEntity> GetAllAsync(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "",
            bool tracking = true);
        Task<TEntity> GetByIdAsync(int id, bool tracking = true);
        Task<TEntity> GetSingleAsync(TEntity entity, bool tracking = true);
        IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> expression, bool tracking = true);
    }
}
