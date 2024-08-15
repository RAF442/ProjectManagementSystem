using PMS.Models.Entities;
using PMS.Repositories.Context;
using PMS.Repositories.DBOs;
using PMS.Repositories.GenericRepository;

namespace PMS.Repositories.Repositories.ProjectRepository;

internal class ProjectRepository : AbstractRepository<Project, ProjectDbo, Guid>, IProjectRepository
{
    public ProjectRepository(PMSDbContext context) : base(context)
    {
    }

    
}
