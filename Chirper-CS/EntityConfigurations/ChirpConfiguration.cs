using Chirper_CS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Chirper_CS.EntityConfigurations
{
    public class ChirpConfiguration : IEntityTypeConfiguration<Chirp>
    {
        public void Configure(EntityTypeBuilder<Chirp> builder)
        {
            builder.HasKey(c => c.ChirpId);
            builder.Property(c => c.Message).IsRequired();
            builder.Property(c => c.UserId).IsRequired();
            builder.HasOne(c => c.User)
                .WithMany(u => u.Chirps)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
