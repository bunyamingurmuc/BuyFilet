
using Buyfilet.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buyfilet.DAL.Configurations.CommentCongigurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(x => x.Mail).IsRequired();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Mail).IsRequired();
            builder.Property(x => x.EvaluationPoint).IsRequired();
            builder.HasData(new Comment[]
            {
                new Comment() { Id = 1, BFUserId = 1, EvaluationPoint = 50, Mail = "mahmutgurmuc@gmail.com", Name = "Mahmut", Description = "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", ProductId = 1, },
                new Comment() { Id = 2, BFUserId = 2, EvaluationPoint = 50, Mail = "mahmutgurmuc@gmail.com", Name = "Mahmut", Description = "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", ProductId = 1, },
                new Comment() { Id = 3, BFUserId = 3, EvaluationPoint = 50, Mail = "mahmutgurmuc@gmail.com", Name = "Mahmut", Description = "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", ProductId = 1, },
                new Comment() { Id = 4, BFUserId = 4, EvaluationPoint = 50, Mail = "mahmutgurmuc@gmail.com", Name = "Mahmut", Description = "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", ProductId = 1, },
                new Comment() { Id = 5, BFUserId = 5, EvaluationPoint = 50, Mail = "mahmutgurmuc@gmail.com", Name = "Mahmut", Description = "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", ProductId = 1, },
                new Comment() { Id = 6, BFUserId = 6, EvaluationPoint = 50, Mail = "mahmutgurmuc@gmail.com", Name = "Mahmut", Description = "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", ProductId = 1, },
                new Comment() { Id = 7, BFUserId = 7, EvaluationPoint = 50, Mail = "mahmutgurmuc@gmail.com", Name = "Mahmut", Description = "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", ProductId = 1, },
                new Comment() { Id = 8, BFUserId = 8, EvaluationPoint = 50, Mail = "mahmutgurmuc@gmail.com", Name = "Mahmut", Description = "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", ProductId = 1, },
                new Comment() { Id = 9, BFUserId = 9, EvaluationPoint = 50, Mail = "mahmutgurmuc@gmail.com", Name = "Mahmut", Description = "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", ProductId = 1, },

                new Comment() { Id = 10, BFUserId = 10, EvaluationPoint = 50, Mail = "mahmutgurmuc@gmail.com", Name = "Mahmut", Description = "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", ProductId = 2, },
                new Comment() { Id = 11, BFUserId = 11, EvaluationPoint = 50, Mail = "mahmutgurmuc@gmail.com", Name = "Mahmut", Description = "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", ProductId = 2, },
                new Comment() { Id = 12, BFUserId = 12, EvaluationPoint = 50, Mail = "mahmutgurmuc@gmail.com", Name = "Mahmut", Description = "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", ProductId = 2, },
                new Comment() { Id = 13, BFUserId = 13, EvaluationPoint = 50, Mail = "mahmutgurmuc@gmail.com", Name = "Mahmut", Description = "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", ProductId = 2, },
                new Comment() { Id = 14, BFUserId = 14, EvaluationPoint = 50, Mail = "mahmutgurmuc@gmail.com", Name = "Mahmut", Description = "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", ProductId = 2, },
                new Comment() { Id = 15, BFUserId = 15, EvaluationPoint = 50, Mail = "mahmutgurmuc@gmail.com", Name = "Mahmut", Description = "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", ProductId = 2, },
                new Comment() { Id = 16, BFUserId = 16, EvaluationPoint = 50, Mail = "mahmutgurmuc@gmail.com", Name = "Mahmut", Description = "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", ProductId = 2, },
                new Comment() { Id = 17, BFUserId = 17, EvaluationPoint = 50, Mail = "mahmutgurmuc@gmail.com", Name = "Mahmut", Description = "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", ProductId = 2, },
                new Comment() { Id = 18, BFUserId = 18, EvaluationPoint = 50, Mail = "mahmutgurmuc@gmail.com", Name = "Mahmut", Description = "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", ProductId = 2, },
                new Comment() { Id = 19, BFUserId = 19, EvaluationPoint = 50, Mail = "mahmutgurmuc@gmail.com", Name = "Mahmut", Description = "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", ProductId = 2, },
                new Comment() { Id = 20, BFUserId = 20, EvaluationPoint = 50, Mail = "mahmutgurmuc@gmail.com", Name = "Mahmut", Description = "deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme deneme ", ProductId = 1, },
            });

        }
    }
}
