namespace PMS.Models.Entities;

/// <summary>
/// Reprezentacja modelu komentarza.
/// </summary>
public class Comment
{
    /// <summary>
    /// Identyfikator
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Treść
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Czas utworzenia
    /// </summary>
    public DateTime CreatedAt { get; set; }
}
