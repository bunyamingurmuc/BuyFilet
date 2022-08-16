using Buyfilet.Entities.Interfaces;



namespace Buyfilet.Entities
{
    public class QuestionAndAnswer : BaseEntity
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public int ResponseTime { get; set; }
        public int? SellerId { get; set; }
        public Seller? Seller { get; set; }
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
        public int? BFUserId { get; set; }
        public BFUser? BFUser { get; set; }
    }
}
