using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.Entities.Interfaces;

namespace Buyfilet.Entities
{
    public class Category : BaseEntity
    {
        public string Definition { get; set; }
        public int NumberOfSales { get; set; }
        public int ImportanceNumber { get; set; }
        public List<Image> Images { get; set; }
        public List<Product> Products { get; set; }

    }

}
