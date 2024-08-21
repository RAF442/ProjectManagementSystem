using Microsoft.EntityFrameworkCore;
using PMS.Repositories.DBOs.Converts;

namespace PMS.Repositories.GenericRepository;

/// <summary>
/// Zbiór operacji ogólnych na wszystkich repozytoriach.
/// </summary>
/// <typeparam name="TEntity">Parametr generyczny encji.</typeparam>
/// <typeparam name="TDbo">Parametr generyczny obiektu Dbo.</typeparam>
/// <typeparam name="TId">Parametr generyczny id.</typeparam>
public abstract class AbstractRepository<TEntity, TDbo, TId> : IAbstractRepository<TEntity, TId> where TEntity : class where TDbo : class
{
    private readonly DbContext dbContext;
    private readonly DbSet<TDbo> dbSet;
    private readonly IDboConverter dboConverter;

    protected AbstractRepository(DbSet<TDbo> dbSet, DbContext dbContext, IDboConverter dboConverter)
    {
        this.dbContext = dbContext;
        this.dbSet = dbSet;
        this.dboConverter = dboConverter;
    }

    public async Task<TEntity> GetByIdAsync(TId id)
    {
        var dbo = await dbSet.FindAsync(id);
        return dboConverter.Convert<TEntity>(dbo);
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        var result = await dbSet.ToListAsync();
        var convertedResult = result.Select(dbo => dboConverter.Convert<TEntity>(dbo));
        return convertedResult;
    }

    public async Task AddAsync(TEntity entity)
    {
        var dbo = dboConverter.Convert<TDbo>(entity);
        await dbSet.AddAsync(dbo);
        await dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(TEntity entity)
    {
        var dbo = dboConverter.Convert<TDbo>(entity);
        dbSet.Update(dbo);
        await dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(TId id)
    {
        var dbo = await dbSet.FindAsync(id);
        if (dbo != null)
        {
            dbSet.Remove(dbo);
            await dbContext.SaveChangesAsync();
        }
    }
}
