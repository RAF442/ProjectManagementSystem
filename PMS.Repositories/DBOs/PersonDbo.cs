namespace PMS.Repositories.DBOs;

/// <summary>
/// Reprezentacja osoby w bazie danych.
/// </summary>
public class PersonDbo
{
    /// <summary>
    /// Identyfikator osoby.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Imię osoby.
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Nazwisko osoby.
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Email osoby.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Numer telefonu osoby.
    /// </summary>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Stanowisko osoby.
    /// </summary>
    public string Position { get; set; }
}
