using AuthentificationAPI.Contracts;
using AuthentificationAPI.Entities;
using Campus.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace AuthentificationAPI.Persistence
{
    public class RepositoryBase<TKey> : IRepositoryBase<TKey>
    {
        private readonly DbContext dbContext;

        public RepositoryBase(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<TEntity> Create<TEntity>(TEntity entity, CancellationToken cancellationToken) where TEntity : class, IEntityBase<TKey>
        {
            await this.dbContext.AddAsync(entity);
            await this.dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> Delete<TEntity>(Expression<Func<TEntity, bool>> filter, CancellationToken cancellationToken) where TEntity : class, IEntityBase<TKey>
        {
           
            var entity = await this.dbContext.Set<TEntity>().FirstOrDefaultAsync(filter,cancellationToken);
            if(entity != null)
            {
                this.dbContext.Set<TEntity>().Remove(entity);
                return await this.dbContext.SaveChangesAsync(cancellationToken) > 0;
            }
            return false;
        }

        public DbSet<TEntity> GetEntity<TEntity>(CancellationToken cancellationToken) where TEntity : class, IEntityBase<TKey>
        {
            return this.dbContext.Set<TEntity>();
        }

        public async Task<TEntity> GetById<TEntity>(Expression<Func<TEntity, bool>> filter, CancellationToken cancellationToken)
            where TEntity : class, IEntityBase<TKey>
        {
            var entity = await this.dbContext.Set<TEntity>().FirstOrDefaultAsync(filter, cancellationToken);
            return entity;
        }

        public async Task<bool> Update<TEntity>(TEntity entity, CancellationToken cancellationToken) 
            where TEntity : class, IEntityBase<TKey>
        {
            this.dbContext.Set<TEntity>().Update(entity);
            return await this.dbContext.SaveChangesAsync(cancellationToken) > 0;
        }
    }
}
