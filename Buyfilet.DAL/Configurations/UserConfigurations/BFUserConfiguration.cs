using Buyfilet.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Buyfilet.DAL.Configurations.UserConfigurations
{
    public class BFUserConfiguration : IEntityTypeConfiguration<BFUser>
    {
        public void Configure(EntityTypeBuilder<BFUser> builder)
        {
            builder.Property(x => x.Name).IsRequired();
            builder.HasData(new BFUser[]
            {
                new BFUser() {Id = 1, Name = "Mahmut", Password = "1", Surname = "gürmüç", Username = "mahmutgurmuc"},
                new BFUser() {Id = 2, Name = "veysel", Password = "1", Surname = "gürmüç", Username = "veyselgurmuc"},
                new BFUser() {Id = 3, Name = "Ahmet", Password = "1", Surname = "gürmüç", Username = "ahmetgurmuc"},
            });
        }
    }
    public class BFRoleConfiguration : IEntityTypeConfiguration<BFRole>
    {
        public void Configure(EntityTypeBuilder<BFRole> builder)
        {
            builder.Property(x => x.Definition).IsRequired();
            builder.HasData(new BFRole[]
            {
                new BFRole(){Id = 1, Definition = "admin"},
                new BFRole(){ Id = 2,Definition = "member"},
            });
        }
    }
    public class BFUserRoleConfiguration : IEntityTypeConfiguration<BFUserRole>
    {
        public void Configure(EntityTypeBuilder<BFUserRole> builder)
        {

            builder.HasData(new BFUserRole[]
            {
                new BFUserRole(){BFRoleId = 1,BFUserId =1},
                new BFUserRole(){BFRoleId = 2,BFUserId =1},
                new BFUserRole(){BFRoleId = 2,BFUserId =3},

            });
        }
    }

}
