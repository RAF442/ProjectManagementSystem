using PMS.Models.Entities;
using PMS.Repositories.GenericRepository;

namespace PMS.Repositories.Repositories.PersonRepository;

/// <summary>
/// Zbiór akcji wykonywanych na repozytorium osoby.
/// </summary>
public interface IPersonRepository : IAbstractRepository<Person, Guid>
{
}
