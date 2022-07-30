using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.DTOs;
using Buyfilet.Entities.Comment;

namespace Buyfilet.BLL.Interfaces
{
    public interface ICommentService:IService<CommentCreateDto,CommentUpdateDto,CommentListDto,Comment>
    {

    }
}
