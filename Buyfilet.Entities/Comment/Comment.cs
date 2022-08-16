using Buyfilet.Entities.Interfaces;

namespace Buyfilet.Entities
{
    public class Comment:BaseEntity
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public string Mail{ get; set; }
        public int EvaluationPoint { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int BFUserId { get; set; }
        public BFUser BFUser { get; set; }
    }
}
