using System.Xml.Schema;

namespace PMS.Models.Entities;

/// <summary>
/// Reprezentacja modelu osoby.
/// </summary>
public class Person
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
