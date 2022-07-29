using Buyfilet.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buyfilet.Entities
{
    public class Image:BaseEntity
    {
        public string ImagePath { get; set; }
 
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
