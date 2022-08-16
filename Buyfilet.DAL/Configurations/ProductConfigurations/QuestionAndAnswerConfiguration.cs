using Buyfilet.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buyfilet.DAL.Configurations.ProductConfigurations
{
    public class QuestionAndAnswerConfiguration : IEntityTypeConfiguration<QuestionAndAnswer>
    {
        public void Configure(EntityTypeBuilder<QuestionAndAnswer> builder)
        {
            builder.Property(x => x.Answer).HasMaxLength(1700);
            builder.Property(x => x.Question).HasMaxLength(1700);
            builder.HasData(new QuestionAndAnswer[]
            {
                new QuestionAndAnswer(){ Id=1, BFUserId=1, ProductId=1, SellerId=1, Question="deneme deneme deneme ", Answer="deneme deneme deneme deneme ", ResponseTime=1},
                new QuestionAndAnswer(){ Id=2, BFUserId=2, ProductId=1, SellerId=1, Question="deneme deneme deneme ", Answer="deneme deneme deneme deneme ", ResponseTime=1},
                new QuestionAndAnswer(){ Id=3, BFUserId=3, ProductId=1, SellerId=1, Question="deneme deneme deneme ", Answer="deneme deneme deneme deneme ", ResponseTime=1},
                new QuestionAndAnswer(){ Id=4, BFUserId=4, ProductId=1, SellerId=1, Question="deneme deneme deneme ", Answer="deneme deneme deneme deneme ", ResponseTime=1},
                new QuestionAndAnswer(){ Id=5, BFUserId=5, ProductId=1, SellerId=1, Question="deneme deneme deneme ", Answer="deneme deneme deneme deneme ", ResponseTime=1},
                new QuestionAndAnswer(){ Id=6, BFUserId=6, ProductId=1, SellerId=1, Question="deneme deneme deneme ", Answer="deneme deneme deneme deneme ", ResponseTime=1},
                

            });
        }
    }
}
