using Microsoft.EntityFrameworkCore;
using PMS.Models.Entities;
using System.Reflection.Emit;

namespace PMS.Repositories.Context;

public class PMSDbContext : DbContext
{
    public PMSDbContext(DbContextOptions<PMSDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("PMS");
    }

    public DbSet<Project> Projects { get; set; }
    public DbSet<Assignment> Assignments { get; set; }
    public DbSet<Person> People { get; set; }
    public DbSet<Comment> Comments { get; set; }
}
