using Buyfilet.DTOs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buyfilet.DTOs
{
    public class VariantCreateDto:IDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
