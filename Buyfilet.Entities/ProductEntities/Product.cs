using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Buyfilet.Entities.Interfaces;
using Buyfilet.Entities.ProductEntities;

namespace Buyfilet.Entities
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsHome { get; set; } = false;
        public int Stock { get; set; }
        public bool IsDiscount { get; set; } //indirim var mı
        public int DiscountRate { get; set; }//indirim oranı
        public bool IsHotProduct { get; set; } //Anasayfa Ürünü Mü?
        public int DiscountExpiresHour { get; set; }// İndirimin biteceği gün
        public int NumberOfEvaluations { get; set; }// Değerlendirme Sayısı
        public int NumberOfClick { get; set; }// Tıklanma Sayısı
        public double EvaluationPoint { get; set; }// Değerlendirme puanı
        public int Discount { get; set; } //indirim miktarı
        public int NumberOfSales { get; set; }


        //eklenenler
        public string Desfinition { get; set; }//ürününü genel özellikleri
        public string Detail1 { get; set; }
        public string Detail2 { get; set; }
        public string Detail3 { get; set; }
        public bool FreeCargo { get; set; } = false;


        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<ProductVariants> ProductVariants { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<Buyfilet.Entities.Comment.Comment> Comments { get; set; }
        public int SellerId { get; set; }
        public List<Seller.Seller> Sellers { get; set; }


    }
}
