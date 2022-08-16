
using Buyfilet.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buyfilet.DAL.Configurations.ProductConfigurations
{
    public class VariantConfiguration : IEntityTypeConfiguration<Variant>
    {
        public void Configure(EntityTypeBuilder<Variant> builder)
        {
            builder.HasData(new Variant[]
            {
                new Variant(){ Id = 1,  ProductId=1, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 2,  ProductId=1, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 3,  ProductId=1, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 4,  ProductId=1, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 5,  ProductId=1, Name="Hafıza", Description="64GB", },

                new Variant(){ Id = 6,  ProductId=1, Name="Renk", Description="64GB", },
                new Variant(){ Id = 7,  ProductId=1, Name="Renk", Description="64GB", },
                new Variant(){ Id = 8,  ProductId=1, Name="Renk", Description="64GB", },
                new Variant(){ Id = 9,  ProductId=1, Name="Renk", Description="64GB", },
                new Variant(){ Id = 10, ProductId=1, Name="Renk", Description="64GB", },

                new Variant(){ Id = 11, ProductId=2, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 12, ProductId=2, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 13, ProductId=2, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 14, ProductId=2, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 15, ProductId=2, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 16, ProductId=2, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 17, ProductId=2, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 18, ProductId=2, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 19, ProductId=2, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 20, ProductId=3, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 21, ProductId=3, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 22, ProductId=3, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 23, ProductId=3, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 24, ProductId=3, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 25, ProductId=3, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 26, ProductId=3, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 27, ProductId=3, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 28, ProductId=3, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 29, ProductId=3, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 30, ProductId=4, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 31, ProductId=4, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 32, ProductId=4, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 33, ProductId=4, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 34, ProductId=4, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 35, ProductId=4, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 36, ProductId=4, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 37, ProductId=4, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 38, ProductId=4, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 39, ProductId=4, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 40, ProductId=5, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 41, ProductId=4, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 42, ProductId=4, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 43, ProductId=4, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 44, ProductId=4, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 45, ProductId=4, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 46, ProductId=4, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 47, ProductId=4, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 48, ProductId=4, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 49, ProductId=4, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 50, ProductId=5, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 51, ProductId=6, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 52, ProductId=6, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 53, ProductId=6, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 54, ProductId=6, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 55, ProductId=6, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 56, ProductId=6, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 57, ProductId=6, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 58, ProductId=6, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 59, ProductId=6, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 60, ProductId=7, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 61, ProductId=8, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 62, ProductId=8, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 63, ProductId=8, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 64, ProductId=8, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 65, ProductId=8, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 66, ProductId=8, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 67, ProductId=8, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 68, ProductId=8, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 69, ProductId=8, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 70, ProductId=8, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 71, ProductId=8, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 72, ProductId=8, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 73, ProductId=8, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 74, ProductId=8, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 75, ProductId=8, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 76, ProductId=8, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 77, ProductId=8, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 78, ProductId=8, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 79, ProductId=8, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 80, ProductId=9, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 81, ProductId=9, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 82, ProductId=9, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 83, ProductId=9, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 84, ProductId=9, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 85, ProductId=9, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 86, ProductId=9, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 87, ProductId=9, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 88, ProductId=9, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 89, ProductId=9, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 90, ProductId=9, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 91, ProductId=10, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 92, ProductId=10, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 93, ProductId=10, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 94, ProductId=10, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 95, ProductId=10, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 96, ProductId=10, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 97, ProductId=10, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 98, ProductId=10, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 99, ProductId=10, Name="Hafıza", Description="64GB", },
                new Variant(){ Id = 100,ProductId=10, Name="Hafıza", Description="64GB", },
            });
        }
    }
}
