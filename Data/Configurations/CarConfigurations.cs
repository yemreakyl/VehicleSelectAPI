using Core.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
   public class CarConfigurations : IEntityTypeConfiguration<Car>
    {        
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();           
            builder.Property(x => x.Brand).IsRequired().HasMaxLength(50);
            builder.Property(x => x.HeadlightsState).IsRequired();
            builder.Property(x => x.Color).IsRequired().HasMaxLength(50);

        }
    }
}
