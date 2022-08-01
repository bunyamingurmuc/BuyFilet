using Buyfilet.DTOs.Interfaces;

namespace Buyfilet.DTOs
{
    public class ProductListDto:IDto
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }


        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfSales { get; set; }
        public int Stock { get; set; }
        public int DiscountRate { get; set; }//indirim oranı



        public bool IsHome { get; set; }
        public bool IsDiscount { get; set; } //indirim var mı
        public bool IsHotProduct { get; set; } //Anasayfa Ürünü Mü?
        public int NumberOfClick { get; set; }// Değerlendirme SAYISI
        public int DiscountExpiresHour { get; set; }// İndirimin biteceği gün
        public int NumberOfEvaluations { get; set; }// Değerlendirme SAYISI
        public int EvaluationPoint { get; set; }// Değerlendirme puanı
        public int Discount { get; set; } //indirim miktarı



        //eklenenler
        public string Desfinition { get; set; }//ürününü genel özellikleri
        public string Detail1 { get; set; }
        public string Detail2 { get; set; }
        public string Detail3 { get; set; }
        public bool FreeCargo { get; set; }
        public string StockCode { get; set; }







        public int CategoryId { get; set; }
        public CategoryListDto Category { get; set; }
        public List<ProductVariantDto> ProductVariants { get; set; }
        public List<ProductImageDto> ProductImages { get; set; }

    }

    public class ProductVariantDto:IDto
    {
        public int Id { get; set; }
        
        public double Price { get; set; }
        public double WithOutDiscount { get; set; }

        public string Name { get; set; }
        public string Definition { get; set; }
        public ProductListDto Product { get; set; }
        public int ProductListDtoId { get; set; }
    }
    public class ProductImageDto : IDto
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public ProductListDto Product { get; set; }
        public int ProductListDtoId { get; set; }


    }
}
