using Buyfilet.DTOs;
using Buyfilet.DTOs.Interfaces;



namespace Buyfilet.DTOs
{
    public class QuestionAndAnswerListDto : IDto
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public int ResponseTime { get; set; }
        public int SellerId { get; set; }
        public SellerListDto Seller { get; set; }
        public int ProductId { get; set; }
        public ProductListDto Product { get; set; }
        public int BFUserId { get; set; }
        public BFUserListDto BFUser { get; set; }
    }
}
