namespace PMS.Models.Entities;

/// <summary>
/// Reprezentacja modelu projektu.
/// </summary>
public class Project
{
    /// <summary>
    /// Identyfikator projektu.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Nazwa projektu.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Opis projektu.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Lista indentyfikatorów zadań.
    /// </summary>
    public List<Guid> TaskIds { get; set; } 

    /// <summary>
    /// Priorytet projektu.
    /// </summary>
    public Priority Priority { get; set; }

    /// <summary>
    /// Czas utworzenia projektu.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Status projektu.
    /// </summary>
    public Status Status { get; set; }

    /// <summary>
    /// Czas zakończenia projektu.
    /// </summary>
    public DateTime? CompletedAt { get; set; }

    /// <summary>
    /// Lista komentarzy do projektu.
    /// </summary>
    public List<Comment> Comments { get; set; } 
}
