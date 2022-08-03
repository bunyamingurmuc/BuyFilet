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
    public class ProductImageConfiguration:IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            
            builder.HasData(new ProductImage[]
            {
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", Id=1, ProductId=1},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", Id=2, ProductId=1},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", Id=3, ProductId=1},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", Id=4, ProductId=1},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", Id=5, ProductId=1},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", Id=6, ProductId=1},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", Id=7, ProductId=1},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", Id=8, ProductId=1},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/54/550/11186104270898.jpg/format:webp", Id=9, ProductId=1},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=10, ProductId=1},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=11, ProductId=1},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=12, ProductId=2},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=13, ProductId=3},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=14, ProductId=4},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=15, ProductId=5},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=16, ProductId=6},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=17, ProductId=7},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=18, ProductId=8},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=19, ProductId=9},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=20, ProductId=10},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=21, ProductId=11},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=22, ProductId=12},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=23, ProductId=13},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=24, ProductId=14},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=25, ProductId=15},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=26, ProductId=16},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=27, ProductId=17},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=28, ProductId=18},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=29, ProductId=19},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=30, ProductId=20},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=31, ProductId=21},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=32, ProductId=22},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=33, ProductId=23},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=34, ProductId=24},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=35, ProductId=25},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=36, ProductId=26},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=37, ProductId=27},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=38, ProductId=28},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=39, ProductId=29},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=40, ProductId=30},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=41, ProductId=31},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=42, ProductId=32},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=43, ProductId=33},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=44, ProductId=34},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=45, ProductId=35},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=46, ProductId=36},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=47, ProductId=37},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=48, ProductId=38},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=49, ProductId=39},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/181/550/110000146174131.jpg/format:webp", Id=50, ProductId=40},

               
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=51, ProductId=1},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=52, ProductId=2},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=53, ProductId=3},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=54, ProductId=4},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=55, ProductId=5},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=56, ProductId=6},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=57, ProductId=7},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=58, ProductId=8},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=59, ProductId=9},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=60, ProductId=10},

                          
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=61, ProductId=1},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=62, ProductId=2},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=63, ProductId=3},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=64, ProductId=4},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=65, ProductId=5},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=66, ProductId=6},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=67, ProductId=7},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=68, ProductId=8},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=69, ProductId=9},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=70, ProductId=10}
                ,
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=71, ProductId=11},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=72, ProductId=12},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=73, ProductId=13},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=74, ProductId=14},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=75, ProductId=15},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=76, ProductId=16},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=77, ProductId=17},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=78, ProductId=18},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=79, ProductId=19},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=80, ProductId=20},

                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=81, ProductId=21},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=82, ProductId=22},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=83, ProductId=23},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=84, ProductId=24},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=85, ProductId=25},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=86, ProductId=26},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=87, ProductId=27},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=88, ProductId=28},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=89, ProductId=29},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=90, ProductId=30},

                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=91, ProductId=31},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=92, ProductId=32},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=93, ProductId=33},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=94, ProductId=34},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=95, ProductId=35},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=96, ProductId=36},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=97, ProductId=37},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=98, ProductId=38},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=99, ProductId=39},
                new ProductImage(){ ImagePath = "https://productimages.hepsiburada.net/s/76/200-200/110000018213454.jpg", Id=100, ProductId=40},





            });
        }
    }
}
