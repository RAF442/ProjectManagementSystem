using PMS.Models.Entities;
using PMS.Repositories.GenericRepository;

namespace PMS.Repositories.Repositories.CommentRepository;

/// <summary>
/// Zbiór akcji wykonywanych na repozytorium komentarza.
/// </summary>
public interface ICommentRepository : IAbstractRepository<Comment, Guid>
{
}
