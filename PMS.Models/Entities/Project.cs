namespace PMS.Models.Entities;

/// <summary>
/// Reprezentacja modelu projektu.
/// </summary>
public class Project
{
    /// <summary>
    /// Identyfikator
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Nazwa
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Opis
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Lista indentyfikatorów zadań.
    /// </summary>
    public List<Guid> TaskIds { get; set; } 

    /// <summary>
    /// Priorytet
    /// </summary>
    public Priority Priority { get; set; }

    /// <summary>
    /// Czas utworzenia
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public Status Status { get; set; }

    /// <summary>
    /// Czas zakończenia
    /// </summary>
    public DateTime? CompletedAt { get; set; }

    /// <summary>
    /// Lista komentarzy
    /// </summary>
    public List<Comment> Comments { get; set; } 
}
