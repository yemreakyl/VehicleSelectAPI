using Core.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Seed
{
    public class BoatSeed : IEntityTypeConfiguration<Boat>
    {
        public void Configure(EntityTypeBuilder<Boat> builder)
        {
            builder.HasData(
           new Boat { Id = 1, Color = "Red", Material="İron", Length = 11, Sail=false },
           new Boat { Id = 2, Color = "Red", Material = "Steel", Length = 12, Sail = false },
           new Boat { Id = 3, Color = "White", Material = "Wooden", Length = 10, Sail = true},
           new Boat { Id = 4, Color = "White", Material = "Carbon", Length = 13, Sail = true },
           new Boat { Id = 5, Color = "White", Material = "Wooden", Length = 11 , Sail = true },
           new Boat { Id = 6, Color = "Black", Material = "İron", Length = 12 , Sail = false },
           new Boat { Id = 7, Color = "Black", Material = "Steel", Length = 12 , Sail = false },
           new Boat { Id = 8, Color = "Blue", Material = "İron", Length = 9 , Sail = false }
   );
        }
    }
}
