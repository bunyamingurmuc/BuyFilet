using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.DTOs.Interfaces;

namespace Buyfilet.DTOs
{
    public class ProductCreateDto:IDto
    {
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public int NumberOfSales { get; set; }
        public string Description { get; set; }
        public bool IsDiscount { get; set; } //indirim var mı
        public bool IsHotProduct { get; set; } //Anasayfa Ürünü Mü?
        public int DiscountExpiresHour { get; set; }// İndirimin biteceği gün
        public int NumberOfEvaluations { get; set; }// Değerlendirme SAYISI
        public double EvaluationPoint { get; set; }// Değerlendirme puanı
        public int NumberOfClick { get; set; }// Değerlendirme SAYISI
        public int DiscountRate { get; set; }//indirim oranı
        public int Discount { get; set; } //indirim miktarı
        public int Stock { get; set; }
        public int Price { get; set; }
        public string StockCode { get; set; }


        //eklenenler
        public string Desfinition { get; set; }//ürününü genel özellikleri
        public string Detail1 { get; set; }
        public string Detail2 { get; set; }
        public string Detail3 { get; set; }
        public bool FreeCargo { get; set; }





        public int CategoryId { get; set; }
        public CategoryListDto Category { get; set; }
    }
}
