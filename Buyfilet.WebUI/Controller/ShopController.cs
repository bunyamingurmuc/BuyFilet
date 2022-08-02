using Buyfilet.BLL.Interfaces;
using Buyfilet.Common;
using Buyfilet.Common.Enums;
using Buyfilet.DTOs;
using Buyfilet.WebUI.Extension;
using Microsoft.AspNetCore.Mvc;

namespace Buyfilet.WebUI.Controller
{
    public class ShopController : Microsoft.AspNetCore.Mvc.Controller
    {
        public readonly IProductService _productService;
        public readonly ICategoryService _categoryService;
        public ShopController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }


        public async Task<IActionResult> Home()
        {
            var responseProduct = await _productService.GetHomeProducts();
            var responseCategory = await _categoryService.GetCategoryDescending();
            if (responseProduct.ResponseType == ResponseType.NotFound && responseCategory.ResponseType == ResponseType.NotFound )
            {
                return NotFound();
            }

            if (responseProduct.ResponseType == ResponseType.ValidationError && responseCategory.ResponseType == ResponseType.ValidationError)
            {
                foreach (var error in responseCategory.ValidationErrors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                foreach (var error in responseProduct.ValidationErrors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return View(responseProduct.Data);
            }
            var homeProducts = responseProduct.Data.AsQueryable();
            homeProducts.Where(i => i.IsHome == true);
            
            var dto = new HomeDto()
            {
                QuickViewProduct = new ProductListDto(),
                Products = homeProducts.ToList(),
                Categories = responseCategory.Data,
            };
            
            return View(dto);

      
    }
        public async Task<IActionResult> Product(int id)
        {
            var responseProduct = await _productService.GetProductWithAllRelations(id);
            var mainProduct = responseProduct.Data;
            var revelantProducts = await _productService.GetProductsInCategory(mainProduct.CategoryId);
            var mainrevelantProducts = revelantProducts.Data;
            var similarProducts = await _productService.GetSimilarProducts(id);
            if (similarProducts.ResponseType == ResponseType.Success)
            {
                var dto = new ProductHomeDto()
                {
                    MainProduct = mainProduct,
                    RevelantProducts = mainrevelantProducts.ToList(),
                    SimilarProducts = similarProducts.Data,
                };
                return View(dto);
            }
            else
            {
                var dto = new ProductHomeDto()
                {
                    MainProduct = mainProduct,
                    RevelantProducts = mainrevelantProducts.ToList(),
                };
                return View(dto);
            }
            


            
        }
        public IActionResult Compare()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Wishlist()
        {
            return View();
        }

    }
}
