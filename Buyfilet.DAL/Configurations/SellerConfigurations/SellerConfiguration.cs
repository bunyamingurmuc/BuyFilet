using Buyfilet.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buyfilet.DAL.Configurations.SellerConfigurations
{
    public class SellerConfiguration:IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.Surname).IsRequired();
            builder.Property(x => x.Surname).HasMaxLength(50);
            builder.Property(x => x.Address).IsRequired();
            builder.Property(x => x.Address).HasMaxLength(200);
            builder.Property(x => x.TcNo).IsRequired();
            builder.Property(x => x.TcNo).HasMaxLength(11);
            
            builder.HasData(new Seller[]
            {
                new Seller(){Id = 1, Address = "deneme deneme deneme deneme deneme deneme " ,IsApproved = false,Name = "deneme deneme ", Surname  = "deneme ",TcNo =26588331534, Logo = "https://logos-world.net/wp-content/uploads/2020/04/Huawei-Logo.png", },
                new Seller(){Id = 2, Address = "deneme deneme deneme deneme deneme deneme " ,IsApproved = true,Name = "deneme deneme ", Surname  = "deneme ",TcNo =26588331534, Logo = "https://logos-world.net/wp-content/uploads/2020/04/Huawei-Logo.png", },
                new Seller(){Id = 3, Address = "deneme deneme deneme deneme deneme deneme " ,IsApproved = false,Name = "deneme deneme ", Surname  = "deneme ",TcNo =26588331534, Logo = "https://logos-world.net/wp-content/uploads/2020/04/Huawei-Logo.png", },
                new Seller(){Id = 4, Address = "deneme deneme deneme deneme deneme deneme " ,IsApproved = true,Name = "deneme deneme ", Surname  = "deneme ",TcNo =26588331534, Logo = "https://logos-world.net/wp-content/uploads/2020/04/Huawei-Logo.png", },
            });
        }
    }
}
