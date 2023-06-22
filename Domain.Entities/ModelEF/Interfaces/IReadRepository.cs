namespace Domain.Entities.ModelEF.Interfaces
{
    /// <summary>
    /// Readable Repository Interface.
    /// </summary>
    /// <typeparam name="T">Entity type for the repository</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type</typeparam>
    public interface IReadRepository<T, TPrimaryKey> : IRepository where T : IEntity<TPrimaryKey>
    {
        /// <summary>
        /// Query all entities in the database.
        /// </summary>
        /// <param name="noTracking">Call with NoTracking</param>
        /// <returns>List of entities</returns>
        IQueryable<T> GetAll(bool noTracking = false);

        /// <summary>
        /// Query all entities in the database asynchronously.
        /// </summary>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <param name="noTracking">Call with NoTracking</param>
        /// <returns>List of entities</returns>
        Task<List<T>> GetAllAsync(CancellationToken cancellationToken, bool noTracking = false);

        /// <summary>
        /// Get entity by id.
        /// </summary>
        /// <param name="id">Entity id</param>
        /// <returns>Entity</returns>
        T Get(TPrimaryKey id);

        /// <summary>
        /// Get entity by id asynchronously.
        /// </summary>
        /// <param name="id">Entity id</param>
        /// <returns>Entity</returns>
        Task<T> GetAsync(TPrimaryKey id);
    }
}
