namespace PMS.Models.Entities;

/// <summary>
/// Reprezentacja modelu komentarza.
/// </summary>
public class Comment
{
    /// <summary>
    /// Identyfikator komentarza.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Treść komentarza.
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Czas utworzenia komentarza.
    /// </summary>
    public DateTime CreatedAt { get; set; }
}
