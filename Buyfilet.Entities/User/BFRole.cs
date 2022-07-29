using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.Entities.Interfaces;

namespace Buyfilet.Entities
{
    public class BFRole:BaseEntity
    {
        public string Definition { get; set; }
        public List<BFUserRole> BfUserRoles { get; set; }
    }

    public class BFUserRole:BaseEntity
    {
        public int BFRoleId { get; set; }
        public int BFUserId { get; set; }
        public BFUser BFUser { get; set; }
        public BFRole BFRole { get; set; }
    }
}
