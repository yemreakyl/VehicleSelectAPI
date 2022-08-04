using Core.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class BusConfigurations : IEntityTypeConfiguration<Bus>
    {
        public void Configure(EntityTypeBuilder<Bus> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Capasity).IsRequired();
            builder.Property(x => x.Color).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Length).IsRequired() ;
        }
    }
}
