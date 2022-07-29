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
        public List<Buyfilet.Entities.Comment.Comment> Comments { get; set; }

    }
}
