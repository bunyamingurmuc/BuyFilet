using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.Entities.Interfaces;

namespace Buyfilet.Entities
{
    public class Seller:BaseEntity
    {
        public long TcNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Logo { get; set; }
        public bool IsApproved { get; set; }=false;
        public List<Product> Products { get; set; }
        public List<QuestionAndAnswer>? QuestionAndAnswers { get; set; }


    }
}
