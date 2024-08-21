namespace PMS.Repositories.DBOs;

/// <summary>
/// Reprezentacja komentarza w bazie danych.
/// </summary>
public class CommentDbo
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
