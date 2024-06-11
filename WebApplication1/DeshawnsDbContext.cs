using Microsoft.EntityFrameworkCore;
using Deshawns.Models;

public class DeshawnsDbContext : DbContext
{

    public DbSet<User> User { get; set; }

    public DeshawnsDbContext(DbContextOptions<DeshawnsDbContext> context) : base(context)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(new User[]
        {
            new User {Id = 1, FirstName = "Alice", LastName = "Johnson",  CreatedAt = new DateTime(2024, 6, 1), UpdatedAt = new DateTime(2024, 6, 2)},
            new User {Id = 2, FirstName = "Bob", LastName = "Smith",  CreatedAt = new DateTime(2024, 6, 2), UpdatedAt = new DateTime(2024, 6, 3)},

        });
    }
}