namespace Domain.Entities.ModelEF.Interfaces
{
    /// <summary>
    /// Entity interface with id
    /// </summary>
    /// <typeparam name="TId">Identifier type</typeparam>
    public interface IEntity<TId>
    {
        /// <summary>
        /// Identifier
        /// </summary>
        TId Id { get; set; }
    }
}
