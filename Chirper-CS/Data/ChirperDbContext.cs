using Chirper_CS.DTO;
using Chirper_CS.EntityConfigurations;
using Chirper_CS.Models;
using Chirper_CS.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Chirper_CS.Data
{
    public class ChirperDbContext  : DbContext
    {
        public ChirperDbContext(DbContextOptions<ChirperDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*base.OnModelCreating(modelBuilder);*/

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ChirpConfiguration).Assembly);

            modelBuilder.Entity<User>().HasData(new UserSeeder().Generate());
            modelBuilder.Entity<Chirp>().HasData(new ChirpSeeder().Generate());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Chirp> Chirps { get; set; }
    }
}
