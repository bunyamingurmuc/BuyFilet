using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Buyfilet.DTOs;
using Buyfilet.Entities;

namespace Buyfilet.BLL.Mappings.AutoMapper
{
    public class BFUserProfile:Profile
    {
        public BFUserProfile()
        {
            CreateMap<BFUser, BFUserCreateDto>().ReverseMap();
            CreateMap<BFUser, BFUserLoginDto>().ReverseMap();
            CreateMap<BFUser, BFUserListDto>().ReverseMap();
          

        }
    }
}
