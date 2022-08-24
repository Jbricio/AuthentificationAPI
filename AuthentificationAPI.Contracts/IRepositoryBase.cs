using Campus.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace AuthentificationAPI.Contracts
{
    public interface IRepositoryBase<TKey>
    {
        Task<TEntity> Create<TEntity>(TEntity entity, CancellationToken cancellationToken) where TEntity : class, IEntityBase<TKey>;
        Task<TEntity> GetById<TEntity>(Expression<Func<TEntity, bool>> filter, CancellationToken cancellationToken) where TEntity : class, IEntityBase<TKey>;
        DbSet<TEntity> GetEntity<TEntity>(CancellationToken cancellationToken) where TEntity : class, IEntityBase<TKey>;
        Task<bool> Update<TEntity>(TEntity entity, CancellationToken cancellationToken) where TEntity : class, IEntityBase<TKey>;
        Task<bool> Delete<TEntity>(Expression<Func<TEntity, bool>> predicate,
            CancellationToken cancellationToken) where TEntity : class, IEntityBase<TKey>;

    }
}
