namespace PMS.Repositories.DBOs;

public class CommentDbo
{
    public Guid Id { get; set; }
    public string Text { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
