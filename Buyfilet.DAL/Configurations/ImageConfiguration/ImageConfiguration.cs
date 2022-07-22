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
                new Image(){Id=10, ImagePath="https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15461619354815_Adidas.png", CategoryId=10, },

            });
        }
    }
}
