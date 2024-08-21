using PMS.Models.Entities;
using PMS.Repositories.Context;
using PMS.Repositories.DBOs;
using PMS.Repositories.DBOs.Converts;
using PMS.Repositories.GenericRepository;

namespace PMS.Repositories.Repositories.ProjectRepository;

public class ProjectRepository : AbstractRepository<Project, ProjectDbo, Guid>, IProjectRepository
{
    public ProjectRepository(PMSDbContext context, IDboConverter converter) : base(context.Projects, context, converter)
    {
    }
}
