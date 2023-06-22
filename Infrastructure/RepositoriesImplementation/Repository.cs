using Domain.Entities.ModelEF.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.RepositoriesImplementation
{
    /// <summary>
    /// Repository read and write
    /// </summary>
    /// <typeparam name="T">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key</typeparam>
    public abstract class Repository<T, TPrimaryKey> : IRepository<T, TPrimaryKey> where T : class, IEntity<TPrimaryKey>
    {
        protected readonly DbContext Context;
        private readonly DbSet<T> _entitySet;

        protected Repository(DbContext context)
        {
            Context = context;
            _entitySet = Context.Set<T>();
        }

        /// <summary>
        /// Query all entities in the database
        /// </summary>
        /// <param name="noTracking">Call with NoTracking</param>
        /// <returns>List of entities</returns>
        public IQueryable<T> GetAll(bool noTracking = false)
        {
            return noTracking ? _entitySet.AsNoTracking() : _entitySet;
        }

        /// <summary>
        /// Query all entities in the database asynchronously
        /// </summary>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <param name="noTracking">Call with NoTracking</param>
        /// <returns>List of entities</returns>
        public async Task<List<T>> GetAllAsync(CancellationToken cancellationToken, bool noTracking = false)
        {
            return await GetAll().ToListAsync(cancellationToken);
        }

        /// <summary>
        /// Add entity
        /// <param name="entity">Entity to add</param>
        /// <returns>Added entity</returns>
        public virtual T Add(T entity)
        {
            var objToReturn = _entitySet.Add(entity);
            return objToReturn.Entity;
        }

        /// <summary>
        /// Add entity asynchronously
        /// </summary>
        /// <param name="entity">Entity to add</param>
        /// <returns>Added entity</returns>
        public virtual async Task<T> AddAsync(T entity)
        {
            return (await _entitySet.AddAsync(entity)).Entity;
        }

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity">Entity to change</param>
        public virtual void Update(T entity)
        {            
            Context.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Get entity by id
        /// </summary>
        /// <param name="id">Entity id</param>
        /// <returns>Entity</returns>
        public virtual T Get(TPrimaryKey id)
        {
            return _entitySet.Find(id);
        }

        /// <summary>
        /// Get entity by id asynchronously
        /// </summary>
        /// <param name="id">Entity id</param>
        /// <returns>Entity</returns>
        public virtual async Task<T> GetAsync(TPrimaryKey id)
        {
            return await _entitySet.FindAsync(id);
        }

        /// <summary>
        /// Save changes
        /// </summary>
        public virtual void SaveChanges()
        {
            Context.SaveChanges();
        }

        /// <summary>
        /// Save changes asynchronously
        /// </summary>
        /// <param name="cancellationToken">Cancellation token</param>
        public virtual async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await Context.SaveChangesAsync(cancellationToken);
        }        
    }
}
