using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.DTOs.Interfaces;

namespace Buyfilet.DTOs
{
    public class ProductUpdateDto:IUpdateDto
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool isInStock { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfSales { get; set; }
        public bool IsHome { get; set; }
        public bool IsDiscount { get; set; } //İndirim var mı
        public int DiscountRate { get; set; }//İndirim oranı
        public bool IsHotProduct { get; set; } //Anasayfa Ürünü Mü?
        public int NumberOfClick { get; set; }// Tıklanma Sayısı
        public int DiscountExpiresHour { get; set; }// İndirimin biteceği gün
        public int NumberOfEvaluations { get; set; }// Değerlendirme SAYISI
        public int EvaluationPoint { get; set; }// Değerlendirme puanı
        public int Discount { get; set; } //İndirim miktarı
        public string Desfinition { get; set; }//Ürününü genel özellikleri
        public string Detail1 { get; set; }
        public string Detail2 { get; set; }
        public string Detail3 { get; set; }
        public bool FreeCargo { get; set; }
        public int CargoDay { get; set; }

        public string StockCode { get; set; }
        public double WithOutDiscount { get; set; }
        public double Price { get; set; }




        //Listeler
        public int CategoryId { get; set; }
        public CategoryListDto Category { get; set; }
        public List<ProductImageDto> ProductImages { get; set; }
        public List<VariantUpdateDto> Variants { get; set; }
        public int SellerId { get; set; }
        public SellerUpdateDto Seller { get; set; }
        public List<CommentUpdateDto> Comments { get; set; }
        public List<QuestionAndAnswerListDto> QuestionAndAnswers { get; set; }
        public double BFMoney { get; set; }


    }
}
