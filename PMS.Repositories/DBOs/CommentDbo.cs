namespace PMS.Repositories.DBOs;

/// <summary>
/// Reprezentacja komentarza w bazie danych.
/// </summary>
public class CommentDbo
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
