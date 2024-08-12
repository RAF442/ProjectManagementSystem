using PMS.Models.Entities;

namespace PMS.Repositories.DBOs;

public class ProjectDbo
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Guid> TaskIds { get; set; } = new List<Guid>();
    public Priority Priority { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public Status Status { get; set; } = Status.NotStarted;
    public DateTime? CompletedAt { get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>();
}
