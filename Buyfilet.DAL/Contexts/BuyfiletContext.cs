using Buyfilet.DAL.Configurations.CategoryConfigurations;
using Buyfilet.DAL.Configurations.CommentCongigurations;
using Buyfilet.DAL.Configurations.ImageConfiguration;
using Buyfilet.DAL.Configurations.ProductConfigurations;
using Buyfilet.DAL.Configurations.SellerConfigurations;
using Buyfilet.DAL.Configurations.UserConfigurations;
using Buyfilet.Entities;
using Buyfilet.Entities.Comment;
using Buyfilet.Entities.ProductEntities;
using Buyfilet.Entities.Seller;
using Microsoft.EntityFrameworkCore;



namespace Buyfilet.DAL.Contexts
{
    public class BuyfiletContext:DbContext
    {
        public BuyfiletContext(DbContextOptions<BuyfiletContext> options):base(options)
        {
        }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Variant>? Variants{ get; set; }
        public DbSet<ProductImage>? ProductImages { get; set; }
        public DbSet<Image>? Images { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<BFUser>? BFUsers { get; set; }
        public DbSet<BFRole>? BFRoles { get; set; }
        public DbSet<Comment>? Comments { get; set; }
        public DbSet<Seller>? Sellers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.ApplyConfiguration(new ImageConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new BFRoleConfiguration());
            modelBuilder.ApplyConfiguration(new BFUserConfiguration());
            modelBuilder.ApplyConfiguration(new BFUserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());
            modelBuilder.ApplyConfiguration(new SellerConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new VariantConfiguration());

            modelBuilder.Entity<BFUserRole>().HasKey(x => new {x.BFRoleId, x.BFUserId});

            
            
            
        }

      
    }
}
