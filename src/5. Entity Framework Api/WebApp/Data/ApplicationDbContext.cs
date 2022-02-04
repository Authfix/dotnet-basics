using Microsoft.EntityFrameworkCore;

namespace EfApi.WebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Weather> Weathers { get; init; }

        public DbSet<City> Cities { get; init; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Weather>().HasOne(w => w.City).WithMany().HasForeignKey(w => w.CityId);
        }
    }
}
