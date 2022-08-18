using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.Entities.Interfaces;

namespace Buyfilet.Entities
{
    public class BFUser:BaseEntity
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string AvatarUrl { get; set; } = "https://mpng.subpng.com/20181128/gif/kisspng-ninja-portable-network-graphics-computer-icons-ava-macmacmac-5bfea49c377331.5470002815434149402271.jpg";
        public List<Comment> Comments { get; set; }
        public List<QuestionAndAnswer>? QuestionAndAnswers { get; set; }
        


    }
}
