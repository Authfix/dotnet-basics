using Microsoft.EntityFrameworkCore;

namespace EfCore.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public DbSet<Classroom> Classrooms { get; init; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        
        optionsBuilder.UseInMemoryDatabase("MyApp");
    }
}