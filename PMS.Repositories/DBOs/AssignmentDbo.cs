using PMS.Models.Entities;

namespace PMS.Repositories.DBOs;

/// <summary>
/// Reprezentacja zadania w bazie danych.
/// </summary>
public class AssignmentDbo
{
    /// <summary>
    /// Identyfikator zadania.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Nazwa zadania.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Opis zadania.
    /// </summary>
    public string Description { get; set; }


    /// <summary>
    /// Osoby przypisane do zadania.
    /// </summary>
    public ICollection<Person> People { get; set; }

    /// <summary>
    /// Priorytet zadania.
    /// </summary>
    public Priority Priority { get; set; }

    /// <summary>
    /// Czas utworzenia zadania.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Status zadania.
    /// </summary>
    public Status Status { get; set; }

    /// <summary>
    /// Czas zakończenia zadania.
    /// </summary>
    public DateTime? CompletedAt { get; set; }

    /// <summary>
    /// Lista komentarzy do zadania.
    /// </summary>
    public List<Comment> Comments { get; set; }
}
