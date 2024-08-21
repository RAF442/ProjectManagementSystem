using PMS.Models.Entities;
using PMS.Repositories.GenericRepository;

namespace PMS.Repositories.Repositories.AssignmentRepository;

/// <summary>
/// Zbiór akcji wykonywanych na repozytorium zadania.
/// </summary>
public interface IAssignmentRepository : IAbstractRepository<Assignment, Guid>
{

}
