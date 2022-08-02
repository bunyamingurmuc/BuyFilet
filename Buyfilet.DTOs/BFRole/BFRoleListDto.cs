using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.DTOs.Interfaces;

namespace Buyfilet.DTOs
{
    public class BFRoleListDto: IDto
    {
        public string Definition { get; set; }
        public int Id { get; set; }
    }
}
