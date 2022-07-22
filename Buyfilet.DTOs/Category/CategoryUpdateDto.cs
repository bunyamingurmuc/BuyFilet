using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.DTOs.Interfaces;

namespace Buyfilet.DTOs
{
    public class CategoryUpdateDto : IUpdateDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public List<ProductListDto> Products { get; set; }
        public ImageListDto Image { get; set; }
        public int ImageListDtoId { get; set; }
        public int ImportanceNumber { get; set; }

    }
}
