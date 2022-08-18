using Buyfilet.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buyfilet.DAL.Configurations.ImageConfiguration
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
       
            builder.HasData(new Image[]
            {
                new Image(){Id = 1, ImagePath="https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", CategoryId=1, },
                new Image(){Id = 2, ImagePath="https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", CategoryId=2, },
                new Image(){Id = 3, ImagePath="https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", CategoryId=3, },
                new Image(){Id = 4, ImagePath="https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", CategoryId=4, },
                new Image(){Id = 5, ImagePath="https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", CategoryId=5, },
                new Image(){Id = 6, ImagePath="https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", CategoryId=6, },
                new Image(){Id = 7, ImagePath="https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", CategoryId=7, },
                new Image(){Id = 8, ImagePath="https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", CategoryId=8, },
                new Image(){Id = 9, ImagePath="https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", CategoryId=9, },
                new Image(){Id = 10, ImagePath="https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", CategoryId=10, },
              
                new Image(){Id=11,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=1},
                new Image(){Id=12,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=1},
                new Image(){Id=13,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=2},
                new Image(){Id=14,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=2},
                new Image(){Id=15,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=3},
                new Image(){Id=16,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=3},
                new Image(){Id=17,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=4},
                new Image(){Id=18,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=4},
                new Image(){Id=19,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=5},
                new Image(){Id=20,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=5},

                new Image(){Id=21,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=1},
                new Image(){Id=22,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=2},
                new Image(){Id=23,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=3},
                new Image(){Id=24,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=4},
                new Image(){Id=25,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=5},
                new Image(){Id=26,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=6},
                new Image(){Id=27,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=7},
                new Image(){Id=28,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=8},
                new Image(){Id=29,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=9},
                new Image(){Id=30,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=10},

                new Image(){Id=31,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=11},
                new Image(){Id=32,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=12},
                new Image(){Id=33,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=13},
                new Image(){Id=34,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=14},
                new Image(){Id=35,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=15},
                new Image(){Id=36,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=16},
                new Image(){Id=37,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=17},
                new Image(){Id=38,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=18},
                new Image(){Id=39,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=19},
                new Image(){Id=40,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=20},

                new Image(){Id=41,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=11},
                new Image(){Id=42,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=12},
                new Image(){Id=43,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=13},
                new Image(){Id=44,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=14},
                new Image(){Id=45,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=15},
                new Image(){Id=46,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=16},
                new Image(){Id=47,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=17},
                new Image(){Id=48,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=18},
                new Image(){Id=49,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=19},
                new Image(){Id=50,ImagePath="https://upload.wikimedia.org/wikipedia/commons/9/95/SunLou2.jpg", CommentId=20},

            });
        }
    }
}
