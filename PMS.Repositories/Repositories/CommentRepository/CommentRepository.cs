using PMS.Models.Entities;
using PMS.Repositories.Context;
using PMS.Repositories.DBOs;
using PMS.Repositories.DBOs.Converts;
using PMS.Repositories.GenericRepository;

namespace PMS.Repositories.Repositories.CommentRepository;

public class CommentRepository : AbstractRepository<Comment, CommentDbo, Guid>, ICommentRepository
{
    public CommentRepository(PMSDbContext context, IDboConverter converter) : base(context.Comments, context, converter)
    {
    }
}
