using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buyfilet.DTOs
{
    public class ProductHomeDto
    {
        public ProductListDto MainProduct { get; set; }
        public List<ProductListDto> RevelantProducts{ get; set; } //alakalı ürünler 
        public List<ProductListDto> SimilarProducts { get; set; }
        public List<ProductListDto> VariousProducts { get; set; }
        

    }
}
