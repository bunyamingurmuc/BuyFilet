using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.Entities.Interfaces;

namespace Buyfilet.Entities.ProductEntities
{
    public class ProductVariants:BaseEntity
    {
        public string Name { get; set; }
        public string Definition { get; set; }
        public double WithOutDiscount { get; set; }
        public double Price { get; set; }

        public Product Product  { get; set; }
        public int ProductId  { get; set; }
    }
}
