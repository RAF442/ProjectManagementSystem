using Microsoft.EntityFrameworkCore;
using PMS.Models.Entities;
using PMS.Repositories.DBOs;
using System.Reflection.Emit;

namespace PMS.Repositories.Context;

/// <summary>
/// Klasa kontekstu reprezentująca połączenie z bazą danych
/// </summary>
public class PMSDbContext : DbContext
{
    public PMSDbContext(DbContextOptions<PMSDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("PMS");
    }

    /// <summary>
    /// Właściwość DbSet dla modelu ProjectDbo
    /// </summary>
    public DbSet<ProjectDbo> Projects { get; set; }

    /// <summary>
    /// Właściwość DbSet dla modelu AssignmentDbo
    /// </summary>
    public DbSet<AssignmentDbo> Assignments { get; set; }

    /// <summary>
    /// Właściwość DbSet dla modelu PersonDbo
    /// </summary>
    public DbSet<PersonDbo> Persons { get; set; }

    /// <summary>
    /// Właściwość DbSet dla modelu CommentDbo
    /// </summary>
    public DbSet<CommentDbo> Comments { get; set; }
}
