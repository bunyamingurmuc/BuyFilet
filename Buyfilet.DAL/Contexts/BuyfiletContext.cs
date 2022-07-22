using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.DAL.Configurations;
using Buyfilet.DAL.Configurations.CategoryConfigurations;
using Buyfilet.DAL.Configurations.ImageConfiguration;
using Buyfilet.DAL.Configurations.ProductConfigurations;
using Buyfilet.DAL.Configurations.UserConfigurations;
using Buyfilet.Entities;
using Buyfilet.Entities.ProductEntities;
using Microsoft.EntityFrameworkCore;

namespace Buyfilet.DAL.Contexts
{
    public class BuyfiletContext:DbContext
    {
        public BuyfiletContext(DbContextOptions<BuyfiletContext> options):base(options)
        {
        }
        public DbSet<Product>? Products { get; set; }
        public DbSet<ProductImage>? ProductImages { get; set; }
        public DbSet<Image>? Images { get; set; }

        public DbSet<ProductVariants>? ProductVariants { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<BFUser>? BFUsers { get; set; }
        public DbSet<BFRole>? BFRoles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ImageConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new BFRoleConfiguration());
            modelBuilder.ApplyConfiguration(new BFUserConfiguration());
            modelBuilder.ApplyConfiguration(new BFUserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new ProductVariantsConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());

           
            modelBuilder.Entity<BFUserRole>().HasKey(x => new {x.BFRoleId, x.BFUserId});
            base.OnModelCreating(modelBuilder);
        }

      
    }
}
