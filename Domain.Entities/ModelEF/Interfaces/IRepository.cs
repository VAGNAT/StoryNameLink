namespace Domain.Entities.ModelEF.Interfaces
{
    /// <summary>
    /// Basic interface
    /// </summary>
    public interface IRepository
    {
    }

    /// <summary>
    /// Descriptions of common methods for all repositories.
    /// </summary>
    /// <typeparam name="T">Entity type for the repository</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type</typeparam>
    public interface IRepository<T, TPrimaryKey> : IReadRepository<T, TPrimaryKey>
        where T : IEntity<TPrimaryKey>
    {
        /// <summary>
        /// Update entity.
        /// </summary>
        /// <param name="entity">Entity to change</param>
        void Update(T entity);

        /// <summary>
        /// Add entity.
        /// <param name="entity">Entity to add</param>
        /// <returns>Added entity</returns>
        T Add(T entity);

        /// <summary>
        /// Add entity asynchronously.
        /// </summary>
        /// <param name="entity">Entity to add</param>
        /// <returns>Added entity</returns>
        Task<T> AddAsync(T entity);

        /// <summary>
        /// Save changes.
        /// </summary>
        void SaveChanges();

        /// <summary>
        /// Save changes asynchronously.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token</param>
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
