using Buyfilet.DTOs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buyfilet.DTOs
{
    public class ImageUpdateDto:IUpdateDto
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public CategoryListDto Category { get; set; }
        public int CategoryListDtoId { get; set; }
        public CommentListDto Comment { get; set; }

    }
}
