using Buyfilet.BLL.Interfaces;
using Buyfilet.Common;
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
            var homeProducts = responseProduct.Data.AsQueryable();
            homeProducts.Where(i => i.IsHome == true);
            
            var dto = new HomeDto()
            {
                QuickViewProduct = new ProductListDto(),
                Products = homeProducts.ToList(),
                Categories = responseCategory.Data
            };
            
            return View(dto);

      
    }
        public IActionResult Product()
        {
            return View();
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
