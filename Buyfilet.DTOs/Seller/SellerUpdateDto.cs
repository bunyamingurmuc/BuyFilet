using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.DTOs.Interfaces;

namespace Buyfilet.DTOs
{
    public class SellerUpdateDto:IUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TcNo { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Logo { get; set; }
        public List<ProductListDto> Products { get; set; }
    
    }
}
