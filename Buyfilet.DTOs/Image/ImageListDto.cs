using Buyfilet.DTOs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buyfilet.DTOs
{
    public class ImageListDto:IUpdateDto
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public CategoryListDto Category { get; set; }
        public int CategoryId { get; set; }
        public CommentListDto Comment { get; set; }

    }
}
