using Microsoft.EntityFrameworkCore;

namespace Chirper_CS.Data
{
    public class ChirperDbContext  : DbContext
    {
        public ChirperDbContext(DbContextOptions<ChirperDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
