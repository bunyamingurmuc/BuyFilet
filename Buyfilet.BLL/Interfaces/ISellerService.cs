using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.DTOs;
using Buyfilet.Entities.Seller;

namespace Buyfilet.BLL.Interfaces
{
    public interface ISellerService:IService<SellerCreateDto, SellerUpdateDto, SellerListDto,Seller>
    {
    }
}
