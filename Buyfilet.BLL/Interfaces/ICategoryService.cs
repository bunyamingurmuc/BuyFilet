using Buyfilet.Common;
using Buyfilet.DTOs;
using Buyfilet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buyfilet.BLL.Interfaces
{
    public interface ICategoryService:IService<CategoryCreateDto,CategoryUpdateDto,CategoryListDto,Category>
    {
        Task<IResponse<List<CategoryListDto>>> GetCategoryDescending();
    }
}
