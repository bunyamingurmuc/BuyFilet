using Buyfilet.Entities.Comment;
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
            //builder.HasData(new Comment[]
            //{
            //    new Comment(){}
            //})
        }
    }
}
