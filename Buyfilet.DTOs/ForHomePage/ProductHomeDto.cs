using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Buyfilet.DTOs
{
    public class ProductHomeDto
    {
        public ProductListDto MainProduct { get; set; }
        public int MainProductIndex { get; set; }
        public List<ProductListDto> RevelantProducts{ get; set; } //alakalı ürünler 
        public List<ProductListDto> SimilarProducts { get; set; }
        public double SimilarProductsPrice { get; set; }
       
        public int SimilarProductsCount { get; set; }
        public List<ProductListDto> SellersOtherProducts { get; set; }

        public List<ProductListDto> VariousProducts { get; set; }
        public List<ProductListDto> allproduct { get; set; }

        
       
    }
}
