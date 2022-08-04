using Core.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Seed
{
    public class BusSeed : IEntityTypeConfiguration<Bus>
    {
        public void Configure(EntityTypeBuilder<Bus> builder)
        {
            builder.HasData(
            new Bus { Id = 1, Color = "Red", Capasity=100, Length=11},
            new Bus { Id = 2, Color = "Red", Capasity = 80, Length = 12 },
            new Bus { Id = 3, Color = "White", Capasity = 60, Length = 10 },
            new Bus { Id = 4, Color = "White", Capasity = 100, Length = 13 },
            new Bus { Id = 5, Color = "White", Capasity = 75, Length = 11 },
            new Bus { Id = 6, Color = "Black", Capasity = 90, Length = 12 },
            new Bus { Id = 7, Color = "Black", Capasity = 85, Length = 12 },
            new Bus { Id = 8, Color = "Blue", Capasity = 69, Length = 9}
    );
        }
    }
}
