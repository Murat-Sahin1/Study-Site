using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Study_Site.Application.Interfaces.Repositories;
using Study_Site.Domain.Entities.Common;
using Study_Site.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Site.Persistence.Repositories
{
    public class WriteRepositoryAsync<TEntity> : IWriteRepositoryAsync<TEntity> where TEntity : BaseEntity
    {
       private readonly StudySiteDbContext _context;
       public DbSet<TEntity> Table;

       public WriteRepositoryAsync(StudySiteDbContext context)
        {
            _context = context;
            Table = _context.Set<TEntity>();
        }


        public async Task<bool> InsertAsync(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry =  await Table.AddAsync(entity);

            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> InsertRangeAsync(List<TEntity> entityList)
        {
            await Table.AddRangeAsync(entityList);

            return true;
        }

        public async Task<bool> RemoveById(int id)
        {
            TEntity removeEntity = await Table.FindAsync(id);
            EntityEntry<TEntity> entityEntry = Table.Remove(removeEntity);

            return entityEntry.State == EntityState.Deleted;
        }

        public bool Remove(TEntity entity)
        {
            EntityEntry entityEntry = Table.Remove(entity);

            return entityEntry.State == EntityState.Deleted;
        }

        public bool RemoveRange(List<TEntity> entityList)
        {
            Table.RemoveRange(entityList);

            return true;
        }

        public bool UpdateAsync(TEntity entity)
        {
            EntityEntry entityEntry = Table.Update(entity);

            return entityEntry.State == EntityState.Modified;
        }

        public bool UpdateRange(List<TEntity> entityList)
        {
            Table.UpdateRange(entityList);

            return true;
        }
        public async Task<bool> SaveAsync()
        {
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
