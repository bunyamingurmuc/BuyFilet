using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buyfilet.DAL.Configurations.CategoryConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Definition).IsRequired();
            builder.HasData(new Category[]
            {
                new Category() {NumberOfSales=1111,  Id = 1, Definition= "Elektronik"},
                new Category() {NumberOfSales=1222,  Id = 2,Definition = "Giyim"},
                new Category() {NumberOfSales=1333,  Id = 3,Definition = "Moda"},
                new Category() {NumberOfSales=1444,  Id = 4,Definition = "Ev, Yaşam, Kırtasiye, Ofis"},
                new Category() {NumberOfSales=1555,  Id = 5,Definition = "Beyaz Eşya"},
                new Category() {NumberOfSales=1666,  Id = 6,Definition = "Oto, Bahçe, Yapı Market"},
                new Category() {NumberOfSales=1777,  Id = 7,Definition = "Anne, Bebek, Oyuncak"},
                new Category() {NumberOfSales=1888,  Id = 8,Definition = "Spor, Outdoor"},
                new Category() {NumberOfSales=1999,  Id = 9,Definition = "Kozmetik, Kişisel Bakım"},
                new Category() {NumberOfSales=11110,  Id = 10,Definition = "Süpermarket, Pet Shop"},    
            });
        }
    }
}
