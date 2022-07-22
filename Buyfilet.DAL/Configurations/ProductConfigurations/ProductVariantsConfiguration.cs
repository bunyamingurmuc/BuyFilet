using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.Entities.ProductEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buyfilet.DAL.Configurations.ProductConfigurations
{
    public class ProductVariantsConfiguration : IEntityTypeConfiguration<ProductVariants>
    {
        public void Configure(EntityTypeBuilder<ProductVariants> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Definition).HasMaxLength(50).IsRequired();
            builder.HasData(new ProductVariants[]
            {
                new ProductVariants() {Price=10001 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 1,ProductId = 1},
                new ProductVariants() {Price=10002 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 2,ProductId = 2},
                new ProductVariants() {Price=10003 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 3,ProductId = 3},
                new ProductVariants() {Price=10004 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 4,ProductId = 4},
                new ProductVariants() {Price=10005 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 5,ProductId = 5},
                new ProductVariants() {Price=10006 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 6,ProductId = 6},
                new ProductVariants() {Price=10007 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 7,ProductId = 7},
                new ProductVariants() {Price=10008 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 8,ProductId = 8},
                new ProductVariants() {Price=10009 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 9,ProductId = 9},

                new ProductVariants() {Price=100010 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 10,ProductId = 10},
                new ProductVariants() {Price=100011 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 11,ProductId = 11},
                new ProductVariants() {Price=100012 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 12,ProductId = 12},
                new ProductVariants() {Price=100013 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 13,ProductId = 13},
                new ProductVariants() {Price=100014 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 14,ProductId = 14},
                new ProductVariants() {Price=100015 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 15,ProductId = 15},
                new ProductVariants() {Price=100016 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 16,ProductId = 16},
                new ProductVariants() {Price=100017 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 17,ProductId = 17},
                new ProductVariants() {Price=100018 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 18,ProductId = 18},
                new ProductVariants() {Price=100019 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 19,ProductId = 19},
                new ProductVariants() {Price=100020 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 20,ProductId = 20},

                new ProductVariants() {Price=10021 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 21,ProductId = 21},
                new ProductVariants() {Price=10022 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 22,ProductId = 22},
                new ProductVariants() {Price=10023 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 23,ProductId = 23},
                new ProductVariants() {Price=10024 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 24,ProductId = 24},
                new ProductVariants() {Price=10025 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 25,ProductId = 25},
                new ProductVariants() {Price=10026 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 26,ProductId = 26},
                new ProductVariants() {Price=10027 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 27,ProductId = 27},
                new ProductVariants() {Price=10028 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 28,ProductId = 28},
                new ProductVariants() {Price=10029 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 29,ProductId = 29},
                new ProductVariants() {Price=10030 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 30,ProductId = 30},

                new ProductVariants() {Price=1310 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 31,ProductId = 31},
                new ProductVariants() {Price=1320 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 32,ProductId = 32},
                new ProductVariants() {Price=1330 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 33,ProductId = 33},
                new ProductVariants() {Price=1340 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 34,ProductId = 34},
                new ProductVariants() {Price=1350 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 35,ProductId = 35},
                new ProductVariants() {Price=1360 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 36,ProductId = 36},
                new ProductVariants() {Price=1370 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 37,ProductId = 37},
                new ProductVariants() {Price=1380 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 38,ProductId = 38},
                new ProductVariants() {Price=1390 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 39,ProductId = 39},
                new ProductVariants() {Price=1400 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 40,ProductId = 40},



                new ProductVariants() {Price=1050 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 50,ProductId = 30},
                new ProductVariants() {Price=1050 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 51,ProductId = 1},
                new ProductVariants() {Price=1050 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 52,ProductId = 2},
                new ProductVariants() {Price=1050 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 53,ProductId = 3},
                new ProductVariants() {Price=1050 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 54,ProductId = 4},
                new ProductVariants() {Price=1050 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 55,ProductId = 5},
                new ProductVariants() {Price=1050 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 56,ProductId = 6},
                new ProductVariants() {Price=1050 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 57,ProductId = 7},
                new ProductVariants() {Price=1050 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 58,ProductId = 8},
                new ProductVariants() {Price=1050 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 59,ProductId = 9},

                new ProductVariants() {Price=6000 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 60,ProductId = 10},
                new ProductVariants() {Price=6100 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 61,ProductId = 11},
                new ProductVariants() {Price=6200 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 62,ProductId = 12},
                new ProductVariants() {Price=6300 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 63,ProductId = 13},
                new ProductVariants() {Price=6400 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 64,ProductId = 14},
                new ProductVariants() {Price=6500 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 65,ProductId = 15},
                new ProductVariants() {Price=6600 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 66,ProductId = 16},
                new ProductVariants() {Price=6700 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 67,ProductId = 17},
                new ProductVariants() {Price=6800 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 68,ProductId = 18},
                new ProductVariants() {Price=6900 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 69,ProductId = 19},

                new ProductVariants() {Price=700 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 70,ProductId = 20},
                new ProductVariants() {Price=710 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 71,ProductId = 21},
                new ProductVariants() {Price=720 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 72,ProductId = 22},
                new ProductVariants() {Price=730 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 73,ProductId = 23},
                new ProductVariants() {Price=740 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 74,ProductId = 24},
                new ProductVariants() {Price=750 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 75,ProductId = 25},
                new ProductVariants() {Price=760 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 76,ProductId = 26},
                new ProductVariants() {Price=770 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 77,ProductId = 27},
                new ProductVariants() {Price=780 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 78,ProductId = 28},
                new ProductVariants() {Price=790 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 79,ProductId = 29},

                new ProductVariants() {Price=1088 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 80,ProductId = 30},
                new ProductVariants() {Price=1188 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 81,ProductId = 31},
                new ProductVariants() {Price=1288 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 82,ProductId = 32},
                new ProductVariants() {Price=1388 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 83,ProductId = 33},
                new ProductVariants() {Price=1488 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 84,ProductId = 34},
                new ProductVariants() {Price=1588 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 85,ProductId = 35},
                new ProductVariants() {Price=1688 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 86,ProductId = 36},
                new ProductVariants() {Price=1788 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 87,ProductId = 37},
                new ProductVariants() {Price=1888 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 88,ProductId = 38},
                new ProductVariants() {Price=1988 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 89,ProductId = 39},

                new ProductVariants() {Price=1009 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 90,ProductId = 30},
                new ProductVariants() {Price=1009 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 91,ProductId = 1},
                new ProductVariants() {Price=1009 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 92,ProductId = 2},
                new ProductVariants() {Price=1009 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 93,ProductId = 3},
                new ProductVariants() {Price=1009 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 94,ProductId = 4},
                new ProductVariants() {Price=1009 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 95,ProductId = 5},
                new ProductVariants() {Price=1009 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 96,ProductId = 6},
                new ProductVariants() {Price=1009 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 97,ProductId = 7},
                new ProductVariants() {Price=1009 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 98,ProductId = 8},
                new ProductVariants() {Price=1009 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 99,ProductId = 9},

                new ProductVariants() {Price=10010 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 100,ProductId = 10},
                new ProductVariants() {Price=10011 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 111,ProductId = 11},
                new ProductVariants() {Price=10012 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 122,ProductId = 12},
                new ProductVariants() {Price=10013 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 133,ProductId = 13},
                new ProductVariants() {Price=10014 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 144,ProductId = 14},
                new ProductVariants() {Price=10015 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 155,ProductId = 15},
                new ProductVariants() {Price=10016 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 166,ProductId = 16},
                new ProductVariants() {Price=10017 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 177,ProductId = 17},
                new ProductVariants() {Price=10018 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 188,ProductId = 18},
                new ProductVariants() {Price=10019 ,WithOutDiscount=50000, Name = "Hafıza", Definition = "64 GB",Id = 199,ProductId = 19},








            });

        }
    }

}
