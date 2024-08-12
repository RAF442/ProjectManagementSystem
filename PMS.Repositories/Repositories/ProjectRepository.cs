using Microsoft.EntityFrameworkCore;
using PMS.Repositories.Context;
using PMS.Repositories.DBOs;
using PMS.Repositories.GenericRepository;

namespace PMS.Repositories.Repositories;

internal class ProjectRepository : IRepository<ProjectDbo>
{
    private readonly PMSDbContext _context;
    private readonly DbSet<ProjectDbo> _dbSet;

    public ProjectRepository(PMSDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<ProjectDbo>();
    }

    public async Task AddAsync(ProjectDbo entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<ProjectDbo>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<ProjectDbo> GetByIdAsync(Guid id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task UpdateAsync(ProjectDbo entity)
    {
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }
}
