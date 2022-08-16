using Buyfilet.Common;
using Buyfilet.DTOs;
using Buyfilet.Entities;

namespace Buyfilet.BLL.Interfaces
{
    public interface IProductService:IService<ProductCreateDto,ProductUpdateDto,ProductListDto,Product>
    {
        Task<IResponse<List<ProductListDto>>> GetProductsWithCategory();
        Task<IResponse<List<ProductListDto>>> GetProductsInCategory(int categoryId);
        Task<IResponse<List<ProductListDto>>> GetPopularProductsInCategory(int categoryId);
        Task<IResponse<ProductListDto>> GetProductWithCategory(int id);
    //    Task<IResponse<List<ProductListDto>>> GetProductsWithFilter(List<string> variants);
        Task<IResponse<List<ProductListDto>>> GetHomeProducts();
        Task<IResponse> AddHomeProducts(int id);
        Task<IResponse<List<ProductListDto>>> GetPopulerProducts();
        Task<IResponse<ProductListDto>> GetDealProduct(int id);
        Task<IResponse<ProductListDto>> GetProductWithAllRelations(int id);
        Task<IResponse<List<ProductListDto>>> GetSimilarProducts(int id);
        Task<IResponse<List<ProductListDto>>> GetVariousProducts(int id);


    }
}
