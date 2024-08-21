using System.Xml.Schema;

namespace PMS.Models.Entities;

/// <summary>
/// Reprezentacja modelu osoby.
/// </summary>
public class Person
{
    /// <summary>
    /// Identyfikator
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Imię
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Nazwisko
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Numer telefonu
    /// </summary>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Stanowisko
    /// </summary>
    public string Position { get; set; }
}
