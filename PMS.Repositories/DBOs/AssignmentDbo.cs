using PMS.Models.Entities;

namespace PMS.Repositories.DBOs;

/// <summary>
/// Reprezentacja zadania w bazie danych.
/// </summary>
public class AssignmentDbo
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
    /// Osoby przypisane do zadania.
    /// </summary>
    public ICollection<Person> People { get; set; }

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
    /// Lista komentarzy.
    /// </summary>
    public List<Comment> Comments { get; set; }
}
