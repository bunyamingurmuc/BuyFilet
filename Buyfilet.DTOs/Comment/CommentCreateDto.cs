using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.DTOs.Interfaces;

namespace Buyfilet.DTOs
{
    public class CommentCreateDto: IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public int EvaluationPoint { get; set; }
        public int ProductId { get; set; }
        public ProductListDto Product { get; set; }
        public int BFUserId { get; set; }
        public BFUserListDto BFUser { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public List<ImageListDto> Images { get; set; }


    }
}
