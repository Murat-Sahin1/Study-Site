using Microsoft.EntityFrameworkCore;
using Study_Site.Application.Interfaces.Repositories;
using Study_Site.Domain.Entities.Common;
using Study_Site.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Study_Site.Persistence.Repositories
{
    public class ReadRepositoryAsync<TEntity> : IReadRepositoryAsync<TEntity> where TEntity : BaseEntity
    {
        public StudySiteDbContext _context;
        public DbSet<TEntity> Table;

        public ReadRepositoryAsync(StudySiteDbContext context)
        {
            _context = context;
            Table = _context.Set<TEntity>();
        }

        public IReadOnlyList<TEntity> GetAllAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "", bool tracking = true)
        {
            IQueryable<TEntity> query = Table; //var query = Table.AsQueryable();

            if (!tracking)
            {
                query = query.AsNoTracking();
            }

            if(filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split(
                new char[] {','}, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public async Task<TEntity> GetByIdAsync(int id, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            TEntity returnedEntity = await query.FirstOrDefaultAsync(data => data.Id == id);

            return returnedEntity;
        }

        public async Task<TEntity> GetSingleAsync(TEntity entity, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            TEntity returnedEntity = await query.FirstOrDefaultAsync(_entity => entity == _entity);

            return returnedEntity;
        }

        public IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> expression, bool tracking = true)
        {
            var query = Table.Where(expression);
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return query;
        }
    }
}
