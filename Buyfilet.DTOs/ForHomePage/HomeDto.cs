using Buyfilet.DTOs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buyfilet.DTOs
{
    public class HomeDto:IDto
    {
        
        public List<ProductListDto> Products { get; set; }
        public List<CategoryListDto> Categories { get; set; }
        public ProductListDto QuickViewProduct { get; set; }
      

    }
}
