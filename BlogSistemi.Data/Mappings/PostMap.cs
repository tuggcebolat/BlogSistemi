using BlogSistemi.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSistemi.Data.Mappings
{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasData(new Post
            {
                Id = Guid.NewGuid(),
                Name = "MVC PROJE 1",
                Description = "lorem ipsum dolor sit amet",
                Image = "",
                CreateDate = DateTime.Now,
                CategoryId = Guid.Parse("87607752-BD4F-498C-9C1C-EFC5573D120D"),
                UserId = Guid.Parse("2D6D0E61-C1BF-4878-ACF0-A33E6BC3CCF0"),
            },
            new Post
            {
                Id = Guid.NewGuid(),
                Name = "MVC PROJE 2",
                Description = "lorem ipsum dolor sit amet",
                Image = "",
                CreateDate = DateTime.Now,

                CategoryId = Guid.Parse("FCA52C48-C773-4F61-B892-0673234348DD"),
                UserId= Guid.Parse("61CDCC92-E5E1-4DA9-8E36-0AF0950472DD"),


            }); ;
        }
    }
}
