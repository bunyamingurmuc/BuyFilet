using AutoMapper;
using Buyfilet.BLL.Interfaces;
using Buyfilet.Common;
using Buyfilet.Common.Enums;
using Buyfilet.DAL.UnitOfWork;
using Buyfilet.DTOs;
using Buyfilet.Entities;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Buyfilet.BLL.Services
{
    internal class ProductService : Service<ProductCreateDto, ProductUpdateDto, ProductListDto, Product>, IProductService
    {
        public readonly IUOW _uow;
        public readonly IMapper _mapper;
        public readonly IValidator<ProductCreateDto> _createDtoValidator;
        public readonly IValidator<ProductUpdateDto> _updateDtoValidator;
        public ProductService(IMapper mapper, IValidator<ProductCreateDto> createDtoValidator, IValidator<ProductUpdateDto> updateDtoValidator, IUOW uow) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
            _mapper = mapper;
            _createDtoValidator = createDtoValidator;
            _updateDtoValidator = updateDtoValidator;
            _uow = uow;
        }

        public async Task<IResponse<List<ProductListDto>>> GetProductsWithCategory()
        {
            var products =await _uow.GetRepository<Product>().GetQuery();
            var productWithCategories = await products.Include(i => i.Category).AsNoTracking().SingleOrDefaultAsync();
            var mapped = _mapper.Map<List<ProductListDto>>(productWithCategories);
            return new Response<List<ProductListDto>>(ResponseType.Success, mapped);

        }
        public async Task<IResponse<List<ProductListDto>>> GetProductsInCategory(int categoryId)
        {
            var product = await _uow.GetRepository<Product>().GetQuery();
            var categoriesAndProducts1 = product.Where(i => i.CategoryId == categoryId).Include(i=>i.Category).Include(i=>i.ProductVariants).Include(i=>i.ProductImages).AsNoTracking();
            var categoriesAndProducts = await categoriesAndProducts1.ToListAsync();
            if (categoriesAndProducts == null)
            {
                return new Response<List<ProductListDto>>(ResponseType.NotFound,
                    $"{categoryId} id'ye sahip ürün bulunamadı");
            }
            var mapped = _mapper.Map<List<ProductListDto>>(categoriesAndProducts);
            return new Response<List<ProductListDto>>(ResponseType.Success, mapped);
        }

        public async Task<IResponse<List<ProductListDto>>> GetPopularProductsInCategory(int categoryId)
        {
            var products=await _uow.GetRepository<Product>().GetQuery();
              await  products.Where(i=>i.CategoryId==categoryId).Include(x=>x.Category).OrderByDescending(x=>x.NumberOfSales).AsNoTracking().ToListAsync();
            var mapped = _mapper.Map<List<ProductListDto>>(products);
            return new Response<List<ProductListDto>>(ResponseType.Success, mapped);

        }

        public async Task<IResponse<List<ProductListDto>>> GetProductsWithFilter(List<ProductVariantDto> variants)
        {
            var products = await _uow.GetRepository<Product>().GetQuery();
            await products.ToListAsync();
            var filterProducts = new List<Product>();
            foreach (var product in products)
            {
                foreach (var productVariant in product.ProductVariants)
                {
                    foreach (var variant in variants)
                    {
                        if (productVariant.Name == variant.Name && productVariant.Definition == variant.Name && productVariant.Name != null && productVariant.Definition != null)
                        {
                            filterProducts.Add(product);
                        }
                    }
                }
            }
            if (filterProducts.Count == 0)
            {
                return new Response<List<ProductListDto>>(ResponseType.NotFound,
                    "İstediğiniz filtreye sahip ürün bulunamadı");
            }
            
            var mapped = _mapper.Map<List<ProductListDto>>(filterProducts);
            return new Response<List<ProductListDto>>(ResponseType.Success, mapped);
        }

        public async Task<IResponse<List<ProductListDto>>> GetHomeProducts()
        {
            var products = await _uow.GetRepository<Product>().GetQuery();
            await products.Include(i=>i.ProductImages).Include(i=>i.Category).Include(i => i.ProductVariants).ToListAsync();
            var mapped = _mapper.Map<List<ProductListDto>>(products);
            return new Response<List<ProductListDto>>(ResponseType.Success, mapped);
        }

        public async Task<IResponse> AddHomeProducts(int id)
        {
            var product = await _uow.GetRepository<Product>().FindAsync(id);
            if (product==null)
            {
                return new Response<List<ProductUpdateDto>>(ResponseType.NotFound, $"{id}ye ship ürün bulunamadı");
            }
            product.IsHome=true;
            await _uow.SaveChangesAsycn();
            return new Response(ResponseType.Success);
        }

        public async Task<IResponse<List<ProductListDto>>> GetPopulerProducts()
        {
            var products = await _uow.GetRepository<Product>().GetQuery();
           await products.OrderByDescending(i => i.NumberOfSales).AsNoTracking().ToListAsync();
            var mapped = _mapper.Map<List<ProductListDto>>(products);
            return new Response<List<ProductListDto>>(ResponseType.Success, mapped);

        }

        public async Task<IResponse<ProductListDto>> GetDealProduct(int id)
        {
            var product = await _uow.GetRepository<Product>().GetByFilterAsycn(i=>i.Id==id);
            if (product==null)
            {
                return new Response<ProductListDto>(ResponseType.NotFound, $"{id} ye sahip ürün bulunamadı");
            }
            var mapped = _mapper.Map<ProductListDto>(product);
            return new Response<ProductListDto>(ResponseType.Success, mapped);
        }

        public async Task<IResponse<ProductListDto>> GetProductWithCategory(int id)
        {
            var products = await _uow.GetRepository<Product>().GetQuery();
            var product = products.Where(i => i.Id == id).Include(i=>i.ProductImages).Include(i => i.Category).Include(i => i.ProductVariants);
           
            var lastestproduct=await product.SingleOrDefaultAsync();
           
            if (lastestproduct == null)
            {
                return new Response<ProductListDto>(ResponseType.NotFound, $"{id} ye sahip ürün bulunamadı");
            }
            var mapped= _mapper.Map<ProductListDto>(lastestproduct);
            return new Response<ProductListDto>(ResponseType.Success,mapped);
        }
    }
}
