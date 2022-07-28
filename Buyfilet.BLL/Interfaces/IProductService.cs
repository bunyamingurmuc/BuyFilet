using Buyfilet.Common;
using Buyfilet.DTOs;
using Buyfilet.Entities;
using Buyfilet.Entities.ProductEntities;

namespace Buyfilet.BLL.Interfaces
{
    public interface IProductService:IService<ProductCreateDto,ProductUpdateDto,ProductListDto,Product>
    {
        Task<IResponse<List<ProductListDto>>> GetProductsWithCategory();
        Task<IResponse<List<ProductListDto>>> GetProductsInCategory(int categoryId);
        Task<IResponse<List<ProductListDto>>> GetPopularProductsInCategory(int categoryId);
        Task<IResponse<ProductListDto>> GetProductWithCategory(int id);

        Task<IResponse<List<ProductListDto>>> GetProductsWithFilter(List<ProductVariantDto> variants);
        Task<IResponse<List<ProductListDto>>> GetHomeProducts();
        Task<IResponse> AddHomeProducts(int id);
        Task<IResponse<List<ProductListDto>>> GetPopulerProducts();
        Task<IResponse<ProductListDto>> GetDealProduct(int id);
    }
}
