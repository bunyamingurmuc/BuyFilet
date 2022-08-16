using Buyfilet.Entities.Interfaces;

namespace Buyfilet.Entities
{
    public class ProductImage : BaseEntity
    {
        public string ImagePath { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
