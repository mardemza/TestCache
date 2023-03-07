using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestCache.Domain;

namespace TestCache.EntityFrameworkCore
{
    public class PlayerConfig : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.ToTable("PLAYERS");
            builder.HasKey(x => x.Id);
        }
    }
}