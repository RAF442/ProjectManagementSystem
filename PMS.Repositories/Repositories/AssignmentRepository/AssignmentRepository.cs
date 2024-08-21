using PMS.Models.Entities;
using PMS.Repositories.Context;
using PMS.Repositories.DBOs;
using PMS.Repositories.DBOs.Converts;
using PMS.Repositories.GenericRepository;
using PMS.Repositories.Repositories.ProjectRepository;

namespace PMS.Repositories.Repositories.AssignmentRepository;

public class AssignmentRepository : AbstractRepository<Assignment, AssignmentDbo, Guid>, IAssignmentRepository
{
    public AssignmentRepository(PMSDbContext context, IDboConverter converter) : base(context.Assignments, context, converter)
    {
    }
}
