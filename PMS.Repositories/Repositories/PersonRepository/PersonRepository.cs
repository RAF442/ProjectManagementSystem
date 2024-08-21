using PMS.Models.Entities;
using PMS.Repositories.Context;
using PMS.Repositories.DBOs;
using PMS.Repositories.DBOs.Converts;
using PMS.Repositories.GenericRepository;

namespace PMS.Repositories.Repositories.PersonRepository;

public class PersonRepository : AbstractRepository<Person, PersonDbo, Guid>, IPersonRepository
{
    public PersonRepository(PMSDbContext context, IDboConverter converter) : base(context.Persons, context, converter)
    {
    }
}
