using Core.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seed
{
    public class CarSeed : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {

         builder.HasData(
         new Car { Id = 1, Brand = "Wolksvagen", HeadlightsState = true, Model = 2018, Color= "Red"},
         new Car { Id = 2, Brand = "Ford", HeadlightsState = true, Model = 2017, Color = "Red" },
         new Car { Id = 3, Brand = "Renault", HeadlightsState = false, Model = 2014, Color = "White" },
         new Car { Id = 4, Brand = "Wolksvagen", HeadlightsState = true, Model = 2020, Color= "Blue" },
         new Car { Id = 5, Brand = "Jaguar", HeadlightsState = false, Model = 2018, Color = "White" },
         new Car { Id = 6, Brand = "Ferrari", HeadlightsState = true, Model = 2019, Color = "Black" },
         new Car { Id = 7, Brand = "Skoda", HeadlightsState = false, Model = 2022, Color = "Black" },
         new Car { Id = 8, Brand = "AlfaRomeo", HeadlightsState = true, Model = 2021, Color = "Blue" }
             );

        }
    }
}
