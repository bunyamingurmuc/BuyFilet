using Buyfilet.Common;
using Buyfilet.DTOs;
using Buyfilet.Entities;

namespace Buyfilet.BLL.Interfaces
{
    public interface IBFUserService:IService<BFUserCreateDto,BFUserUpdateDto,BFUserListDto,BFUser>
    {
        Task<IResponse<BFUserCreateDto>> CreateWithRoleAsync(BFUserCreateDto dto, int roleId);
        Task<IResponse<BFUserListDto>> ChechUserAsync(BFUserLoginDto dto);
        Task<IResponse<List<BFRoleListDto>>> GetRolesByUserIdAsync(int userId);
        
    }
}
