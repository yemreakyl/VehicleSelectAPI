using Core.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class BoatConfigurations : IEntityTypeConfiguration<Boat>
    { 
        public void Configure(EntityTypeBuilder<Boat> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Material).IsRequired();
            builder.Property(x => x.Length).IsRequired();
            builder.Property(x => x.Sail).IsRequired();
            builder.Property(x => x.Color).IsRequired().HasMaxLength(50);
        }
    }
}
