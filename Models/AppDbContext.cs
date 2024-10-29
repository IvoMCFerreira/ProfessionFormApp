using Microsoft.EntityFrameworkCore;
using PersonProfessionApp.Models;

namespace ProfessionFormApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Person> People { get; set; }
        public DbSet<Profession> Professions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasOne(p => p.Profession)
                .WithMany(p => p.People)
                .HasForeignKey(p => p.ProfessionId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
