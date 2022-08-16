using Buyfilet.DTOs;
using Buyfilet.Entities;

namespace Buyfilet.BLL.Interfaces
{
    public interface ISellerService:IService<SellerCreateDto, SellerUpdateDto, SellerListDto,Seller>
    {
    }
}
