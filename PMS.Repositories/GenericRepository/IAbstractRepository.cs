namespace PMS.Repositories.GenericRepository;

/// <summary>
/// Zbiór operacji wykonywanych na repozytorium generycznym.
/// </summary>
/// <typeparam name="TEntity">Parametr generyczny encji.</typeparam>
/// <typeparam name="TId">Parametr generyczny id.</typeparam>
public interface IAbstractRepository<TEntity, TId> 
{
    /// <summary>
    /// Metoda pobierająca wszystkie wystąpienia danej encji.
    /// </summary>
    /// <returns>Zwraca kolekcję encji.</returns>
    Task<IEnumerable<TEntity>> GetAllAsync();

    /// <summary>
    /// Metoda pobierająca encję po id.
    /// </summary>
    /// <param name="id">Identyfikator encji.</param>
    /// <returns>Encja</returns>
    Task<TEntity> GetByIdAsync(TId id);

    /// <summary>
    /// Metoda dodająca encję.
    /// </summary>
    /// <param name="entity">Encja</param>
    Task AddAsync(TEntity entity);

    /// <summary>
    /// Metoda aktualizująca encję.
    /// </summary>
    /// <param name="entity">Encja</param>
    Task UpdateAsync(TEntity entity);

    /// <summary>
    /// Metoda usuwająca encję.
    /// </summary>
    /// <param name="id">Identyfikator encji.</param>
    Task DeleteAsync(TId id);
}
