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
                
                
                new BFUser() {Id = 1,  Name = "Mahmut", Password = "1", Surname = "gürmüç", Username = "mahmutgurmuc", },
                new BFUser() {Id = 2,  Name = "Mahmut", Password = "1", Surname = "gürmüç", Username = "mahmutgurmuc"},
                new BFUser() {Id = 3,  Name = "veysel", Password = "1", Surname = "gürmüç", Username = "veyselgurmuc"},
                new BFUser() {Id = 4,  Name = "Ahmet", Password = "1", Surname = "gürmüç", Username = "ahmetgurmuc"},
                new BFUser() {Id = 5,  Name = "Mahmut", Password = "1", Surname = "gürmüç", Username = "mahmutgurmuc"},
                new BFUser() {Id = 6,  Name = "veysel", Password = "1", Surname = "gürmüç", Username = "veyselgurmuc"},
                new BFUser() {Id = 7,  Name = "Ahmet", Password = "1", Surname = "gürmüç", Username = "ahmetgurmuc"},
                new BFUser() {Id = 8,  Name = "Ahmet", Password = "1", Surname = "gürmüç", Username = "ahmetgurmuc"},
                new BFUser() {Id = 9,  Name = "Mahmut", Password = "1", Surname = "gürmüç", Username = "mahmutgurmuc"},
                new BFUser() {Id = 10, Name = "Mahmut", Password = "1", Surname = "gürmüç", Username = "mahmutgurmuc"},

                new BFUser() {Id = 11, Name = "veysel", Password = "1", Surname = "gürmüç", Username = "veyselgurmuc"},
                new BFUser() {Id = 12, Name = "Ahmet", Password = "1", Surname = "gürmüç", Username = "ahmetgurmuc"},
                new BFUser() {Id = 13, Name = "Mahmut", Password = "1", Surname = "gürmüç", Username = "mahmutgurmuc"},
                new BFUser() {Id = 14, Name = "veysel", Password = "1", Surname = "gürmüç", Username = "veyselgurmuc"},
                new BFUser() {Id = 15, Name = "Ahmet", Password = "1", Surname = "gürmüç", Username = "ahmetgurmuc"},
                new BFUser() {Id = 16, Name = "Ahmet", Password = "1", Surname = "gürmüç", Username = "ahmetgurmuc"},
                new BFUser() {Id = 17, Name = "Ahmet", Password = "1", Surname = "gürmüç", Username = "ahmetgurmuc"},
                new BFUser() {Id = 18, Name = "Ahmet", Password = "1", Surname = "gürmüç", Username = "ahmetgurmuc"},
                new BFUser() {Id = 19, Name = "Ahmet", Password = "1", Surname = "gürmüç", Username = "ahmetgurmuc"},
                new BFUser() {Id = 20, Name = "Ahmet", Password = "1", Surname = "gürmüç", Username = "ahmetgurmuc"},
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
                new BFRole(){ Id = 3,Definition = "customer representative"},
                new BFRole(){ Id = 4,Definition = "seller"},
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
                new BFUserRole(){BFRoleId = 1,BFUserId =2},
                new BFUserRole(){BFRoleId = 1,BFUserId =3},
                new BFUserRole(){BFRoleId = 1,BFUserId =4},
                new BFUserRole(){BFRoleId = 1,BFUserId =5},

                new BFUserRole(){BFRoleId =2,BFUserId =6,},
                new BFUserRole(){BFRoleId =2,BFUserId =7,},
                new BFUserRole(){BFRoleId =2,BFUserId =8,},
                new BFUserRole(){BFRoleId =2,BFUserId =9,}, 
                new BFUserRole(){BFRoleId= 2,BFUserId =10},

                new BFUserRole(){BFRoleId = 3,BFUserId =11},
                new BFUserRole(){BFRoleId = 3,BFUserId =12},
                new BFUserRole(){BFRoleId = 3,BFUserId =13},
                new BFUserRole(){BFRoleId = 3,BFUserId =14},
                new BFUserRole(){BFRoleId = 3,BFUserId =15},

                new BFUserRole(){BFRoleId = 4,BFUserId =16},
                new BFUserRole(){BFRoleId = 4,BFUserId =17},
                new BFUserRole(){BFRoleId = 4,BFUserId =18},
                new BFUserRole(){BFRoleId = 4,BFUserId =19},
                new BFUserRole(){BFRoleId = 4,BFUserId =20},


            });
        }
    }

}
