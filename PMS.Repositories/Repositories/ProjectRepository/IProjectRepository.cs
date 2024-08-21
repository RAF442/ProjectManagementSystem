using PMS.Models.Entities;
using PMS.Repositories.DBOs;
using PMS.Repositories.GenericRepository;

namespace PMS.Repositories.Repositories.ProjectRepository;

/// <summary>
/// Zbiór akcji wykonywanych na repozytorium projektu.
/// </summary>
public interface IProjectRepository : IAbstractRepository<Project, Guid>
{
    
}
